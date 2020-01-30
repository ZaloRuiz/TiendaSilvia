using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TiendaSilvia.Datos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiendaSilvia.VentaRapida
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaVentaDiaria : ContentPage
	{
        private decimal TotalDiario = 0;
		public ListaVentaDiaria ()
		{
			InitializeComponent ();
            string fechaActual = DateTime.Today.ToString("dd/MM/yyy");
            txtFecha.Text = fechaActual;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            HttpClient client = new HttpClient();
            var url_tienda = new Uri("http://dmrbolivia.online/api_tienda_silvia/listaVentaRapida.php");
            string result = await client.GetStringAsync(url_tienda);
            var data = JsonConvert.DeserializeObject<List<venta_rapida>>(result);
            listVentaRapida.ItemsSource = data;
            ObtenerTotal();
        }

        public async void ObtenerTotal()
        {
            try
            {
                HttpClient client = new HttpClient();
                var response = await client.GetStringAsync("http://dmrbolivia.online/api_tienda_silvia/listaVentaRapida.php");
                var product = JsonConvert.DeserializeObject<List<venta_rapida>>(response);

                foreach (var item in product.Distinct())
                {
                    TotalDiario = TotalDiario + item.monto;
                }
                txtTotal.Text = TotalDiario.ToString();
            }

            catch (Exception erro)
            {
                await DisplayAlert("ERROR", erro.ToString(), "OK");
            }
        }

    }
}