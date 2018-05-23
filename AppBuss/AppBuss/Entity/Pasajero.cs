using System;
using System.Collections.Generic;
using System.Text;

namespace AppBuss.Entity
{
    public class Pasajero
    {
        public Pasajero()
        {
        }

        public Pasajero(int id, Ruta ruta, string fecha, string tipocomp, string seriecomp, string numecomp, string valorpasaje, string asiento)
        {
            this.id = id;
            this.ruta = ruta;
            this.fecha = fecha;
            this.tipocomp = tipocomp;
            this.seriecomp = seriecomp;
            this.numecomp = numecomp;
            this.valorpasaje = valorpasaje;
            this.asiento = asiento;
        }

        public int id { get; set; }
        public Ruta ruta { get; set; }
        public string fecha { get; set; }
        public string tipocomp  { get; set; }
        public string seriecomp { get; set; }
        public string numecomp { get; set; }
        public string valorpasaje { get; set; }
        public string asiento { get; set; }

    }
}
