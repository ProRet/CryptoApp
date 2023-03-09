using CryptoApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.ViewModel.ViewModels
{
    public class TopCryptocurrenciesModel
    {
        public ObservableCollection<CryptoCoin> CryptoCoins { get; set; }
        public TopCryptocurrenciesModel()
        {
            CryptoCoins = new ObservableCollection<CryptoCoin>();
        }
        public TopCryptocurrenciesModel(ObservableCollection<CryptoCoin> cryptoCoins)
        {
            CryptoCoins = cryptoCoins;
        }   
    }
}
