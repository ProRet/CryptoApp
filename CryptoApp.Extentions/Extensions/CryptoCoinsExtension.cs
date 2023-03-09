using CryptoApp.Models;
using CryptoApp.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace CryptoApp.Extentions.Extensions
{
    public static class CryptoCoinsExtension
    {
        public static async Task FillCryptoCoins(this ObservableCollection<CryptoCoin> cryptoCoins)
        {
            var cryptocurrencies = await CoinCapService.Instance.GetCryptoCoinsAsync(10);

            cryptoCoins.AddRange(cryptocurrencies);
        }

    }
}
