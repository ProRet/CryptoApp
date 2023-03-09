using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.ViewModel.Extensions
{
    public static class ObservableCollectionExtensions
    {
        public static void AddRange<T>(this ObservableCollection<T> collection, IEnumerable<T> itemsToAdd)
        {
            if (collection != null && itemsToAdd != null)
            {
                foreach (var item in itemsToAdd)
                {
                    collection.Add(item);
                }
            }
        }
    }
}
