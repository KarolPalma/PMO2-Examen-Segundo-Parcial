using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenKarolPalma
{
    public partial class App : Application
    {
        public static string ruta;
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
            //ruta = "https://uthprograweb2.000webhostapp.com/webservice/";
            //ruta = "http://192.168.0.15:81/PMO2/3.%20WebService/";
            ruta = "https://karolpalmaexamen2.000webhostapp.com/";
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
