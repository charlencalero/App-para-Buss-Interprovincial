using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBuss.Page
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RutasPage : ContentPage
	{
		public RutasPage ()
		{
			InitializeComponent ();

            CombOrigen.Items.Add("LIMA");
            CombOrigen.Items.Add("HUANUCO");
            CombOrigen.Items.Add("VITARTE");
            CombOrigen.Items.Add("AMBO");
            CombOrigen.Items.Add("SAN RAFAEL");
            CombOrigen.Items.Add("HUARIACA");


            CombDestino.Items.Add("LIMA");
            CombDestino.Items.Add("HUANUCO");
            CombDestino.Items.Add("VITARTE");
            CombDestino.Items.Add("AMBO");
            CombDestino.Items.Add("SAN RAFAEL");
            CombDestino.Items.Add("HUARIACA");

            combservicioida.Items.Add("9:00 PM - SERVICIO CAMA");
            combservicioida.Items.Add("9:15 PM - SERVICIO ESPECIAL");
            


        }

        private void ButtPrimer_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimerNivelPage());
        }

        private void ButtSegundo_Clicked(object sender, EventArgs e)
        {

        }
    }
}