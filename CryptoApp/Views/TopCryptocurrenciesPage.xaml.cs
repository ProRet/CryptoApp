using CryptoApp.ViewModel.ViewModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.UI.Xaml.Controls;


// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace CryptoApp.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class TopCryptocurrenciesPage : Page
    {
        readonly TopCryptocurrenciesViewModel viewModel = new TopCryptocurrenciesViewModel();
        public TopCryptocurrenciesPage()
        {
            InitializeComponent();
            
        }
    }
}
