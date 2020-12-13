using CalculadoraDixAgro_App.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Presentacion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Button_Entrar_Clicked(object sender, EventArgs e)
        {
            try
            {
                int PIN = int.Parse(Entry_PIN.Text);

                if(PIN == 2958)
                {
                    Application.Current.MainPage = new MainView();
                }
                else
                {
                    Application.Current.MainPage.DisplayAlert("Acceso Denegado", "El PIN ingresado no es correcto", "Ok");
                }

            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }

        }
    }
}