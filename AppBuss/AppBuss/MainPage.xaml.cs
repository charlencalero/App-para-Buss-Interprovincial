using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
//using culqi.net;
using Newtonsoft.Json.Linq;
using System.Reflection;
using System.IO;

namespace AppBuss
{
	public partial class MainPage : ContentPage
	{

        //https://hprez21.com/2017/03/09/xamarin-forms-ejecutando-codigo-javascript-desde-c/

        public MainPage()
		{
			InitializeComponent();

            // webView.Source = LoadHTMLFileFromResource();

        

        }

        HtmlWebViewSource LoadHTMLFileFromResource()
        {
            try
            {
           var source = new HtmlWebViewSource();


            // Carga el archivo HTML embebido como un recurso en el PCL
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("https://ksoftkf.azurewebsites.net/culqi.html");
            //https://ksoftkf.azurewebsites.net/culqi.html
            //http://localhost:52831/culqi.html

            using (var reader = new StreamReader(stream))
            {
                source.Html = reader.ReadToEnd();
            }
            return source;
            }
            catch (Exception)
            {

                return null;
            }
          


        }

        private async void OnbtnCallJSClicked(object sender, EventArgs e)
        {
            espere.IsRunning = true;
            espere.IsVisible = true;

            string service = txtservicio.Text;
            string valor = txtpasaje.Text;
            webView.Eval(string.Format("settings('ETPOSA','PEN','{0}',{1}00)", service,valor));

            espere.IsVisible = false;

            panel.IsVisible = false;
            webView.IsVisible = true;
        }
    }
}
