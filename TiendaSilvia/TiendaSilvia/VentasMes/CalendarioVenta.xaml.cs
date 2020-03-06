using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TiendaSilvia.Datos;
using TiendaSilvia.VentaRapida;
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
        private decimal TotalMarzo = 0;
        private decimal TotalAbril = 0;
        private decimal TotalMayo = 0;
        private decimal TotalJunio = 0;
        private decimal TotalJulio = 0;
        private decimal TotalAgosto = 0;
        private decimal TotalSeptiembre = 0;
        private decimal TotalOctubre = 0;
        private decimal TotalNoviembre = 0;
        private decimal TotalDiciembre = 0;       
        
        public CalendarioVenta()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "AllowLandscape");
            GetDataEnero();
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

        public async void GetDataEnero()
        {
            DateTime fechaMesEnero = new DateTime(2020, 1, 1);
            int valDiaEnero = 0;
            
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

            GetDataFebrero();
        }
        public async void GetDataFebrero()
        {
            DateTime fechaMesFebrero = new DateTime(2020, 2, 1);
            int valDiaFebrero = 0;
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://dmrbolivia.online/api_tienda_silvia/VentaRapida/listaVentaRapida.php");
            var dataVR = JsonConvert.DeserializeObject<List<venta_rapida>>(response);
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
            txtTotalFebrero.Text = TotalFebrero.ToString() + " BS.";

            GetDataMarzo();
        }
        public async void GetDataMarzo()
        {
            DateTime fechaMesMarzo = new DateTime(2020, 3, 1);
            int valDiaMarzo = 0;

            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://dmrbolivia.online/api_tienda_silvia/VentaRapida/listaVentaRapida.php");
            var dataVR = JsonConvert.DeserializeObject<List<venta_rapida>>(response);

            //Mes Marzo
            for (int iMarz = 0; iMarz <= 31; iMarz++, valDiaMarzo++)
            {
                foreach (var item in dataVR)
                {
                    if (item.fecha.Date == fechaMesMarzo.AddDays(valDiaMarzo))
                    {
                        MarzoArr[iMarz] = MarzoArr[iMarz] + item.monto;
                        TotalMarzo = TotalMarzo + item.monto;
                    }
                    else
                    {

                    }
                }
            }
            txtmar1.Text = MarzoArr[0].ToString();
            txtmar2.Text = MarzoArr[1].ToString();
            txtmar3.Text = MarzoArr[2].ToString();
            txtmar4.Text = MarzoArr[3].ToString();
            txtmar5.Text = MarzoArr[4].ToString();
            txtmar6.Text = MarzoArr[5].ToString();
            txtmar7.Text = MarzoArr[6].ToString();
            txtmar8.Text = MarzoArr[7].ToString();
            txtmar9.Text = MarzoArr[8].ToString();
            txtmar10.Text = MarzoArr[9].ToString();
            txtmar11.Text = MarzoArr[10].ToString();
            txtmar12.Text = MarzoArr[11].ToString();
            txtmar13.Text = MarzoArr[12].ToString();
            txtmar14.Text = MarzoArr[13].ToString();
            txtmar15.Text = MarzoArr[14].ToString();
            txtmar16.Text = MarzoArr[15].ToString();
            txtmar17.Text = MarzoArr[16].ToString();
            txtmar18.Text = MarzoArr[17].ToString();
            txtmar19.Text = MarzoArr[18].ToString();
            txtmar20.Text = MarzoArr[19].ToString();
            txtmar21.Text = MarzoArr[20].ToString();
            txtmar22.Text = MarzoArr[21].ToString();
            txtmar23.Text = MarzoArr[22].ToString();
            txtmar24.Text = MarzoArr[23].ToString();
            txtmar25.Text = MarzoArr[24].ToString();
            txtmar26.Text = MarzoArr[25].ToString();
            txtmar27.Text = MarzoArr[26].ToString();
            txtmar28.Text = MarzoArr[27].ToString();
            txtmar29.Text = MarzoArr[28].ToString();
            txtmar30.Text = MarzoArr[29].ToString();
            txtmar31.Text = MarzoArr[30].ToString();
            txtTotalMarzo.Text = TotalMarzo.ToString() + " BS.";

            GetDataAbril();
        }
        #region
        //public void GetCalendarioAbril()
        //{
        //    StackLayout stkCal = new StackLayout();
        //    stkCal.BackgroundColor = Color.Gray;
        //    stkCal.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //    stkCalendarioAbril.Children.Add(stkCal);

        //    Grid gridCal = new Grid();
        //    gridCal.BackgroundColor = Color.Gray;
        //    gridCal.ColumnSpacing = 1;
        //    gridCal.RowSpacing = 1;
        //    gridCal.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //    gridCal.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //    gridCal.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //    gridCal.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //    gridCal.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //    gridCal.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //    gridCal.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //    gridCal.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //    gridCal.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50) });
        //    stkCal.Children.Add(gridCal);

        //    Label txtLunes = new Label();
        //    txtLunes.Text = "LUN.";
        //    txtLunes.FontSize = 12;
        //    txtLunes.FontAttributes = FontAttributes.Bold;
        //    txtLunes.BackgroundColor = Color.FromHex("#fcdd12");
        //    txtLunes.TextColor = Color.Black;
        //    txtLunes.VerticalTextAlignment = TextAlignment.Center;
        //    txtLunes.HorizontalTextAlignment = TextAlignment.Center;
        //    txtLunes.Margin = 1;
        //    gridCal.Children.Add(txtLunes, 0, 0);

        //    Label txtMartes = new Label();
        //    txtMartes.Text = "MAR.";
        //    txtMartes.FontSize = 12;
        //    txtMartes.FontAttributes = FontAttributes.Bold;
        //    txtMartes.BackgroundColor = Color.FromHex("#fcdd12");
        //    txtMartes.TextColor = Color.Black;
        //    txtMartes.VerticalTextAlignment = TextAlignment.Center;
        //    txtMartes.HorizontalTextAlignment = TextAlignment.Center;
        //    txtMartes.Margin = 1;
        //    gridCal.Children.Add(txtMartes, 1, 0);

        //    Label txtMiercoles = new Label();
        //    txtMiercoles.Text = "MIÉ.";
        //    txtMiercoles.FontSize = 12;
        //    txtMiercoles.FontAttributes = FontAttributes.Bold;
        //    txtMiercoles.BackgroundColor = Color.FromHex("#fcdd12");
        //    txtMiercoles.TextColor = Color.Black;
        //    txtMiercoles.VerticalTextAlignment = TextAlignment.Center;
        //    txtMiercoles.HorizontalTextAlignment = TextAlignment.Center;
        //    txtMiercoles.Margin = 1;
        //    gridCal.Children.Add(txtMiercoles, 2, 0);

        //    Label txtJueves = new Label();
        //    txtJueves.Text = "JUE.";
        //    txtJueves.FontSize = 12;
        //    txtJueves.FontAttributes = FontAttributes.Bold;
        //    txtJueves.BackgroundColor = Color.FromHex("#fcdd12");
        //    txtJueves.TextColor = Color.Black;
        //    txtJueves.VerticalTextAlignment = TextAlignment.Center;
        //    txtJueves.HorizontalTextAlignment = TextAlignment.Center;
        //    txtJueves.Margin = 1;
        //    gridCal.Children.Add(txtJueves, 3, 0);

        //    Label txtViernes = new Label();
        //    txtViernes.Text = "VIE.";
        //    txtViernes.FontSize = 12;
        //    txtViernes.FontAttributes = FontAttributes.Bold;
        //    txtViernes.BackgroundColor = Color.FromHex("#fcdd12");
        //    txtViernes.TextColor = Color.Black;
        //    txtViernes.VerticalTextAlignment = TextAlignment.Center;
        //    txtViernes.HorizontalTextAlignment = TextAlignment.Center;
        //    txtViernes.Margin = 1;
        //    gridCal.Children.Add(txtViernes, 4, 0);

        //    Label txtSabado = new Label();
        //    txtSabado.Text = "SAB.";
        //    txtSabado.FontSize = 12;
        //    txtSabado.FontAttributes = FontAttributes.Bold;
        //    txtSabado.BackgroundColor = Color.FromHex("#fcdd12");
        //    txtSabado.TextColor = Color.Black;
        //    txtSabado.VerticalTextAlignment = TextAlignment.Center;
        //    txtSabado.HorizontalTextAlignment = TextAlignment.Center;
        //    txtSabado.Margin = 1;
        //    gridCal.Children.Add(txtSabado, 5, 0);

        //    Label txtDomingo = new Label();
        //    txtDomingo.Text = "DOM.";
        //    txtDomingo.FontSize = 12;
        //    txtDomingo.FontAttributes = FontAttributes.Bold;
        //    txtDomingo.BackgroundColor = Color.FromHex("#fcdd12");
        //    txtDomingo.TextColor = Color.Black;
        //    txtDomingo.VerticalTextAlignment = TextAlignment.Center;
        //    txtDomingo.HorizontalTextAlignment = TextAlignment.Center;
        //    txtDomingo.Margin = 1;
        //    gridCal.Children.Add(txtDomingo, 6, 0);

        //    Grid gridCal2 = new Grid();
        //    gridCal2.BackgroundColor = Color.Gray;
        //    gridCal2.ColumnSpacing = 1;
        //    gridCal2.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //    gridCal2.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //    gridCal2.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //    gridCal2.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //    gridCal2.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //    gridCal2.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //    gridCal2.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //    gridCal2.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //    gridCal2.RowDefinitions.Add(new RowDefinition { Height = new GridLength(70) });
        //    gridCal2.RowDefinitions.Add(new RowDefinition { Height = new GridLength(70) });
        //    gridCal2.RowDefinitions.Add(new RowDefinition { Height = new GridLength(70) });
        //    gridCal2.RowDefinitions.Add(new RowDefinition { Height = new GridLength(70) });
        //    stkCal.Children.Add(gridCal2);

        //    //1RA SEMANA    
        //    StackLayout stkMesAnt1 = new StackLayout();
        //    stkMesAnt1.BackgroundColor = Color.LightGray;
        //    gridCal2.Children.Add(stkMesAnt1, 0, 0);

        //    Label txtMesAnt30 = new Label();
        //    txtMesAnt30.Text = "30";
        //    txtMesAnt30.TextColor = Color.Black;
        //    txtMesAnt30.FontAttributes = FontAttributes.Bold;
        //    txtMesAnt30.HorizontalOptions = LayoutOptions.Start;
        //    txtMesAnt30.VerticalOptions = LayoutOptions.Start;
        //    txtMesAnt30.HorizontalTextAlignment = TextAlignment.Start;
        //    txtMesAnt30.Margin = 1;
        //    stkMesAnt1.Children.Add(txtMesAnt30);

        //    Label txtMesAntT30 = new Label();
        //    txtMesAntT30.Text = " ";
        //    txtMesAntT30.TextColor = Color.Blue;
        //    txtMesAntT30.HorizontalOptions = LayoutOptions.Center;
        //    txtMesAntT30.VerticalOptions = LayoutOptions.Center;
        //    txtMesAntT30.HorizontalTextAlignment = TextAlignment.Center;
        //    txtMesAntT30.Margin = 1;
        //    stkMesAnt1.Children.Add(txtMesAntT30);

        //    StackLayout stkMesAnt2 = new StackLayout();
        //    stkMesAnt2.BackgroundColor = Color.LightGray;
        //    gridCal2.Children.Add(stkMesAnt2, 1, 0);

        //    Label txtMesAnt31 = new Label();
        //    txtMesAnt31.Text = "31";
        //    txtMesAnt31.TextColor = Color.Black;
        //    txtMesAnt31.FontAttributes = FontAttributes.Bold;
        //    txtMesAnt31.HorizontalOptions = LayoutOptions.Start;
        //    txtMesAnt31.VerticalOptions = LayoutOptions.Start;
        //    txtMesAnt31.HorizontalTextAlignment = TextAlignment.Start;
        //    txtMesAnt31.Margin = 1;
        //    stkMesAnt2.Children.Add(txtMesAnt31);

        //    Label txtMesAntT31 = new Label();
        //    txtMesAntT31.Text = " ";
        //    txtMesAntT31.TextColor = Color.Blue;
        //    txtMesAntT31.HorizontalOptions = LayoutOptions.Center;
        //    txtMesAntT31.VerticalOptions = LayoutOptions.Center;
        //    txtMesAntT31.HorizontalTextAlignment = TextAlignment.Center;
        //    txtMesAntT31.Margin = 1;
        //    stkMesAnt2.Children.Add(txtMesAntT31);

        //    StackLayout stkAbril1 = new StackLayout();
        //    stkAbril1.BackgroundColor = Color.White;
        //    gridCal2.Children.Add(stkAbril1, 2, 0);

        //    Label txtDiaAbril1 = new Label();
        //    txtDiaAbril1.Text = "1";
        //    txtDiaAbril1.TextColor = Color.Black;
        //    txtDiaAbril1.FontAttributes = FontAttributes.Bold;
        //    txtDiaAbril1.HorizontalOptions = LayoutOptions.Start;
        //    txtDiaAbril1.VerticalOptions = LayoutOptions.Start;
        //    txtDiaAbril1.HorizontalTextAlignment = TextAlignment.Start;
        //    txtDiaAbril1.Margin = 1;
        //    stkAbril1.Children.Add(txtDiaAbril1);

        //    Label txtabril1 = new Label();
        //    txtabril1.FontSize = 12;
        //    txtabril1.TextColor = Color.Blue;
        //    txtabril1.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril1.VerticalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril1.HorizontalTextAlignment = TextAlignment.Center;
        //    txtabril1.VerticalTextAlignment = TextAlignment.Center;
        //    txtabril1.Margin = 1;
        //    stkAbril1.Children.Add(txtabril1);

        //    StackLayout stkAbril2 = new StackLayout();
        //    stkAbril2.BackgroundColor = Color.White;
        //    gridCal2.Children.Add(stkAbril2, 3, 0);

        //    Label txtDiaAbril2 = new Label();
        //    txtDiaAbril2.Text = "2";
        //    txtDiaAbril2.TextColor = Color.Black;
        //    txtDiaAbril2.FontAttributes = FontAttributes.Bold;
        //    txtDiaAbril2.HorizontalOptions = LayoutOptions.Start;
        //    txtDiaAbril2.VerticalOptions = LayoutOptions.Start;
        //    txtDiaAbril2.HorizontalTextAlignment = TextAlignment.Start;
        //    txtDiaAbril2.Margin = 1;
        //    stkAbril2.Children.Add(txtDiaAbril2);

        //    Label txtabril2 = new Label();
        //    txtabril2.FontSize = 12;
        //    txtabril2.TextColor = Color.Blue;
        //    txtabril2.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril2.VerticalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril2.HorizontalTextAlignment = TextAlignment.Center;
        //    txtabril2.VerticalTextAlignment = TextAlignment.Center;
        //    txtabril2.Margin = 1;
        //    stkAbril2.Children.Add(txtabril2);

        //    StackLayout stkAbril3 = new StackLayout();
        //    stkAbril3.BackgroundColor = Color.White;
        //    gridCal2.Children.Add(stkAbril3, 4, 0);

        //    Label txtDiaAbril3 = new Label();
        //    txtDiaAbril3.Text = "3";
        //    txtDiaAbril3.TextColor = Color.Black;
        //    txtDiaAbril3.FontAttributes = FontAttributes.Bold;
        //    txtDiaAbril3.HorizontalOptions = LayoutOptions.Start;
        //    txtDiaAbril3.VerticalOptions = LayoutOptions.Start;
        //    txtDiaAbril3.HorizontalTextAlignment = TextAlignment.Start;
        //    txtDiaAbril3.Margin = 1;
        //    stkAbril3.Children.Add(txtDiaAbril3);

        //    Label txtabril3 = new Label();
        //    txtabril3.FontSize = 12;
        //    txtabril3.TextColor = Color.Blue;
        //    txtabril3.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril3.VerticalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril3.HorizontalTextAlignment = TextAlignment.Center;
        //    txtabril3.VerticalTextAlignment = TextAlignment.Center;
        //    txtabril3.Margin = 1;
        //    stkAbril3.Children.Add(txtabril3);

        //    StackLayout stkAbril4 = new StackLayout();
        //    stkAbril4.BackgroundColor = Color.White;
        //    gridCal2.Children.Add(stkAbril4, 5, 0);

        //    Label txtDiaAbril4 = new Label();
        //    txtDiaAbril4.Text = "4";
        //    txtDiaAbril4.TextColor = Color.Black;
        //    txtDiaAbril4.FontAttributes = FontAttributes.Bold;
        //    txtDiaAbril4.HorizontalOptions = LayoutOptions.Start;
        //    txtDiaAbril4.VerticalOptions = LayoutOptions.Start;
        //    txtDiaAbril4.HorizontalTextAlignment = TextAlignment.Start;
        //    txtDiaAbril4.Margin = 1;
        //    stkAbril4.Children.Add(txtDiaAbril4);

        //    Label txtabril4 = new Label();
        //    txtabril4.FontSize = 12;
        //    txtabril4.TextColor = Color.Blue;
        //    txtabril4.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril4.VerticalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril4.HorizontalTextAlignment = TextAlignment.Center;
        //    txtabril4.VerticalTextAlignment = TextAlignment.Center;
        //    txtabril4.Margin = 1;
        //    stkAbril4.Children.Add(txtabril4);

        //    StackLayout stkAbril5 = new StackLayout();
        //    stkAbril5.BackgroundColor = Color.White;
        //    gridCal2.Children.Add(stkAbril5, 6, 0);

        //    Label txtDiaAbril5 = new Label();
        //    txtDiaAbril5.Text = "5";
        //    txtDiaAbril5.TextColor = Color.Black;
        //    txtDiaAbril5.FontAttributes = FontAttributes.Bold;
        //    txtDiaAbril5.HorizontalOptions = LayoutOptions.Start;
        //    txtDiaAbril5.VerticalOptions = LayoutOptions.Start;
        //    txtDiaAbril5.HorizontalTextAlignment = TextAlignment.Start;
        //    txtDiaAbril5.Margin = 1;
        //    stkAbril5.Children.Add(txtDiaAbril5);

        //    Label txtabril5 = new Label();
        //    txtabril5.FontSize = 12;
        //    txtabril5.TextColor = Color.Blue;
        //    txtabril5.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril5.VerticalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril5.HorizontalTextAlignment = TextAlignment.Center;
        //    txtabril5.VerticalTextAlignment = TextAlignment.Center;
        //    txtabril5.Margin = 1;
        //    stkAbril5.Children.Add(txtabril5);


        //    //2DA SEMANA    
        //    StackLayout stkAbril6 = new StackLayout();
        //    stkAbril6.BackgroundColor = Color.White;
        //    gridCal2.Children.Add(stkAbril6, 0, 1);

        //    Label txtDiaAbril6 = new Label();
        //    txtDiaAbril6.Text = "6";
        //    txtDiaAbril6.TextColor = Color.Black;
        //    txtDiaAbril6.FontAttributes = FontAttributes.Bold;
        //    txtDiaAbril6.HorizontalOptions = LayoutOptions.Start;
        //    txtDiaAbril6.VerticalOptions = LayoutOptions.Start;
        //    txtDiaAbril6.HorizontalTextAlignment = TextAlignment.Start;
        //    txtDiaAbril6.Margin = 1;
        //    stkAbril6.Children.Add(txtDiaAbril6);

        //    Label txtabril6 = new Label();
        //    txtabril6.FontSize = 12;
        //    txtabril6.TextColor = Color.Blue;
        //    txtabril6.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril6.VerticalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril6.HorizontalTextAlignment = TextAlignment.Center;
        //    txtabril6.VerticalTextAlignment = TextAlignment.Center;
        //    txtabril6.Margin = 1;
        //    stkAbril6.Children.Add(txtabril6);

        //    StackLayout stkAbril7 = new StackLayout();
        //    stkAbril7.BackgroundColor = Color.White;
        //    gridCal2.Children.Add(stkAbril7, 1, 1);

        //    Label txtDiaAbril7 = new Label();
        //    txtDiaAbril7.Text = "7";
        //    txtDiaAbril7.TextColor = Color.Black;
        //    txtDiaAbril7.FontAttributes = FontAttributes.Bold;
        //    txtDiaAbril7.HorizontalOptions = LayoutOptions.Start;
        //    txtDiaAbril7.VerticalOptions = LayoutOptions.Start;
        //    txtDiaAbril7.HorizontalTextAlignment = TextAlignment.Start;
        //    txtDiaAbril7.Margin = 1;
        //    stkAbril7.Children.Add(txtDiaAbril7);

        //    Label txtabril7 = new Label();
        //    txtabril7.FontSize = 12;
        //    txtabril7.TextColor = Color.Blue;
        //    txtabril7.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril7.VerticalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril7.HorizontalTextAlignment = TextAlignment.Center;
        //    txtabril7.VerticalTextAlignment = TextAlignment.Center;
        //    txtabril7.Margin = 1;
        //    stkAbril7.Children.Add(txtabril7);

        //    StackLayout stkAbril8 = new StackLayout();
        //    stkAbril8.BackgroundColor = Color.White;
        //    gridCal2.Children.Add(stkAbril8, 2, 1);

        //    Label txtDiaAbril8 = new Label();
        //    txtDiaAbril8.Text = "8";
        //    txtDiaAbril8.TextColor = Color.Black;
        //    txtDiaAbril8.FontAttributes = FontAttributes.Bold;
        //    txtDiaAbril8.HorizontalOptions = LayoutOptions.Start;
        //    txtDiaAbril8.VerticalOptions = LayoutOptions.Start;
        //    txtDiaAbril8.HorizontalTextAlignment = TextAlignment.Start;
        //    txtDiaAbril8.Margin = 1;
        //    stkAbril8.Children.Add(txtDiaAbril8);

        //    Label txtabril8 = new Label();
        //    txtabril8.FontSize = 12;
        //    txtabril8.TextColor = Color.Blue;
        //    txtabril8.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril8.VerticalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril8.HorizontalTextAlignment = TextAlignment.Center;
        //    txtabril8.VerticalTextAlignment = TextAlignment.Center;
        //    txtabril8.Margin = 1;
        //    stkAbril8.Children.Add(txtabril8);

        //    StackLayout stkAbril9 = new StackLayout();
        //    stkAbril9.BackgroundColor = Color.White;
        //    gridCal2.Children.Add(stkAbril9, 3, 1);

        //    Label txtDiaAbril9 = new Label();
        //    txtDiaAbril9.Text = "9";
        //    txtDiaAbril9.TextColor = Color.Black;
        //    txtDiaAbril9.FontAttributes = FontAttributes.Bold;
        //    txtDiaAbril9.HorizontalOptions = LayoutOptions.Start;
        //    txtDiaAbril9.VerticalOptions = LayoutOptions.Start;
        //    txtDiaAbril9.HorizontalTextAlignment = TextAlignment.Start;
        //    txtDiaAbril9.Margin = 1;
        //    stkAbril9.Children.Add(txtDiaAbril9);

        //    Label txtabril9 = new Label();
        //    txtabril9.FontSize = 12;
        //    txtabril9.TextColor = Color.Blue;
        //    txtabril9.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril9.VerticalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril9.HorizontalTextAlignment = TextAlignment.Center;
        //    txtabril9.VerticalTextAlignment = TextAlignment.Center;
        //    txtabril9.Margin = 1;
        //    stkAbril9.Children.Add(txtabril9);

        //    StackLayout stkAbril10 = new StackLayout();
        //    stkAbril10.BackgroundColor = Color.White;
        //    gridCal2.Children.Add(stkAbril10, 4, 1);

        //    Label txtDiaAbril10 = new Label();
        //    txtDiaAbril10.Text = "10";
        //    txtDiaAbril10.TextColor = Color.Black;
        //    txtDiaAbril10.FontAttributes = FontAttributes.Bold;
        //    txtDiaAbril10.HorizontalOptions = LayoutOptions.Start;
        //    txtDiaAbril10.VerticalOptions = LayoutOptions.Start;
        //    txtDiaAbril10.HorizontalTextAlignment = TextAlignment.Start;
        //    txtDiaAbril10.Margin = 1;
        //    stkAbril10.Children.Add(txtDiaAbril10);

        //    Label txtabril10 = new Label();
        //    txtabril10.FontSize = 12;
        //    txtabril10.TextColor = Color.Blue;
        //    txtabril10.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril10.VerticalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril10.HorizontalTextAlignment = TextAlignment.Center;
        //    txtabril10.VerticalTextAlignment = TextAlignment.Center;
        //    txtabril10.Margin = 1;
        //    stkAbril10.Children.Add(txtabril10);

        //    StackLayout stkAbril11 = new StackLayout();
        //    stkAbril11.BackgroundColor = Color.White;
        //    gridCal2.Children.Add(stkAbril11, 5, 1);

        //    Label txtDiaAbril11 = new Label();
        //    txtDiaAbril11.Text = "11";
        //    txtDiaAbril11.TextColor = Color.Black;
        //    txtDiaAbril11.FontAttributes = FontAttributes.Bold;
        //    txtDiaAbril11.HorizontalOptions = LayoutOptions.Start;
        //    txtDiaAbril11.VerticalOptions = LayoutOptions.Start;
        //    txtDiaAbril11.HorizontalTextAlignment = TextAlignment.Start;
        //    txtDiaAbril11.Margin = 1;
        //    stkAbril11.Children.Add(txtDiaAbril11);

        //    Label txtabril11 = new Label();
        //    txtabril11.FontSize = 12;
        //    txtabril11.TextColor = Color.Blue;
        //    txtabril11.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril11.VerticalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril11.HorizontalTextAlignment = TextAlignment.Center;
        //    txtabril11.VerticalTextAlignment = TextAlignment.Center;
        //    txtabril11.Margin = 1;
        //    stkAbril11.Children.Add(txtabril11);

        //    StackLayout stkAbril12 = new StackLayout();
        //    stkAbril12.BackgroundColor = Color.White;
        //    gridCal2.Children.Add(stkAbril12, 6, 1);

        //    Label txtDiaAbril12 = new Label();
        //    txtDiaAbril12.Text = "12";
        //    txtDiaAbril12.TextColor = Color.Black;
        //    txtDiaAbril12.FontAttributes = FontAttributes.Bold;
        //    txtDiaAbril12.HorizontalOptions = LayoutOptions.Start;
        //    txtDiaAbril12.VerticalOptions = LayoutOptions.Start;
        //    txtDiaAbril12.HorizontalTextAlignment = TextAlignment.Start;
        //    txtDiaAbril12.Margin = 1;
        //    stkAbril12.Children.Add(txtDiaAbril12);

        //    Label txtabril12 = new Label();
        //    txtabril12.FontSize = 12;
        //    txtabril12.TextColor = Color.Blue;
        //    txtabril12.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril12.VerticalOptions = LayoutOptions.CenterAndExpand;
        //    txtabril12.HorizontalTextAlignment = TextAlignment.Center;
        //    txtabril12.VerticalTextAlignment = TextAlignment.Center;
        //    txtabril12.Margin = 1;
        //    stkAbril12.Children.Add(txtabril12);
        //}
        #endregion
        public async void GetDataAbril()
        {
            DateTime fechaMesAbril = new DateTime(2020, 4, 1);
            int valDiaAbril = 0;

            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://dmrbolivia.online/api_tienda_silvia/VentaRapida/listaVentaRapida.php");
            var dataVR = JsonConvert.DeserializeObject<List<venta_rapida>>(response);
            //Mes Abril            
            for (int iAbril = 0; iAbril <= 30; iAbril++, valDiaAbril++)
            {
                foreach (var item in dataVR)
                {
                    if (item.fecha.Date == fechaMesAbril.AddDays(valDiaAbril))
                    {
                        AbrilArr[iAbril] = AbrilArr[iAbril] + item.monto;
                        TotalAbril = TotalAbril + item.monto;
                    }
                    else
                    {

                    }
                }
            }
            txtabril1.Text = AbrilArr[0].ToString();
            txtabril2.Text = AbrilArr[1].ToString();
            txtabril3.Text = AbrilArr[2].ToString();
            txtabril4.Text = AbrilArr[3].ToString();
            txtabril5.Text = AbrilArr[4].ToString();
            txtabril6.Text = AbrilArr[5].ToString();
            txtabril7.Text = AbrilArr[6].ToString();
            txtabril8.Text = AbrilArr[7].ToString();
            txtabril9.Text = AbrilArr[8].ToString();
            txtabril10.Text = AbrilArr[9].ToString();
            txtabril11.Text = AbrilArr[10].ToString();
            txtabril12.Text = AbrilArr[11].ToString();
            txtabril13.Text = AbrilArr[12].ToString();
            txtabril14.Text = AbrilArr[13].ToString();
            txtabril15.Text = AbrilArr[14].ToString();
            txtabril16.Text = AbrilArr[15].ToString();
            txtabril17.Text = AbrilArr[16].ToString();
            txtabril18.Text = AbrilArr[17].ToString();
            txtabril19.Text = AbrilArr[18].ToString();
            txtabril20.Text = AbrilArr[19].ToString();
            txtabril21.Text = AbrilArr[20].ToString();
            txtabril22.Text = AbrilArr[21].ToString();
            txtabril23.Text = AbrilArr[22].ToString();
            txtabril24.Text = AbrilArr[23].ToString();
            txtabril25.Text = AbrilArr[24].ToString();
            txtabril26.Text = AbrilArr[25].ToString();
            txtabril27.Text = AbrilArr[26].ToString();
            txtabril28.Text = AbrilArr[27].ToString();
            txtabril29.Text = AbrilArr[28].ToString();
            txtabril30.Text = AbrilArr[29].ToString();
            txtTotalAbril.Text = TotalAbril.ToString() + " BS.";

            GetDataMayo();
        }
        public async void GetDataMayo()
        {
            DateTime fechaMesMayo = new DateTime(2020, 5, 1);
            int valDiaMayo = 0;

            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://dmrbolivia.online/api_tienda_silvia/VentaRapida/listaVentaRapida.php");
            var dataVR = JsonConvert.DeserializeObject<List<venta_rapida>>(response);
            //Mes Mayo
            for (int iMayo = 0; iMayo <= 31; iMayo++, valDiaMayo++)
            {
                foreach (var item in dataVR)
                {
                    if (item.fecha.Date == fechaMesMayo.AddDays(valDiaMayo))
                    {
                        MayoArr[iMayo] = MayoArr[iMayo] + item.monto;
                        TotalMayo = TotalMayo + item.monto;
                    }
                    else
                    {

                    }
                }
            }
            txtMayo1.Text = MayoArr[0].ToString();
            txtMayo2.Text = MayoArr[1].ToString();
            txtMayo3.Text = MayoArr[2].ToString();
            txtMayo4.Text = MayoArr[3].ToString();
            txtMayo5.Text = MayoArr[4].ToString();
            txtMayo6.Text = MayoArr[5].ToString();
            txtMayo7.Text = MayoArr[6].ToString();
            txtMayo8.Text = MayoArr[7].ToString();
            txtMayo9.Text = MayoArr[8].ToString();
            txtMayo10.Text = MayoArr[9].ToString();
            txtMayo11.Text = MayoArr[10].ToString();
            txtMayo12.Text = MayoArr[11].ToString();
            txtMayo13.Text = MayoArr[12].ToString();
            txtMayo14.Text = MayoArr[13].ToString();
            txtMayo15.Text = MayoArr[14].ToString();
            txtMayo16.Text = MayoArr[15].ToString();
            txtMayo17.Text = MayoArr[16].ToString();
            txtMayo18.Text = MayoArr[17].ToString();
            txtMayo19.Text = MayoArr[18].ToString();
            txtMayo20.Text = MayoArr[19].ToString();
            txtMayo21.Text = MayoArr[20].ToString();
            txtMayo22.Text = MayoArr[21].ToString();
            txtMayo23.Text = MayoArr[22].ToString();
            txtMayo24.Text = MayoArr[23].ToString();
            txtMayo25.Text = MayoArr[24].ToString();
            txtMayo26.Text = MayoArr[25].ToString();
            txtMayo27.Text = MayoArr[26].ToString();
            txtMayo28.Text = MayoArr[27].ToString();
            txtMayo29.Text = MayoArr[28].ToString();
            txtMayo30.Text = MayoArr[29].ToString();
            txtMayo31.Text = MayoArr[30].ToString();
            txtTotalMayo.Text = TotalMayo.ToString() + " BS.";

            GetDataJunio();
        }
        public async void GetDataJunio()
        {
            DateTime fechaMesJunio = new DateTime(2020, 6, 1);
            int valDiaJunio = 0;

            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://dmrbolivia.online/api_tienda_silvia/VentaRapida/listaVentaRapida.php");
            var dataVR = JsonConvert.DeserializeObject<List<venta_rapida>>(response);
            //Junio
            for (int iJunio = 0; iJunio <= 30; iJunio++, valDiaJunio++)
            {
                foreach (var item in dataVR)
                {
                    if (item.fecha.Date == fechaMesJunio.AddDays(valDiaJunio))
                    {
                        JunioArr[iJunio] = JunioArr[iJunio] + item.monto;
                        TotalJunio = TotalJunio + item.monto;
                    }
                    else
                    {

                    }
                }
            }
            txtJunio1.Text = JunioArr[0].ToString();
            txtJunio2.Text = JunioArr[1].ToString();
            txtJunio3.Text = JunioArr[2].ToString();
            txtJunio4.Text = JunioArr[3].ToString();
            txtJunio5.Text = JunioArr[4].ToString();
            txtJunio6.Text = JunioArr[5].ToString();
            txtJunio7.Text = JunioArr[6].ToString();
            txtJunio8.Text = JunioArr[7].ToString();
            txtJunio9.Text = JunioArr[8].ToString();
            txtJunio10.Text = JunioArr[9].ToString();
            txtJunio11.Text = JunioArr[10].ToString();
            txtJunio12.Text = JunioArr[11].ToString();
            txtJunio13.Text = JunioArr[12].ToString();
            txtJunio14.Text = JunioArr[13].ToString();
            txtJunio15.Text = JunioArr[14].ToString();
            txtJunio16.Text = JunioArr[15].ToString();
            txtJunio17.Text = JunioArr[16].ToString();
            txtJunio18.Text = JunioArr[17].ToString();
            txtJunio19.Text = JunioArr[18].ToString();
            txtJunio20.Text = JunioArr[19].ToString();
            txtJunio21.Text = JunioArr[20].ToString();
            txtJunio22.Text = JunioArr[21].ToString();
            txtJunio23.Text = JunioArr[22].ToString();
            txtJunio24.Text = JunioArr[23].ToString();
            txtJunio25.Text = JunioArr[24].ToString();
            txtJunio26.Text = JunioArr[25].ToString();
            txtJunio27.Text = JunioArr[26].ToString();
            txtJunio28.Text = JunioArr[27].ToString();
            txtJunio29.Text = JunioArr[28].ToString();
            txtJunio30.Text = JunioArr[29].ToString();
            txtTotalJunio.Text = TotalJunio.ToString() + " BS.";

            GetDataJulio();
        }
        public async void GetDataJulio()
        {
            DateTime fechaMesJulio = new DateTime(2020, 7, 1);
            int valDiaJulio = 0;

            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://dmrbolivia.online/api_tienda_silvia/VentaRapida/listaVentaRapida.php");
            var dataVR = JsonConvert.DeserializeObject<List<venta_rapida>>(response);
            //mes julio
            for (int iJuilio = 0; iJuilio <= 31; iJuilio++, valDiaJulio++)
            {
                foreach (var item in dataVR)
                {
                    if (item.fecha.Date == fechaMesJulio.AddDays(valDiaJulio))
                    {
                        JulioArr[iJuilio] = JulioArr[iJuilio] + item.monto;
                        TotalJulio = TotalJulio + item.monto;
                    }
                    else
                    {

                    }
                }
            }
            txtjulio1.Text = JulioArr[0].ToString();
            txtjulio2.Text = JulioArr[1].ToString();
            txtjulio3.Text = JulioArr[2].ToString();
            txtjulio4.Text = JulioArr[3].ToString();
            txtjulio5.Text = JulioArr[4].ToString();
            txtjulio6.Text = JulioArr[5].ToString();
            txtjulio7.Text = JulioArr[6].ToString();
            txtjulio8.Text = JulioArr[7].ToString();
            txtjulio9.Text = JulioArr[8].ToString();
            txtjulio10.Text = JulioArr[9].ToString();
            txtjulio11.Text = JulioArr[10].ToString();
            txtjulio12.Text = JulioArr[11].ToString();
            txtjulio13.Text = JulioArr[12].ToString();
            txtjulio14.Text = JulioArr[13].ToString();
            txtjulio15.Text = JulioArr[14].ToString();
            txtjulio16.Text = JulioArr[15].ToString();
            txtjulio17.Text = JulioArr[16].ToString();
            txtjulio18.Text = JulioArr[17].ToString();
            txtjulio19.Text = JulioArr[18].ToString();
            txtjulio20.Text = JulioArr[19].ToString();
            txtjulio21.Text = JulioArr[20].ToString();
            txtjulio22.Text = JulioArr[21].ToString();
            txtjulio23.Text = JulioArr[22].ToString();
            txtjulio24.Text = JulioArr[23].ToString();
            txtjulio25.Text = JulioArr[24].ToString();
            txtjulio26.Text = JulioArr[25].ToString();
            txtjulio27.Text = JulioArr[26].ToString();
            txtjulio28.Text = JulioArr[27].ToString();
            txtjulio29.Text = JulioArr[28].ToString();
            txtjulio30.Text = JulioArr[29].ToString();
            txtjulio31.Text = JulioArr[30].ToString();
            txtTotalJulio.Text = TotalJulio.ToString() + " BS.";

            GetDataAgosto();
        }
        public async void GetDataAgosto()
        {
            DateTime fechaMesAgosto = new DateTime(2020, 8, 1);
            int valDiaAgosto = 0;

            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://dmrbolivia.online/api_tienda_silvia/VentaRapida/listaVentaRapida.php");
            var dataVR = JsonConvert.DeserializeObject<List<venta_rapida>>(response);
            //mes Agosto
            for (int iAgosto = 0; iAgosto <= 31; iAgosto++, valDiaAgosto++)
            {
                foreach (var item in dataVR)
                {
                    if (item.fecha.Date == fechaMesAgosto.AddDays(valDiaAgosto))
                    {
                        AgostoArr[iAgosto] = AgostoArr[iAgosto] + item.monto;
                        TotalAgosto = TotalAgosto + item.monto;
                    }
                    else
                    {

                    }
                }
            }
            txtAgo1.Text = AgostoArr[0].ToString();
            txtAgo2.Text = AgostoArr[1].ToString();
            txtAgo3.Text = AgostoArr[2].ToString();
            txtAgo4.Text = AgostoArr[3].ToString();
            txtAgo5.Text = AgostoArr[4].ToString();
            txtAgo6.Text = AgostoArr[5].ToString();
            txtAgo7.Text = AgostoArr[6].ToString();
            txtAgo8.Text = AgostoArr[7].ToString();
            txtAgo9.Text = AgostoArr[8].ToString();
            txtAgo10.Text = AgostoArr[9].ToString();
            txtAgo11.Text = AgostoArr[10].ToString();
            txtAgo12.Text = AgostoArr[11].ToString();
            txtAgo13.Text = AgostoArr[12].ToString();
            txtAgo14.Text = AgostoArr[13].ToString();
            txtAgo15.Text = AgostoArr[14].ToString();
            txtAgo16.Text = AgostoArr[15].ToString();
            txtAgo17.Text = AgostoArr[16].ToString();
            txtAgo18.Text = AgostoArr[17].ToString();
            txtAgo19.Text = AgostoArr[18].ToString();
            txtAgo20.Text = AgostoArr[19].ToString();
            txtAgo21.Text = AgostoArr[20].ToString();
            txtAgo22.Text = AgostoArr[21].ToString();
            txtAgo23.Text = AgostoArr[22].ToString();
            txtAgo24.Text = AgostoArr[23].ToString();
            txtAgo25.Text = AgostoArr[24].ToString();
            txtAgo26.Text = AgostoArr[25].ToString();
            txtAgo27.Text = AgostoArr[26].ToString();
            txtAgo28.Text = AgostoArr[27].ToString();
            txtAgo29.Text = AgostoArr[28].ToString();
            txtAgo30.Text = AgostoArr[29].ToString();
            txtAgo31.Text = AgostoArr[30].ToString();
            txtTotalAgosto.Text = txtTotalAgosto.ToString() + " BS.";

            GetDataSeptiembre();
        }
        public async void GetDataSeptiembre()
        {
            DateTime fechaMesSeptiembre = new DateTime(2020, 9, 1);
            int valDiaSeptiembre = 0;
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://dmrbolivia.online/api_tienda_silvia/VentaRapida/listaVentaRapida.php");
            var dataVR = JsonConvert.DeserializeObject<List<venta_rapida>>(response);
            //mes septiembre.
            for (int iSeptiembre = 0; iSeptiembre <= 30; iSeptiembre++, valDiaSeptiembre++)
            {
                foreach (var item in dataVR)
                {
                    if (item.fecha.Date == fechaMesSeptiembre.AddDays(valDiaSeptiembre))
                    {
                        SeptiembreArr[iSeptiembre] = SeptiembreArr[iSeptiembre] + item.monto;
                        TotalSeptiembre = TotalSeptiembre + item.monto;
                    }
                    else
                    {

                    }
                }
            }
            txtSep1.Text = SeptiembreArr[0].ToString();
            txtSep2.Text = SeptiembreArr[1].ToString();
            txtSep3.Text = SeptiembreArr[2].ToString();
            txtSep4.Text = SeptiembreArr[3].ToString();
            txtSep5.Text = SeptiembreArr[4].ToString();
            txtSep6.Text = SeptiembreArr[5].ToString();
            txtSep7.Text = SeptiembreArr[6].ToString();
            txtSep8.Text = SeptiembreArr[7].ToString();
            txtSep9.Text = SeptiembreArr[8].ToString();
            txtSep10.Text = SeptiembreArr[9].ToString();
            txtSep11.Text = SeptiembreArr[10].ToString();
            txtSep12.Text = SeptiembreArr[11].ToString();
            txtSep13.Text = SeptiembreArr[12].ToString();
            txtSep14.Text = SeptiembreArr[13].ToString();
            txtSep15.Text = SeptiembreArr[14].ToString();
            txtSep16.Text = SeptiembreArr[15].ToString();
            txtSep17.Text = SeptiembreArr[16].ToString();
            txtSep18.Text = SeptiembreArr[17].ToString();
            txtSep19.Text = SeptiembreArr[18].ToString();
            txtSep20.Text = SeptiembreArr[19].ToString();
            txtSep21.Text = SeptiembreArr[20].ToString();
            txtSep22.Text = SeptiembreArr[21].ToString();
            txtSep23.Text = SeptiembreArr[22].ToString();
            txtSep24.Text = SeptiembreArr[23].ToString();
            txtSep25.Text = SeptiembreArr[24].ToString();
            txtSep26.Text = SeptiembreArr[25].ToString();
            txtSep27.Text = SeptiembreArr[26].ToString();
            txtSep28.Text = SeptiembreArr[27].ToString();
            txtSep29.Text = SeptiembreArr[28].ToString();
            txtSep30.Text = SeptiembreArr[29].ToString();
            txtTotalSeptiembre.Text = txtTotalSeptiembre.ToString() + " BS.";

            GetDataOctubre();
        }
        public async void GetDataOctubre()
        {
            DateTime fechaMesOctubre = new DateTime(2020, 10, 1);
            int valDiaOctubre = 0;
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://dmrbolivia.online/api_tienda_silvia/VentaRapida/listaVentaRapida.php");
            var dataVR = JsonConvert.DeserializeObject<List<venta_rapida>>(response);
            //mes octubre
            for (int iOctubre = 0; iOctubre <= 31; iOctubre++, valDiaOctubre++)
            {
                foreach (var item in dataVR)
                {
                    if (item.fecha.Date == fechaMesOctubre.AddDays(valDiaOctubre))
                    {
                        OctubreArr[iOctubre] = OctubreArr[iOctubre] + item.monto;
                        TotalOctubre = TotalOctubre + item.monto;
                    }
                    else
                    {

                    }
                }
            }
            txtOct1.Text = OctubreArr[0].ToString();
            txtOct2.Text = OctubreArr[1].ToString();
            txtOct3.Text = OctubreArr[2].ToString();
            txtOct4.Text = OctubreArr[3].ToString();
            txtOct5.Text = OctubreArr[4].ToString();
            txtOct6.Text = OctubreArr[5].ToString();
            txtOct7.Text = OctubreArr[6].ToString();
            txtOct8.Text = OctubreArr[7].ToString();
            txtOct9.Text = OctubreArr[8].ToString();
            txtOct10.Text = OctubreArr[9].ToString();
            txtOct11.Text = OctubreArr[10].ToString();
            txtOct12.Text = OctubreArr[11].ToString();
            txtOct13.Text = OctubreArr[12].ToString();
            txtOct14.Text = OctubreArr[13].ToString();
            txtOct15.Text = OctubreArr[14].ToString();
            txtOct16.Text = OctubreArr[15].ToString();
            txtOct17.Text = OctubreArr[16].ToString();
            txtOct18.Text = OctubreArr[17].ToString();
            txtOct19.Text = OctubreArr[18].ToString();
            txtOct20.Text = OctubreArr[19].ToString();
            txtOct21.Text = OctubreArr[20].ToString();
            txtOct22.Text = OctubreArr[21].ToString();
            txtOct23.Text = OctubreArr[22].ToString();
            txtOct24.Text = OctubreArr[23].ToString();
            txtOct25.Text = OctubreArr[24].ToString();
            txtOct26.Text = OctubreArr[25].ToString();
            txtOct27.Text = OctubreArr[26].ToString();
            txtOct28.Text = OctubreArr[27].ToString();
            txtOct29.Text = OctubreArr[28].ToString();
            txtOct30.Text = OctubreArr[29].ToString();
            txtOct31.Text = OctubreArr[30].ToString();
            txtTotalOctubre.Text = txtTotalOctubre.ToString() + " BS.";

            GetDataNoviembre();
        }
        public async void GetDataNoviembre()
        {
            DateTime fechaMesNoviembre = new DateTime(2020, 11, 1);
            int valDiaNoviembre = 0;

            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://dmrbolivia.online/api_tienda_silvia/VentaRapida/listaVentaRapida.php");
            var dataVR = JsonConvert.DeserializeObject<List<venta_rapida>>(response);
            //mes Noviembre
            for (int iNoviembre = 0; iNoviembre <= 30; iNoviembre++, valDiaNoviembre++)
            {
                foreach (var item in dataVR)
                {
                    if (item.fecha.Date == fechaMesNoviembre.AddDays(valDiaNoviembre))
                    {
                        NoviembreArr[iNoviembre] = NoviembreArr[iNoviembre] + item.monto;
                        TotalNoviembre = TotalNoviembre + item.monto;
                    }
                    else
                    {

                    }
                }
            }
            txtNov1.Text = NoviembreArr[0].ToString();
            txtNov2.Text = NoviembreArr[1].ToString();
            txtNov3.Text = NoviembreArr[2].ToString();
            txtNov4.Text = NoviembreArr[3].ToString();
            txtNov5.Text = NoviembreArr[4].ToString();
            txtNov6.Text = NoviembreArr[5].ToString();
            txtNov7.Text = NoviembreArr[6].ToString();
            txtNov8.Text = NoviembreArr[7].ToString();
            txtNov9.Text = NoviembreArr[8].ToString();
            txtNov10.Text = NoviembreArr[9].ToString();
            txtNov11.Text = NoviembreArr[10].ToString();
            txtNov12.Text = NoviembreArr[11].ToString();
            txtNov13.Text = NoviembreArr[12].ToString();
            txtNov14.Text = NoviembreArr[13].ToString();
            txtNov15.Text = NoviembreArr[14].ToString();
            txtNov16.Text = NoviembreArr[15].ToString();
            txtNov17.Text = NoviembreArr[16].ToString();
            txtNov18.Text = NoviembreArr[17].ToString();
            txtNov19.Text = NoviembreArr[18].ToString();
            txtNov20.Text = NoviembreArr[19].ToString();
            txtNov21.Text = NoviembreArr[20].ToString();
            txtNov22.Text = NoviembreArr[21].ToString();
            txtNov23.Text = NoviembreArr[22].ToString();
            txtNov24.Text = NoviembreArr[23].ToString();
            txtNov25.Text = NoviembreArr[24].ToString();
            txtNov26.Text = NoviembreArr[25].ToString();
            txtNov27.Text = NoviembreArr[26].ToString();
            txtNov28.Text = NoviembreArr[27].ToString();
            txtNov29.Text = NoviembreArr[28].ToString();
            txtNov30.Text = NoviembreArr[29].ToString();
            txtTotalNoviembre.Text = txtTotalNoviembre.ToString() + " BS.";

            GetDataDiciembre();
        }
        public async void GetDataDiciembre()
        {
            DateTime fechaMesDiciembre = new DateTime(2020, 12, 1);
            int valDiaDiciembre = 0;

            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://dmrbolivia.online/api_tienda_silvia/VentaRapida/listaVentaRapida.php");
            var dataVR = JsonConvert.DeserializeObject<List<venta_rapida>>(response);
            //mes Diciembre
            for (int iDiciembre = 0; iDiciembre <= 31; iDiciembre++, valDiaDiciembre++)
            {
                foreach (var item in dataVR)
                {
                    if (item.fecha.Date == fechaMesDiciembre.AddDays(valDiaDiciembre))
                    {
                        DiciembreArr[iDiciembre] = DiciembreArr[iDiciembre] + item.monto;
                        TotalDiciembre = TotalDiciembre + item.monto;
                    }
                    else
                    {

                    }
                }
            }
            txtDic1.Text = DiciembreArr[0].ToString();
            txtDic2.Text = DiciembreArr[1].ToString();
            txtDic3.Text = DiciembreArr[2].ToString();
            txtDic4.Text = DiciembreArr[3].ToString();
            txtDic5.Text = DiciembreArr[4].ToString();
            txtDic6.Text = DiciembreArr[5].ToString();
            txtDic7.Text = DiciembreArr[6].ToString();
            txtDic8.Text = DiciembreArr[7].ToString();
            txtDic9.Text = DiciembreArr[8].ToString();
            txtDic10.Text = DiciembreArr[9].ToString();
            txtDic11.Text = DiciembreArr[10].ToString();
            txtDic12.Text = DiciembreArr[11].ToString();
            txtDic13.Text = DiciembreArr[12].ToString();
            txtDic14.Text = DiciembreArr[13].ToString();
            txtDic15.Text = DiciembreArr[14].ToString();
            txtDic16.Text = DiciembreArr[15].ToString();
            txtDic17.Text = DiciembreArr[16].ToString();
            txtDic18.Text = DiciembreArr[17].ToString();
            txtDic19.Text = DiciembreArr[18].ToString();
            txtDic20.Text = DiciembreArr[19].ToString();
            txtDic21.Text = DiciembreArr[20].ToString();
            txtDic22.Text = DiciembreArr[21].ToString();
            txtDic23.Text = DiciembreArr[22].ToString();
            txtDic24.Text = DiciembreArr[23].ToString();
            txtDic25.Text = DiciembreArr[24].ToString();
            txtDic26.Text = DiciembreArr[25].ToString();
            txtDic27.Text = DiciembreArr[26].ToString();
            txtDic28.Text = DiciembreArr[27].ToString();
            txtDic29.Text = DiciembreArr[28].ToString();
            txtDic30.Text = DiciembreArr[29].ToString();
            txtDic31.Text = DiciembreArr[29].ToString();
            txtTotalDiciembre.Text = txtTotalDiciembre.ToString() + " BS.";
        }

        private void BtnGraficos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Graficos());
        }

        private void BtnGraficosFeb_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Graficos());
        }

        private void BtnGraficosMarzo_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnGraficosAbril_Clicked(object sender, EventArgs e)
        {

        }
        //
        private void BtnGraficosMayo_Clicked(object sender, EventArgs e)
        {

        }
        private void BtnGraficosJunio_Clicked(object sender, EventArgs e)
        {

        }
        private void BtnGraficosJulio_Clicked(object sender, EventArgs e)
        {

        }
        private void BtnGraficosAgosto_Clicked(object sender, EventArgs e)
        {

        }        

        private void BtnGraficosSep_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnGraficosOctubre_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnGraficosNoviembre_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnGraficosDiciembre_Clicked(object sender, EventArgs e)
        {

        }
    }
}