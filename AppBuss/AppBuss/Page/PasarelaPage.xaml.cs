using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Reflection;
using AppBuss.Entity;

namespace AppBuss.Page
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PasarelaPage : ContentPage
	{
        Pasajero pasaj = new Pasajero();

        public PasarelaPage (Pasajero pasajero)
		{
			InitializeComponent ();
            pasaj = pasajero;

        }



           void webOnEndNavigating(object sender, WebNavigatedEventArgs e)
            {
            lanzar();
            }
    

        private  void lanzar()
        {
            espere.IsRunning = true;
            espere.IsVisible = true;

            string service = "Servicio Buss Cama - Asiento:" + pasaj.asiento ;
            string valor ="50";

           webView.Eval(string.Format("settings('ETPOSA','PEN','{0}',{1}00)", service, valor));

            espere.IsVisible = false;

            //panel.IsVisible = false;
            webView.IsVisible = true;
        }
    }
}