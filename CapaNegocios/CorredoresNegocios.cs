using CapaDatos;
using Modelos;
using System.Text.RegularExpressions;

namespace CapaNegocios
{
    public class CorredoresNegocios
    {
        CorredoresDatos contexto;
        public CorredoresNegocios()
        {
            contexto = new CorredoresDatos();
        }

        public List<Corredor> GetCorredores()
        {
            return contexto.GetCorredores();
        }

        public string AgregarCorredor(string nombreCorredor, string nacionalidad, int edad, string marca, int puntos)
        {
            return contexto.AgregarCorredor(nombreCorredor, nacionalidad, edad, marca, puntos);
        }

        public string EliminarCorredor(string id)
        {
            return contexto.EliminarCorredor(id);
        }
    }
}