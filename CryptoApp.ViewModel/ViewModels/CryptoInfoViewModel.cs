

using CryptoApp.Models.Models;
using System.Collections.ObjectModel;

namespace CryptoApp.ViewModel.ViewModels
{
    public class CryptoInfoViewModel
    {
        public ObservableCollection<DetailedCryptoInfo> detailedCryptoInfos { get; }
        
    }
}
