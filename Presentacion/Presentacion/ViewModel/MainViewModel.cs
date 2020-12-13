using CalculadoraDixAgro_App.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CalculadoraDixAgro_App.ViewModel
{
    #region NOTAS

    #endregion

    public class MainViewModel
    {
        public string TextSaludo
        {
            get
            {
                string message;
                int hour = DateTime.Now.Hour;

                if (hour >= 5 && hour <= 11)
                {
                    message = "Buenos dias, ";
                }
                else if (hour >= 12 && hour <= 18)
                {
                    message = "Buenas tardes, ";
                }
                else
                {
                    message = "Buenas noches, ";
                }

                return message + "seleccione la calculadora a usar";
            }
        }

        public ICommand GoPiladoViewCommand
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new PiladoView();
                });
            }
        }

        public ICommand GoCascaraViewCommand
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new CascaraView();
                });
            }
        }
    }
}
