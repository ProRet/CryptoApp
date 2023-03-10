using CryptoApp.Models.Models;
using CryptoApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.Extentions.Extensions
{
    public static class DetailedCryptoInfoExtesion
    {
        public static async void FillDetailedInfo(this ObservableCollection<DetailedCryptoInfo> DetailedCryptoInfos,int limit=230)
        {
           var _DetailedCryptoInfos= await CoinCapService.Instance.GetDetailedCryptoInfo(limit);
            DetailedCryptoInfos.AddRange(_DetailedCryptoInfos);
        }
    }
}
