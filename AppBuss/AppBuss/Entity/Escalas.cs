using System;
using System.Collections.Generic;
using System.Text;

namespace AppBuss.Entity
{
    public class Escalas
    {
        public Escalas(int id, Ruta ruta, Ciudad escalaorigen, Ciudad escaladestino)
        {
            this.id = id;
            this.ruta = ruta;
            this.escalaorigen = escalaorigen;
            this.escaladestino = escaladestino;
        }

        public int id { get; set; }
        public Ruta ruta { get; set; }
        public Ciudad escalaorigen { get; set; }
        public Ciudad escaladestino { get; set; }

    }
}
