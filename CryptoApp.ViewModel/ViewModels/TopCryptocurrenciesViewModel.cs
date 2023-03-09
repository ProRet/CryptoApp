using CryptoApp.Models;
using System.Collections.ObjectModel;
using CryptoApp.Extentions.Extensions;


namespace CryptoApp.ViewModel.ViewModels
{
    public class TopCryptocurrenciesViewModel
    {
        public ObservableCollection<CryptoCoin> CryptoCoins { get; } = new ObservableCollection<CryptoCoin>();

       public TopCryptocurrenciesViewModel()
        {  
            CryptoCoins.FillCryptoCoins();
        }
    }
}
