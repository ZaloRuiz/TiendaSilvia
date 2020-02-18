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
        private decimal TotalEnero = 0;
        private decimal TotalFebrero = 0;
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

            int valDiaEnero = 0;
            int valDiaFebrero = 0;
            int valDiaMarzo = 0;
            int valDiaAbril = 0;
            int valDiaMayo = 0;
            int valDiaJunio = 0;
            int valDiaJulio = 0;
            int valDiaAgosto = 0;
            int valDiaSeptiembre = 0;
            int valDiaOctubre = 0;
            int valDiaNoviembre = 0;
            int valDiaDiciembre = 0;

            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://dmrbolivia.online/api_tienda_silvia/VentaRapida/listaVentaRapida.php");
            var dataVR = JsonConvert.DeserializeObject<List<venta_rapida>>(response);
            //Mes de Enero
            for(int iEne = 0; iEne <= 31; iEne++, valDiaEnero++)
            {
                foreach (var item in dataVR)
                {
                    if(item.fecha.Date == fechaMesEnero.AddDays(valDiaEnero))
                    {
                        EneroArr[iEne] = EneroArr[iEne] + item.monto;
                        TotalEnero = TotalEnero + item.monto;
                    }
                }
            }
            txtEne1.Text = EneroArr[0].ToString();
            txtEne2.Text = EneroArr[1].ToString();
            txtEne3.Text = EneroArr[2].ToString();
            txtEne4.Text = EneroArr[3].ToString();
            txtEne5.Text = EneroArr[4].ToString();
            txtEne6.Text = EneroArr[5].ToString();
            txtEne7.Text = EneroArr[6].ToString();
            txtEne8.Text = EneroArr[7].ToString();
            txtEne9.Text = EneroArr[8].ToString();
            txtEne10.Text = EneroArr[9].ToString();
            txtEne11.Text = EneroArr[10].ToString();
            txtEne12.Text = EneroArr[11].ToString();
            txtEne13.Text = EneroArr[12].ToString();
            txtEne14.Text = EneroArr[13].ToString();
            txtEne15.Text = EneroArr[14].ToString();
            txtEne16.Text = EneroArr[15].ToString();
            txtEne17.Text = EneroArr[16].ToString();
            txtEne18.Text = EneroArr[17].ToString();
            txtEne19.Text = EneroArr[18].ToString();
            txtEne20.Text = EneroArr[19].ToString();
            txtEne21.Text = EneroArr[20].ToString();
            txtEne22.Text = EneroArr[21].ToString();
            txtEne23.Text = EneroArr[22].ToString();
            txtEne24.Text = EneroArr[23].ToString();
            txtEne25.Text = EneroArr[24].ToString();
            txtEne26.Text = EneroArr[25].ToString();
            txtEne27.Text = EneroArr[26].ToString();
            txtEne28.Text = EneroArr[27].ToString();
            txtEne29.Text = EneroArr[28].ToString();
            txtEne30.Text = EneroArr[29].ToString();
            txtEne31.Text = EneroArr[30].ToString();
            txtTotalEnero.Text = TotalEnero.ToString() + " BS.";
            //Mes de Febrero
            for (int iFeb = 0; iFeb <= 29; iFeb++, valDiaFebrero++)
            {
                foreach (var item in dataVR)
                {
                    if (item.fecha.Date == fechaMesFebrero.AddDays(valDiaFebrero))
                    {
                        FebreroArr[iFeb] = FebreroArr[iFeb] + item.monto;
                        TotalFebrero = TotalFebrero + item.monto;
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
            txtTotalFebrero.Text = TotalFebrero.ToString()+" BS.";
        }
    }
}