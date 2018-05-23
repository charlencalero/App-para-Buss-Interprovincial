using System;
using System.Collections.Generic;
using System.Text;

namespace AppBuss.Entity
{
    public class Ruta
    {
        public Ruta(int id, Ciudad origen, Ciudad destino, string hora, string descripcion)
        {
            this.id = id;
            this.origen = origen;
            this.destino = destino;
            this.hora = hora;
            this.descripcion = descripcion;
        }

        public int id { get; set; }
        public Ciudad origen { get; set; }
        public Ciudad destino { get; set; }
        public string hora { get; set; }
        public string descripcion { get; set; }
        public string precioprimer { get; set; }
        public string preciosegundo { get; set; }
    }
}
