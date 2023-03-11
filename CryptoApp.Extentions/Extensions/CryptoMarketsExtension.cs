using CryptoApp.Models.Models;
using CryptoApp.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace CryptoApp.Extentions.Extensions
{
    public static class CryptoMarketsExtension
    {
        public static async void FillCryptoMarkets(this ObservableCollection<CryptoMarket> cryptoMarkets,string coin)
        {
            var cryptomarkets = await CoinCapService.Instance.GetCryptoMarketsAsync(coin);

            cryptoMarkets.AddRange(cryptomarkets);
        }

    }
}
