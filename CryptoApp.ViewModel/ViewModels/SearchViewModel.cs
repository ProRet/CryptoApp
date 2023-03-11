using CryptoApp.Extentions.Extensions;
using CryptoApp.Models;
using System.Collections.ObjectModel;

namespace CryptoApp.ViewModel.ViewModels
{
    public class SearchViewModel
    {
        public ObservableCollection<CryptoCoin> cryptoCoins { get; }=new ObservableCollection<CryptoCoin>();

        public SearchViewModel()
        {
            cryptoCoins.FillCryptoCoins();
        }
    }
}
