using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExamenKarolPalma
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void btnPerfilAlumno_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PerfilAlumno());
        }

        async private void btnListadoAlummo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListadoAlumno());
        }
    }
}
