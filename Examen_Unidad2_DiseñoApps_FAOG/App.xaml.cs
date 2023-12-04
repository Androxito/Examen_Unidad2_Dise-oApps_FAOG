using Examen_Unidad2_DiseñoApps_FAOG.BaseViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen_Unidad2_DiseñoApps_FAOG
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            BindingContext = new CaloriasViewModel();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
