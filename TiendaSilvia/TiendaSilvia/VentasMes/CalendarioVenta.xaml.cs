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

namespace TiendaSilvia.VentasMes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarioVenta : TabbedPage
    {
        private DateTime Hoy = DateTime.Today;
        private int DiaToday = 0;
        //private DateTime DiasFebrero = DateTime.Today();
        public decimal unofeb = 0;
        public decimal dosfeb = 0;
        public decimal tresfeb = 0;
        public decimal cuantrofeb = 0;
        public decimal cincofeb = 0;
        public decimal seisfeb = 0;
        public decimal sietefeb = 0;
        public decimal ochofeb = 0;
        public decimal nuevefeb = 0;
        public decimal diezfeb = 0;
        
        public CalendarioVenta()
        {
            InitializeComponent();
            //txtFeb1.Text = Hoy.ToString("MM/dd/yyyy");
            GetData();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "AllowLandscape");
        }

        private decimal[] EneroArr = new decimal[500];
        private decimal[] FebreroArr = new decimal[500];
        private decimal[] MarzoArr = new decimal[500];
        private decimal[] AbrilArr = new decimal[500];
        private decimal[] MayoArr = new decimal[500];
        private decimal[] JunioArr = new decimal[500];
        private decimal[] JulioArr = new decimal[500];
        private decimal[] AgostoArr = new decimal[500];
        private decimal[] SeptiembreArr = new decimal[500];
        private decimal[] OctubreArr = new decimal[500];
        private decimal[] NoviembreArr = new decimal[500];
        private decimal[] DiciembreArr = new decimal[500];

        public async void GetData()
        {
            DateTime fechaMesEnero = new DateTime(2020, 1, 1);
            DateTime fechaMesFebrero = new DateTime(2020, 2, 1);
            DateTime fechaMesMarzo = new DateTime(2020, 3, 1);
            DateTime fechaMesAbril = new DateTime(2020, 4, 1);
            DateTime fechaMesMayo = new DateTime(2020, 5, 1);
            DateTime fechaMesJunio = new DateTime(2020, 6, 1);
            DateTime fechaMesJulio = new DateTime(2020, 7, 1);
            DateTime fechaMesAgosto = new DateTime(2020, 8, 1);
            DateTime fechaMesSeptiembre = new DateTime(2020, 9, 1);
            DateTime fechaMesOctubre = new DateTime(2020, 10, 1);
            DateTime fechaMesNoviembre = new DateTime(2020, 11, 1);
            DateTime fechaMesDiciembre = new DateTime(2020, 12, 1);

            int valDia = 0;
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://dmrbolivia.online/api_tienda_silvia/VentaRapida/listaVentaRapida.php");
            var dataVR = JsonConvert.DeserializeObject<List<venta_rapida>>(response);

            //Mes de Febrero
            for(int i = 0; i <= 29; i++, valDia++)
            {
                foreach (var item in dataVR)
                {
                    if (item.fecha.Date == fechaMesFebrero.AddDays(valDia))
                    {
                        FebreroArr[i] = FebreroArr[i] + item.monto;
                    }
                    else
                    {
                        
                    }
                }
            }
            txtFeb1.Text = FebreroArr[0].ToString();
            txtFeb2.Text = FebreroArr[1].ToString();
            txtFeb3.Text = FebreroArr[2].ToString();
            txtFeb4.Text = FebreroArr[3].ToString();
            txtFeb5.Text = FebreroArr[4].ToString();
            txtFeb6.Text = FebreroArr[5].ToString();
            txtFeb7.Text = FebreroArr[6].ToString();
            txtFeb8.Text = FebreroArr[7].ToString();
            txtFeb9.Text = FebreroArr[8].ToString();
            txtFeb10.Text = FebreroArr[9].ToString();
            txtFeb11.Text = FebreroArr[10].ToString();
            txtFeb12.Text = FebreroArr[11].ToString();
            txtFeb13.Text = FebreroArr[12].ToString();
            txtFeb14.Text = FebreroArr[13].ToString();
            txtFeb15.Text = FebreroArr[14].ToString();
            txtFeb16.Text = FebreroArr[15].ToString();
            txtFeb17.Text = FebreroArr[16].ToString();
            txtFeb18.Text = FebreroArr[17].ToString();
            txtFeb19.Text = FebreroArr[18].ToString();
            txtFeb20.Text = FebreroArr[19].ToString();
            txtFeb21.Text = FebreroArr[20].ToString();
            txtFeb22.Text = FebreroArr[21].ToString();
            txtFeb23.Text = FebreroArr[22].ToString();
            txtFeb24.Text = FebreroArr[23].ToString();
            txtFeb25.Text = FebreroArr[24].ToString();
            txtFeb26.Text = FebreroArr[25].ToString();
            txtFeb27.Text = FebreroArr[26].ToString();
            txtFeb28.Text = FebreroArr[27].ToString();
            txtFeb29.Text = FebreroArr[28].ToString();
        }

        public async void GetDataCalendario()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://dmrbolivia.online/api_tienda_silvia/VentaRapida/listaVentaRapida.php");
            var dataVR = JsonConvert.DeserializeObject<List<venta_rapida>>(response);


        }
    }
}