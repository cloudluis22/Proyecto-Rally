using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    internal class Marca
    {
        public string id { get; set; }
        public string nombreMarca { get; set; }
        public string paisFundacion { get; set; }
        public int anioFundacion { get; set; }

        // Constructor vacío
        public Marca() { }

        // Constructor con parámetros

        public Marca(string id, string nombreMarca, string paisFundacion, int anioFundacion)
        {
            this.id = id;
            this.nombreMarca = nombreMarca;
            this.paisFundacion = paisFundacion;
            this.anioFundacion = anioFundacion;
        }
    }
}
