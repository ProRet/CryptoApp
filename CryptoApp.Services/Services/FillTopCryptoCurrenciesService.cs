using CryptoApp.Models;
using CryptoApp.ViewModel.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CryptoApp.Services.Services
{
    public static class FillTopCryptoCurrenciesService
    {
        private static async Task FillTopCryptoCurrencies(this ObservableCollection<CryptoCoin> cryptoCoins)
        {
            var cryptocurrencies = await CoinCapService.Instance.GetCryptoCoinsAsync(10);

            cryptoCoins.AddRange(cryptocurrencies);
        }
    }
}
