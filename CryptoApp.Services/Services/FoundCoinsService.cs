using CryptoApp.Models;
using System.Collections.ObjectModel;
using System.Linq;


namespace CryptoApp.Services.Services
{
    public static class FoundCoinsService
    {
        public static void SearchCoins(ObservableCollection<CryptoCoin> FoundCoins, string Name, ObservableCollection<CryptoCoin> CryptoCoins)
        {
            if (Name != "")
            {
                var _CryptoCoins = CryptoCoins.Where(x => x.Name.ToLower().Contains(Name.ToLower()));
                foreach (var item in _CryptoCoins)
                {
                    if (item != null)
                    {
                        FoundCoins.Add(item);
                    }
                }
            }
        }

    }
}
