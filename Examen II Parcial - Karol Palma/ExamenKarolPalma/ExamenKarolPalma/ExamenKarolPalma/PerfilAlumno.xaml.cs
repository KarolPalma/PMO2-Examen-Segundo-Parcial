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
    public partial class PerfilAlumno : ContentPage
    {
        public PerfilAlumno()
        {
            InitializeComponent();
            traerUnAlumno("");
        }

        async private void btnGenerarAlumno_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RNEAlumno.Text))
            {
                await DisplayAlert("Mensaje de Error", "Por favor ingrese el RNE de algún alumno", "Aceptar");
            }
            else
            {
                traerUnAlumno(RNEAlumno.Text);
            }
        }

        private async void traerUnAlumno(string RNE)
        {
            try
            {
                AlumnoHelper manager = new AlumnoHelper();
                var res = await manager.traerUnAlumno(RNE);
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