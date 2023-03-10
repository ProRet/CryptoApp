﻿using CryptoApp.Models;
using CryptoApp.Services;
using System.Collections.ObjectModel;

namespace CryptoApp.Extentions.Extensions
{
    public static class CryptoCoinsExtension
    {
        public static async void FillCryptoCoins(this ObservableCollection<CryptoCoin> cryptoCoins)
        {
            var cryptocurrencies = await CoinCapService.Instance.GetCryptoCoinsAsync(10);

            cryptoCoins.AddRange(cryptocurrencies);
        }

    }
}
