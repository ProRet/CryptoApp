using CryptoApp.Models;
using System.Collections.ObjectModel;
namespace CryptoApp.ViewModel.ViewModels
{
    public class TopCryptocurrenciesViewModel
    {
        public ObservableCollection<CryptoCoin> CryptoCoins { get; } = new ObservableCollection<CryptoCoin>();

       
    }
}
