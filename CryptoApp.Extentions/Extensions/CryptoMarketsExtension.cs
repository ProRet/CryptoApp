using CryptoApp.Models.Models;
using CryptoApp.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace CryptoApp.Extentions.Extensions
{
    public static class CryptoMarketsExtension
    {
        public static async Task FillCryptoMarkets(this ObservableCollection<CryptoMarket> cryptoMarkets)
        {
            var cryptomarkets = await CoinCapService.Instance.GetCryptoMarketsAsync("bitcoin");

            cryptoMarkets.AddRange(cryptomarkets);
        }

    }
}
