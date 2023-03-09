﻿using CryptoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using CryptoApp.Models.Models;

namespace CryptoApp.Services
{
    public class CoinCapService
    {
        public async Task<CryptoCoin[]> GetCryptoCoinsAsync(int limit)
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
                double priceUsd = (double)obj.SelectToken("priceUsd");
                double changePercent24Hr = (double)obj.SelectToken("changePercent24Hr");
                double vwap24Hr = (double)obj.SelectToken("vwap24Hr");

                cryptoCoins[i] = new CryptoCoin(id, rank, symbol, name,
                supply, maxSupply, marketCapUsd, volumeUsd24Hr, priceUsd, changePercent24Hr, vwap24Hr);
            }
            return cryptoCoins;
        }

        static public async Task<CryptoMarket[]> GetAsync(string coin)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.coincap.io/v2/assets/" + coin + "/markets");
            var content = new StringContent("", null, "text/plain");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var root = JObject.Parse(json)["data"];
            CryptoMarket[] cryptoMarkets = new CryptoMarket[10];
            for (int i = 0; i < 10; i++)
            {
                string a = (string)root[i]["exchangeId"];
                string b = (string)root[i]["baseId"];
                string c = (string)root[i]["quoteId"];
                string d = (string)root[i]["baseSymbol"];
                string e = (string)root[i]["quoteSymbol"];
                double r = (double)root[i]["volumeUsd24Hr"];
                double y = (double)root[i]["priceUsd"];
                double o = (double)root[i]["volumePercent"];
                cryptoMarkets[i] = new CryptoMarket(a, b, c, d, e, r, y, o);
            }
            return cryptoMarkets;
        }

        private static readonly Lazy<CoinCapService> coinCapService = new Lazy<CoinCapService>(() => new CoinCapService());

        public static CoinCapService Instance { get { return coinCapService.Value; } }
        
    }
}