using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExamenKarolPalma.Clases;

namespace ExamenKarolPalma
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListadoAlumno : ContentPage
    {
        public ListadoAlumno()
        {
            InitializeComponent();
        }

        async private void btnGenerarLista_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(anioElectivo.Text))
            {
                await DisplayAlert("Mensaje de Error", "Por favor ingrese un año electivo", "Aceptar");
            } else if (anioElectivo.Text == "2015" || anioElectivo.Text == "2016" || anioElectivo.Text == "2017") { 
                traerListaAlumno(anioElectivo.Text);
            }
            else
            {
                await DisplayAlert("Mensaje de Error", "Por favor ingrese un año electivo correspondido (2015, 2016, 2017)", "Aceptar");
            }
        }

        private async void traerListaAlumno(string anio)
        {
            try
            {
                AlumnoHelper manager = new AlumnoHelper();
                var res = await manager.traerListaAlumno(anio);
                if (res != null)
                {
                    lstInfoAlumno.ItemsSource = res;
                }
            }
            catch (Exception e)
            {
                await DisplayAlert("Mensaje de Error", "Error al traer un alumno", "Aceptar");
            }
        }
    }
}