using System;
using System.Collections.Generic;
using System.Text;

namespace AppBuss.Entity
{
    public class Viajes
    {
        public Viajes(int id, Buss buss, Ruta ruta, string fecha)
        {
            this.id = id;
            this.buss = buss;
            this.ruta = ruta;
            this.fecha = fecha;
        }

        public int id { get; set; }
        public Buss buss { get; set; }
        public Ruta ruta { get; set; }
        public string fecha { get; set; }

    }
}
