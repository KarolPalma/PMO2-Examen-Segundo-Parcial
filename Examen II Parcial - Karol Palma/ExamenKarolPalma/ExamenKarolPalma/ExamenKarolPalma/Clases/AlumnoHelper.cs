using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExamenKarolPalma.Clases
{
    class AlumnoHelper
    {
        private HttpClient getCliente()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");
            return client;
        }
        public async Task<IEnumerable<Alumno>> getAlumno()
        {
            HttpClient client = getCliente();
            var res = await client.GetAsync(App.ruta + "verEmpleados.php");
            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Alumno>>(content);
            }
            return Enumerable.Empty<Alumno>();
        }
        public async Task<IEnumerable<Alumno>> traerUnAlumno(string RNE)
        {
            if (RNE != "")
            {
                HttpClient client = getCliente();
                var res = await client.GetAsync(App.ruta + "verAlumno.php?rneAlumno=" + RNE);
                if (res.IsSuccessStatusCode)
                {
                    string content = await res.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<Alumno>>(content);
                }
            }
            return Enumerable.Empty<Alumno>();
        }

        public async Task<IEnumerable<Alumno>> traerListaAlumno(string anio)
        {
            if (anio != "")
            {
                HttpClient client = getCliente();
                var res = await client.GetAsync(App.ruta + "listaAlumno.php?aniolAnio=" + anio);
                if (res.IsSuccessStatusCode)
                {
                    string content = await res.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<Alumno>>(content);
                }
            }
            return Enumerable.Empty<Alumno>();
        }
    }
}
