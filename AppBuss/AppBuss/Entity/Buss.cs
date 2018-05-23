using System;
using System.Collections.Generic;
using System.Text;

namespace AppBuss.Entity
{
    public class Buss
    {
        public Buss(int id, string placa, string mtc, string asie_pasajeros, string asie_tripulacion, PersonalBuss piloto, PersonalBuss copiloto, PersonalBuss terramoza)
        {
            this.id = id;
            this.placa = placa;
            this.mtc = mtc;
            this.asie_pasajeros = asie_pasajeros;
            this.asie_tripulacion = asie_tripulacion;
            this.piloto = piloto;
            this.copiloto = copiloto;
            this.terramoza = terramoza;
        }

        public int id { get; set; }
        public string placa { get; set; }
        public string mtc { get; set; }
        public string asie_pasajeros { get; set; }
        public string asie_tripulacion { get; set; }

        public PersonalBuss piloto { get; set; }
        public PersonalBuss copiloto { get; set; }
        public PersonalBuss terramoza { get; set; }

    }
}
