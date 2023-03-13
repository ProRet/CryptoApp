using CryptoApp.Extentions.Extensions;
using CryptoApp.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace CryptoApp.ViewModel.ViewModels
{
    public class SearchViewModel : ObservableObject
    {
        public ObservableCollection<CryptoCoin> CryptoCoins { get; }=new ObservableCollection<CryptoCoin>();

        private string name;

        private ObservableCollection<CryptoCoin> foundCoins ;

        public SearchViewModel()
        {
            CryptoCoins.FillCryptoCoins();
            foundCoins = new ObservableCollection<CryptoCoin>();
        }

        public ObservableCollection<CryptoCoin> FoundCoins
        {
            get => foundCoins;
            set
            {
                foundCoins = value;
            }
        }

        public string Name
        {
            get=> name;
            set
            {
                FoundCoins.Clear();
                name = value;
                FoundCoins.SearchCoins(Name, CryptoCoins);
            }
        }
    }
}
