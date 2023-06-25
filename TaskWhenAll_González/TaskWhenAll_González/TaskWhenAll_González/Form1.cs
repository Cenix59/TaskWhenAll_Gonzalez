using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concurrencias._3
{
    public partial class Form1 : Form
    {
        private string apiURL;
        private HttpClient httpClient;
        public Form1()
        {
            InitializeComponent();
            apiURL = "https://localhost:7284";
            httpClient = new HttpClient();
        }

        private async void BtnCharge_Click(object sender, EventArgs e)
        {
            LoadingGIF.Visible = true;
            var tarjetas = Obtenertarjetasdecredito(5);
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            
            try
            {
                await Procesartarjetas(tarjetas);
            }
            catch(HttpRequestException ex)
            { 
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show($"Operación finalizada en {stopwatch.ElapsedMilliseconds / 1000.0} segundos");
            LoadingGIF.Visible = false;
        }

        private List<string> Obtenertarjetasdecredito(int cantidadDeTarjetas)
        {
            var tarjetas = new List<string>();

            for (int x = 0; x < cantidadDeTarjetas; x++)
            {
                tarjetas.Add( x.ToString().PadLeft(16, '0'));

            }
            return tarjetas;
        }

        private async Task Procesartarjetas(List<string> tarjetas)
        {
            var tareas = new List<Task>();

            foreach(var tarjeta in tarjetas )
            {
                var json = JsonConvert.SerializeObject(tarjeta);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var respuestaTask = httpClient.PostAsync($"{apiURL}/tarjetas", content);
                tareas.Add(respuestaTask);
            }
            await Task.WhenAll(tareas);

        }



        private async Task esperar()
        {
            await Task.Delay(5000);
        }
        private async Task<String> ObtenerSaludo(string nombre)
        {
            using (var respuesta = await httpClient.GetAsync($"{apiURL}/saludos/{nombre}"))
            {
                var saludo = await respuesta.Content.ReadAsStringAsync();
                return saludo;
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
