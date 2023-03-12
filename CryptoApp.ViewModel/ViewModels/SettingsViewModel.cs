using CryptoApp.Services.Services;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Windows.Input;
using Windows.UI.Xaml;

namespace CryptoApp.ViewModel.ViewModels
{
    public class SettingsViewModel:ObservableObject
    {
        private ElementTheme _elementTheme = ThemeSelectorService.Theme;
        private ICommand _switchThemeCommand;

        public SettingsViewModel()
        {
        }

        public ElementTheme ElementTheme
        {
            get => _elementTheme;

            set { SetProperty(ref _elementTheme, value); }
        }

        public ICommand SwitchThemeCommand
        {
            get
            {
                if (_switchThemeCommand == null)
                {
                    _switchThemeCommand = new RelayCommand<ElementTheme>(
                        async (param) =>
                        {
                            ElementTheme = param;
                            await ThemeSelectorService.SetThemeAsync(param);
                        });
                }

                return _switchThemeCommand;
            }
        }
    }
}
