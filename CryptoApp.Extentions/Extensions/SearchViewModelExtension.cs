using CryptoApp.Models;
using CryptoApp.Services.Services;
using System.Collections.ObjectModel;


namespace CryptoApp.Extentions.Extensions
{
    public static class SearchViewModelExtension
    {
        public static void SearchCoins(
            this ObservableCollection<CryptoCoin> FoundCoins, string Name, ObservableCollection<CryptoCoin> CryptoCoins)
        {
            FoundCoinsService.SearchCoins(FoundCoins, Name, CryptoCoins);
        }

    }
}
