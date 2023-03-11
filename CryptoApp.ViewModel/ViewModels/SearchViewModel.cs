using CryptoApp.Extentions.Extensions;
using CryptoApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.ViewModel.ViewModels
{
    public class SearchViewModel
    {
        public ObservableCollection<CryptoMarket> cryptoMarket { get; }=new ObservableCollection<CryptoMarket>();

        public SearchViewModel(string coin)
        {
            cryptoMarket.FillCryptoMarkets(coin);
        }
    }
}
