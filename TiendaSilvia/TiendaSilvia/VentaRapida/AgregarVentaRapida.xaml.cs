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
	public partial class AgregarVentaRapida : ContentPage
	{
		public AgregarVentaRapida ()
		{
			InitializeComponent ();
		}

        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {

        }
    }
}