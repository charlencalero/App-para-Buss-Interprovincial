using System;
using System.Collections.Generic;
using System.Text;

namespace AppBuss.Entity
{
   public class PersonalBuss
    {
        public PersonalBuss(int id, string dni, string brevet, string nombres, string telefono)
        {
            this.id = id;
            this.dni = dni;
            this.brevet = brevet;
            this.nombres = nombres;
            this.telefono = telefono;
        }

        public int id { get; set; }
        public string dni { get; set; }
        public string brevet { get; set; }
        public string nombres { get; set; }
        public string telefono { get; set; }
    }
}
