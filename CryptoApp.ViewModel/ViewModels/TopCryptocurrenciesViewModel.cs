using CryptoApp.Models;
using CryptoApp.Services;
using CryptoApp.ViewModel.Extensions;
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
        public ObservableCollection<CryptoCoin> CryptoCoins { get; } = new ObservableCollection<CryptoCoin>();
    }
}
