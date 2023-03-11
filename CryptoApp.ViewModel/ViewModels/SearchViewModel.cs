using CryptoApp.Extentions.Extensions;
using CryptoApp.Models.Models;
using System.Collections.ObjectModel;

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
