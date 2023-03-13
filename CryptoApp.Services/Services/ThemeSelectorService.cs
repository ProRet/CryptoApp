using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Xaml;

namespace CryptoApp.Services.Services
{
    public static class ThemeSelectorService
    {
        private const string SettingsKey = "AppBackgroundRequestedTheme";

        public static ElementTheme Theme { get; set; } = ElementTheme.Default;

        public static async Task SetThemeAsync(ElementTheme theme)
        {
            Theme = theme;

            await SetRequestedThemeAsync();
        }

        public static async Task SetRequestedThemeAsync()
        {
            foreach (var view in CoreApplication.Views)
            {
                await view.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    if (Window.Current.Content is FrameworkElement frameworkElement)
                    {
                        frameworkElement.RequestedTheme = Theme;
                    }
                });
            }
        }

     
    }
}
