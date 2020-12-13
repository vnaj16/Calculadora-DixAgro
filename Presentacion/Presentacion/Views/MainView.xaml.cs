using CalculadoraDixAgro_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraDixAgro_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        private MainViewModel mainViewModel;

        public MainView()
        {
            InitializeComponent();

            mainViewModel = new MainViewModel();
            this.BindingContext = mainViewModel;
        }
    }
}