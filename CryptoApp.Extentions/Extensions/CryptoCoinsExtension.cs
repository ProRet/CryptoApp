using CryptoApp.Models;
using CryptoApp.Services;
using System.Collections.ObjectModel;

namespace CryptoApp.Extentions.Extensions
{
    public static class CryptoCoinsExtension
    {
        public static async void FillCryptoCoins(this ObservableCollection<CryptoCoin> cryptoCoins, int limit=230)
        {
            var cryptocurrencies = await CoinCapService.Instance.GetCryptoCoinsAsync(limit);

            cryptoCoins.AddRange(cryptocurrencies);
        }

    }
}
