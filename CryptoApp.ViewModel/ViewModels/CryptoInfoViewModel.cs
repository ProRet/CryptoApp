using CryptoApp.Extentions.Extensions;
using CryptoApp.Models.Models;
using System.Collections.ObjectModel;

namespace CryptoApp.ViewModel.ViewModels
{
    public class CryptoInfoViewModel
    {
        public ObservableCollection<DetailedCryptoInfo> DetailedCryptoInfos { get; } = new ObservableCollection<DetailedCryptoInfo>();

        public CryptoInfoViewModel()
        {
            DetailedCryptoInfos.FillDetailedInfo(20);
        }
        
    }
}
