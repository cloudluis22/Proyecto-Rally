using Modelos;
using System.Data.SqlClient;

namespace CapaDatos

{
    public class CorredoresDatos
    {
        string cadenaAcceso =
            "Server=JL;" +
            "Database=carros;" +
            "User Id=sa;" +
            "Password=admin123;";

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public CorredoresDatos()
        {

        }

        /// <summary>
        /// Obtener información sobre todos los corredores
        /// </summary>
        /// <returns> Una lista de objetos tipo Corredor con la informacion de
        /// cada corredor. </returns>
        public List<Corredor> GetCorredores()
        {
            List<Corredor> corredores = new List<Corredor>();

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaAcceso))
                {
                    conn.Open();
                    string query = "SELECT * FROM Corredores";
                    SqlCommand comando = new SqlCommand(query, conn);
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        string id = lector["Id"].ToString();
                        string nombreCorredor = lector["NombreCorredor"].ToString();
                        int edad = int.Parse(lector["Edad"].ToString());
                        string marca = lector["Marca"].ToString();
                        int puntos = int.Parse(lector["Puntos"].ToString());

                        Corredor corredor = new Corredor(id, nombreCorredor, edad, marca, puntos);
                        corredores.Add(corredor);
                    }

                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }

            return corredores;
        }

        public string AgregarCorredor(string nombreCorredor, string nacionalidad, int edad, string marca, int puntos)
        {
            try
            {
               using(SqlConnection conn = new SqlConnection(cadenaAcceso))
                {
                    Guid id = Guid.NewGuid();

                    conn.Open();
                    string query = "INSERT INTO Corredores(Id, NombreCorredor, Nacionalidad, Edad, Marca, Puntos) VALUES(@id, @nombre, @nacionalidad, @edad, @marca, @puntos)";
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.Parameters.AddWithValue("id", id.ToString());
                    comando.Parameters.AddWithValue("nombre", nombreCorredor);
                    comando.Parameters.AddWithValue("nacionalidad", nacionalidad);
                    comando.Parameters.AddWithValue("edad", edad);
                    comando.Parameters.AddWithValue("marca", marca);
                    comando.Parameters.AddWithValue("puntos", puntos);

                    int res = comando.ExecuteNonQuery();
                    return "Corredor Agregado Exitosamente.";

                }
            }
            catch (SqlException ex)
            {
                return ex.Message;
                throw ex;
            }
        }

    }
}