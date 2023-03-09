using CryptoApp.Models;
using CryptoApp.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace CryptoApp.Extentions.Extensions
{
    public static class CryptoCoinsExtension
    {
        private static async Task FillCryptoMarkets(this ObservableCollection<CryptoCoin> cryptoCoins)
        {
            var cryptocurrencies = await CoinCapService.Instance.GetCryptoCoinsAsync(10);

            cryptoCoins.AddRange(cryptocurrencies);
        }

    }
}
