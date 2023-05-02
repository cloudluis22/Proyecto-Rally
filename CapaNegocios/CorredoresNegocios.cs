using CapaDatos;
using Modelos;

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
    }
}