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
    public partial class CascaraView : ContentPage
    {
        public ArrozCascara ArrozCascara;
        public CascaraView()
        {
            InitializeComponent();

            ArrozCascara = new ArrozCascara();
            Button_VerXKilos.IsEnabled = false;
        }

        //Calcular Button
        private void Button_Clicked(object sender, EventArgs e)
        {
            bool isParseCorrect = true;
            try
            {
                ArrozCascara.PMP = decimal.Parse(PMP.Text);
                ArrozCascara.Flete = decimal.Parse(Flete.Text);
                ArrozCascara.Rkg = decimal.Parse(Rkg.Text);
                ArrozCascara.Subproducto = decimal.Parse(Subproducto.Text);
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Ha ocurrido un error", "Por favor comprobar que la informacion ingresada sea correcta", "Ok");
                isParseCorrect = false;
            }

            if (isParseCorrect)
            {
                try
                {
                    var CAC = ArrozCascara.CAC;

                    Label_CAC.Text = CAC.ToString("N2");

                    Application.Current.MainPage.DisplayAlert("Resultado", $"El Costo de arroz pilado por kilo es S/. {CAC.ToString("N2")}", "Ok");
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

            if(decimal.Parse(Text) == 0)
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

                Label_ResultadoXKilos.Text = (Kilos * ArrozCascara.CAC).ToString("N2");
                UpdateCostoByChangeType(sender, e);
            }
        }

        private void UpdateCostoByChangeType(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(XKilos.Text) && !String.IsNullOrWhiteSpace(TC_Dolar.Text))
            {
                var TipoCambio_Dolar = decimal.Parse(TC_Dolar.Text);
                var Kilos = decimal.Parse(XKilos.Text);

                if (TipoCambio_Dolar == 0)
                {
                    Label_ResultadoCostoTotalDolar.Text = "0";
                }
                else
                {
                    Label_ResultadoCostoTotalDolar.Text = ((Kilos * ArrozCascara.CAC) / TipoCambio_Dolar).ToString("N2");
                }
            }
        }
    }
}