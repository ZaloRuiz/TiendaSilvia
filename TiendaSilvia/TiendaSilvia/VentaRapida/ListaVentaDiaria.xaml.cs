﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public string fechaActual;
        public DateTime fechaHoy = DateTime.Today;
        private decimal TotalDiario = 0;

        ObservableCollection<venta_rapida> ventas_rapidas = new ObservableCollection<venta_rapida>();
        public ObservableCollection<venta_rapida> VentaRapida { get { return ventas_rapidas; } }

        public ListaVentaDiaria ()
		{
			InitializeComponent ();
            fechaActual = DateTime.Today.ToString("dd/MM/yyy");
            txtFecha.Text = fechaActual;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            HttpClient client = new HttpClient();
            var url_tienda = new Uri("http://dmrbolivia.online/api_tienda_silvia/VentaRapida/listaVentaRapida.php");
            string result = await client.GetStringAsync(url_tienda);
            var data = JsonConvert.DeserializeObject<List<venta_rapida>>(result);

            foreach(var item in data)
            {
                if(item.fecha == fechaHoy)
                {
                    ventas_rapidas.Add(new venta_rapida
                    {
                        fecha = item.fecha,
                        descripcion = item.descripcion,
                        cantidad = item.cantidad,
                        monto = item.monto
                    });
                }
            }

            listVentaRapida.ItemsSource = ventas_rapidas.Distinct();
            ObtenerTotal();
        }

        public async void ObtenerTotal()
        {
            try
            {
                HttpClient client = new HttpClient();
                var response = await client.GetStringAsync("http://dmrbolivia.online/api_tienda_silvia/VentaRapida/listaVentaRapida.php");
                var product = JsonConvert.DeserializeObject<List<venta_rapida>>(response);
                foreach (var item in product)
                {
                    if(item.fecha == fechaHoy)
                    {
                        TotalDiario = TotalDiario + item.monto;
                    }
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