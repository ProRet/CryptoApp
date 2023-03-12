using CryptoApp.ViewModel.ViewModels;
using Windows.UI.Xaml.Controls;


// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace CryptoApp.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class CryptoInfoPage : Page
    {
        readonly CryptoInfoViewModel viewModel = new CryptoInfoViewModel();
        public CryptoInfoPage()
        {
            InitializeComponent();
        }
    }
}
