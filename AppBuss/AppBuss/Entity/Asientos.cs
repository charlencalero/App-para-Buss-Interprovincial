using System;
using System.Collections.Generic;
using System.Text;

namespace AppBuss.Entity
{
    public class Asientos
    {
        public Asientos()
        {
        }

        public Asientos(int id, int idbuss, int buss, string descripcion)
        {
            this.id = id;
            this.idbuss = idbuss;
            this.buss = buss;
            this.descripcion = descripcion;
        }

        public int id { get; set; }
        public int idbuss { get; set; }
        public int buss { get; set; }
        public string descripcion { get; set; }

    }
}
