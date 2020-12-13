using CalculadoraDixAgro_App.Model;
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
    public partial class PiladoView : ContentPage
    {
        public ArrozPilado ArrozPilado;

        public PiladoView()
        {
            InitializeComponent();

            ArrozPilado = new ArrozPilado();
            Button_VerXKilos.IsEnabled = false;
        }

        //Calcular Button
        private void Button_Clicked(object sender, EventArgs e)
        {
            bool isParseCorrect = true;
            try
            {
                ArrozPilado.CMP = decimal.Parse(CMP.Text);
                ArrozPilado.Flete = decimal.Parse(Flete.Text);
                ArrozPilado.Maquila = decimal.Parse(Maquila.Text);
                ArrozPilado.Envases = decimal.Parse(Envases.Text);
                ArrozPilado.Otros = decimal.Parse(Otros.Text);
                ArrozPilado.Descarte = decimal.Parse(Descarte.Text);
                ArrozPilado.Arrocillo = decimal.Parse(Arrocillo.Text);
                ArrozPilado.Polvillo = decimal.Parse(Polvillo.Text);
                ArrozPilado.PAP = decimal.Parse(PAP.Text);
            }
            catch(Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Ha ocurrido un error", "Por favor comprobar que la informacion ingresada sea correcta","Ok");
                isParseCorrect = false;
            }

            if (isParseCorrect)
            {
                try
                {
                    var CAP = ArrozPilado.CAP;

                    Label_CAP.Text = CAP.ToString("N2");

                    Application.Current.MainPage.DisplayAlert("Resultado", $"El Costo de arroz pilado es {CAP}", "Ok");
                    Button_VerXKilos.IsEnabled = true;
                }
                catch (Exception ex)
                {
                    Application.Current.MainPage.DisplayAlert("Error", ex.Message, "ok");
                }
            }

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainView();
        }

        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            var Entry = sender as Entry;

            var Text = Entry.Text;

            if (decimal.Parse(Text) == 0)
            {
                Entry.Text = "";
            }
        }

        private void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            var Entry = sender as Entry;

            var Text = Entry.Text;

            if (Text == "")
            {
                Entry.Text = "0";
            }
        }

        private void Button_VerXKilos_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(XKilos.Text))
            {
                var Kilos = decimal.Parse(XKilos.Text);

                Label_ResultadoXKilos.Text = (Kilos * ArrozPilado.CAP).ToString("N2");
            }
        }
    }
}