using CryptoApp.Models;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using CryptoApp.Models.Models;

namespace CryptoApp.Services
{
    public class CoinCapService
    {

        private static readonly Lazy<CoinCapService> coinCapService = new Lazy<CoinCapService>(() => new CoinCapService());

        public static CoinCapService Instance { get { return coinCapService.Value; } }
        public async Task<CryptoCoin[]> GetCryptoCoinsAsync(int limit=230)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.coincap.io/v2/assets?limit=" + limit);
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var root = JObject.Parse(json)["data"];
            CryptoCoin[] cryptoCoins = new CryptoCoin[limit];
            for (int i = 0; i < limit; i++)
            {
                var obj = root[i];
                string id = (string)obj.SelectToken("id");
                int rank = (int)obj.SelectToken("rank");
                string symbol = (string)obj.SelectToken("symbol");
                string name = (string)obj.SelectToken("name");
                double supply = (double)obj.SelectToken("supply");
                supply = Math.Round(supply);
                double maxSupply;
                if (obj.SelectToken("maxSupply").ToString() == "")
                {
                    maxSupply = 0;
                }
                else
                {
                    maxSupply = (double)obj.SelectToken("maxSupply");
                }
                double marketCapUsd = (double)obj.SelectToken("marketCapUsd");
                double volumeUsd24Hr = (double)obj.SelectToken("volumeUsd24Hr");
                volumeUsd24Hr = Math.Round(volumeUsd24Hr);
                double priceUsd = (double)obj.SelectToken("priceUsd");
                double changePercent24Hr = (double)obj.SelectToken("changePercent24Hr");
                

                cryptoCoins[i] = new CryptoCoin(id, rank, symbol, name,
                supply, maxSupply, marketCapUsd, volumeUsd24Hr, priceUsd, changePercent24Hr);
            }
            return cryptoCoins;
        }

         public async Task<CryptoMarket> GetCryptoMarketsAsync(string coin)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.coincap.io/v2/assets/" + coin + "/markets?limit=1");
            var content = new StringContent("", null, "text/plain");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var root = JObject.Parse(json)["data"][0];
            CryptoMarket cryptoMarkets;
                string exchangeId = (string)root.SelectToken("exchangeId");
                string baseId = (string)root.SelectToken("baseId");
                double priceUsd = (double)root.SelectToken("priceUsd");    
                cryptoMarkets = new CryptoMarket(exchangeId,baseId,priceUsd);
            return cryptoMarkets;
        }

        public async Task<DetailedCryptoInfo[]> GetDetailedCryptoInfo(int limit=230)
        {
            var CryptoCoins = await GetCryptoCoinsAsync();
            DetailedCryptoInfo[] detailedCryptoInfos = new DetailedCryptoInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                CryptoMarket cryptoMarket = await GetCryptoMarketsAsync(CryptoCoins[i].Id);
                detailedCryptoInfos[i] = new DetailedCryptoInfo(CryptoCoins[i].Name, CryptoCoins[i].PriceUsd, CryptoCoins[i].ChangePercent24Hr, CryptoCoins[i].Supply.ToString(), cryptoMarket.ExchangeId, cryptoMarket.PriceUsd);
            }
            return detailedCryptoInfos;
        }
        
    }
}
