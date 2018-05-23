using AppBuss.Entity;
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

	public partial class PrimerNivelPage : ContentPage
	{
		public PrimerNivelPage ()
		{
			InitializeComponent ();

            CargarBuss();
            CargarDataPasajeros();
		}

        List<Asientos> asientos = new List<Asientos>();

        private void CargarBuss()
        {
           
            asientos.Add(new Asientos(100, 1, 1, "1"));
            asientos.Add(new Asientos(101, 2, 1, "2"));
            asientos.Add(new Asientos(101, 3, 1, "3"));
            asientos.Add(new Asientos(101, 4, 1, ""));
            asientos.Add(new Asientos(101, 5, 1, "4"));
            asientos.Add(new Asientos(101, 6, 1, "5"));
            asientos.Add(new Asientos(101, 7, 1, "6"));
            asientos.Add(new Asientos(101, 8, 1, ""));
            asientos.Add(new Asientos(101, 9, 1, "7"));
            asientos.Add(new Asientos(101, 10, 1, "8"));
            asientos.Add(new Asientos(101, 11, 1, "9"));
            asientos.Add(new Asientos(101, 12, 1, ""));
            asientos.Add(new Asientos(101, 13, 1, "10"));
            asientos.Add(new Asientos(101, 14, 1, "11"));
            asientos.Add(new Asientos(101, 15, 1, "12"));
            asientos.Add(new Asientos(101, 16, 1, ""));

           
                Evaluar(asientos[0], a1);
                Evaluar(asientos[1], a2);
                Evaluar(asientos[2], a3);
                Evaluar(asientos[3], a4);
                Evaluar(asientos[4], a5);
                Evaluar(asientos[5], a6);
                Evaluar(asientos[6], a7);
                Evaluar(asientos[7], a8);
                Evaluar(asientos[8], a9);
                Evaluar(asientos[9], a10);
                Evaluar(asientos[10], a11);
                Evaluar(asientos[11], a12);
                Evaluar(asientos[12], a13);
                Evaluar(asientos[13], a14);
                Evaluar(asientos[14], a15);
                Evaluar(asientos[15], a16);

        }

        private void Evaluar(Asientos asiento,Button a)
        {
            if (asiento.descripcion == "")
            {
                a.IsEnabled = false;
                a.Image = "";
            }
            else
            {
              
                a.IsEnabled = true;
                a.Image = "AsieLibre.png";
            }
        }


        private void CargarDataPasajeros()
        {
          //  throw new NotImplementedException();
        }

        private void Accion(int id)
        {
            var pasajero = new Pasajero();
            pasajero.asiento = asientos[id].descripcion;
            pasajero.fecha = "2018-05-19 00:00";

            Navigation.PushAsync(new PasarelaPage(pasajero));
        }

        private void a1_Clicked(object sender, EventArgs e)
        {
            Accion(1);
        }

        private void a2_Clicked(object sender, EventArgs e)
        {
            Accion(2);
        }

        private void a3_Clicked(object sender, EventArgs e)
        {
            Accion(3);
        }

        private void a4_Clicked(object sender, EventArgs e)
        {
            Accion(4);
        }

        private void a5_Clicked(object sender, EventArgs e)
        {
            Accion(5);
        }

        private void a6_Clicked(object sender, EventArgs e)
        {
            Accion(6);
        }

        private void a7_Clicked(object sender, EventArgs e)
        {
            Accion(7);
        }

        private void a8_Clicked(object sender, EventArgs e)
        {
            Accion(8);
        }

        private void a9_Clicked(object sender, EventArgs e)
        {
            Accion(9);
        }

        private void a10_Clicked(object sender, EventArgs e)
        {
            Accion(10);
        }

        private void a11_Clicked(object sender, EventArgs e)
        {
            Accion(11);
        }

        private void a12_Clicked(object sender, EventArgs e)
        {
            Accion(12);
        }

        private void a13_Clicked(object sender, EventArgs e)
        {
            Accion(13);
        }

        private void a14_Clicked(object sender, EventArgs e)
        {
            Accion(14);
        }

        private void a15_Clicked(object sender, EventArgs e)
        {
            Accion(15);
        }

        private void a16_Clicked(object sender, EventArgs e)
        {
             Accion(16);
        } 
    }
}