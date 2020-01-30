using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiendaSilvia.VentaRapida
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IndexVentaRapida : ContentPage
	{
		public IndexVentaRapida ()
		{
			InitializeComponent ();
		}
        private void Button_Clicked(object sender, EventArgs e)
        {
            //agregar venta rapida
            Navigation.PushAsync(new AgregarVentaRapida());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            //venta rapida diaria
            Navigation.PushAsync(new ListaVentaDiaria());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            //venta mensual
        }
    }
}