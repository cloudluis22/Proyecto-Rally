using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Modelos;

namespace CapaNegocios
{
    internal class MarcasNegocios
    {
        MarcasDatos contexto;
        public MarcasNegocios()
        {
            contexto = new MarcasDatos();
        }

        public List<Marca> GetMarcas()
        {
            return contexto.GetMarcas();
        }

        public string AgregarMarca(string nombreMarca, string paisFundacion, int anioFundacion)
        {
            return contexto.AgregarMarca(nombreMarca, paisFundacion, anioFundacion);
        }

        public string EliminarMarca(string id)
        {
            return contexto.EliminarMarca(id);
        }

        public Marca GetMarca(string id)
        {
            return contexto.GetMarca(id);
        }

        public string EditMarca(string id, string nombreMarca, string paisFundacion, int anioFundacion)
        {
            return contexto.EditMarca(id, nombreMarca, paisFundacion, anioFundacion);
        }
    }
}
