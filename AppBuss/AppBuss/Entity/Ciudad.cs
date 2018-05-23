using System;
using System.Collections.Generic;
using System.Text;

namespace AppBuss.Entity
{
    public class Ciudad
    {
        public Ciudad(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public int id { get; set; }
        public string nombre { get; set; }
    }
}
