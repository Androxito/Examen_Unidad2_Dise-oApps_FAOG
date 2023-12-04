using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen_Unidad2_DiseñoApps_FAOG
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           
            string resultado = "";
            try
            {
                double duracion = int.Parse(Duracion.Text);
                double peso = int.Parse(Peso.Text);

                double caloriasquemadas = duracion * 10*(peso/200);




                if (caloriasquemadas < 250)
                {
                    bajo.IsVisible = true;
                    medio.IsVisible = false;
                }
                else if(caloriasquemadas >= 250 && caloriasquemadas <= 499)
                {
                    medio.IsVisible = true;
                    alto.IsVisible = false;
                }

            else
                {
                    alto.IsVisible = true;
                }

                resultado = $"Total de calorias perdidas: {caloriasquemadas}";


            }
            finally
            {
                //Esta vacio por que no quiero ponerle nada :)   
            }
            DisplayAlert("Resultado", resultado, "Ok");


        }
    }
}
