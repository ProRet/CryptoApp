using CryptoApp.Models.Models;
using CryptoApp.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace CryptoApp.Extentions.Extensions
{
    public static class CryptoMarketsExtension
    {
        private static async Task FillCryptoMarkets(this ObservableCollection<CryptoMarket> cryptoMarkets)
        {
            var cryptocurrencies = await CoinCapService.Instance.GetCryptoCoinsAsync(1);

            cryptoMarkets.AddRange(cryptocurrencies);
        }

    }
}
