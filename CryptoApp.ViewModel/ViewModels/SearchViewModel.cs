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

        public ObservableCollection<CryptoCoin> cryptoCoin { get; }= new ObservableCollection<CryptoCoin>();

        private string name;

        private ObservableCollection<CryptoCoin> foundCoin;

        public SearchViewModel()
        {
            CryptoCoins.FillCryptoCoins();
        }


        public ObservableCollection<CryptoCoin> FoundCoins
        {
            get => foundCoin;
            set
            {
                foundCoin = value;
                OnPropertyChanged(nameof(FoundCoins));
            }
        }

        public string Name
        {
            get=> name;
            set
            {
                FoundCoins.Clear();
                name = value;

            }
        }
    }
}
