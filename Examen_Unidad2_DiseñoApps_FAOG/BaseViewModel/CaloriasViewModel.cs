using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Examen_Unidad2_DiseñoApps_FAOG.BaseViewModel
{
    public class CaloriasViewModel:BaseViewModel
    {
        #region VARIABLES
         int _duracion;
         double _peso;
         double _caloriasQuemadas;
         string _imagen;

        #endregion
        public int Duracion
        {
            get { return _duracion; }
            set { SetProperty(ref _duracion, value); }
        }

        public double Peso
        {
            get { return  _peso; }
            set { SetProperty(ref _peso, value); }
        }

        public double CaloriasQuemadas
        {
            get { return _caloriasQuemadas; }
            set { SetProperty(ref _caloriasQuemadas, value); }
        }

     //   public ICommand CalcularCaloriasCommand => new Command();

        //public void CalcularCalorias()
        //{

        //    CaloriasQuemadas = Duracion * 0.1 * (Peso / 200);


        //    if (CaloriasQuemadas < 250)
        //    {
        //        _imagen = "bajo.png";
        //    }
        //    else if (CaloriasQuemadas >= 250 && CaloriasQuemadas <= 499)
        //    {
        //        _imagen = "motivation.png";
        //    }
        //    else
        //    {
        //        _imagen = "rendimiento.png";
        //    }
        //}


        public string Imagen
        {
            get { return _imagen; }
            set { SetProperty(ref _imagen, value); }
        }
    }
}
