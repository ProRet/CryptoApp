using CryptoApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.ViewModel.ViewModels
{
    public class TopCryptocurrenciesViewModel
    {
        public ObservableCollection<CryptoCoin> CryptoCoins { get; set; }
        public TopCryptocurrenciesViewModel()
        {
            CryptoCoins = new ObservableCollection<CryptoCoin>();
        }
        public TopCryptocurrenciesViewModel(ObservableCollection<CryptoCoin> cryptoCoins)
        {
            CryptoCoins = cryptoCoins;
        }   
    }
}
