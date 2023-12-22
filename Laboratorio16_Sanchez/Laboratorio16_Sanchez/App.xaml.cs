using Laboratorio16_Sanchez.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio16_Sanchez
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ComidaPage();
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
