using CryptoApp.Services.Services;
using System.Threading.Tasks;
using Windows.Storage;

namespace CryptoApp.Extentions.Extensions
{
    public static class SettingsExtension
    {
        public static async Task<T> ReadAsync<T>(this ApplicationDataContainer settings, string key)
        {
            object obj = null;

            if (settings.Values.TryGetValue(key, out obj))
            {
               return await JsonService.ToObjectAsync<T>((string)obj);
            }

            return default;
        }
    }
}
