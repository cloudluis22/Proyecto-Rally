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
                        string nacionalidad = lector["Nacionalidad"].ToString();
                        int edad = int.Parse(lector["Edad"].ToString());
                        string marca = lector["Marca"].ToString();
                        int puntos = int.Parse(lector["Puntos"].ToString());

                        Corredor corredor = new Corredor(id, nombreCorredor, nacionalidad, edad, marca, puntos);
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

        /// <summary>
        /// Agrega un corredor a la base de datos
        /// </summary>
        /// <param name="nombreCorredor"> Nombre del corredor. </param>
        /// <param name="nacionalidad"> Nacionalidad del corredor. </param>
        /// <param name="edad"> Edad actual del corredor.  </param>
        /// <param name="marca"> Marca a la que pertenece el corredor. </param>
        /// <param name="puntos"> Puntos que tiene el corredor actualmente. </param>
        /// <returns></returns>
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

        /// <summary>
        /// Elimina un corredor de la base de datos.
        /// </summary>
        /// <param name="id"> ID del corredor a eliminar. </param>
        /// <returns></returns>
        public string EliminarCorredor(string id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaAcceso))
                {
                    conn.Open();
                    string query = "DELETE FROM Corredores WHERE Id = @id";
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.Parameters.AddWithValue("id", id);
                    int res = comando.ExecuteNonQuery();
                    return "Corredor eliminado con éxito.";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message;
                throw ex;
            }
        }


        /// <summary>
        /// Obtiene un corredor en particular.
        /// </summary>
        /// <param name="idCorredor"> ID única del conductor. </param>
        /// <returns></returns>
        public Corredor GetCorredor(string idCorredor)
        {
            Corredor corredor = new Corredor();
            
            try
            {
               using(SqlConnection conn = new SqlConnection(cadenaAcceso))
                {
                    conn.Open();
                    string query = "SELECT * FROM Corredores WHERE Id = @id";
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.Parameters.AddWithValue("id", idCorredor);
                    int res = comando.ExecuteNonQuery();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        string id = lector["Id"].ToString();
                        string nombreCorredor = lector["NombreCorredor"].ToString();
                        string nacionalidad = lector["Nacionalidad"].ToString();
                        int edad = int.Parse(lector["Edad"].ToString());
                        string marca = lector["Marca"].ToString();
                        int puntos = int.Parse(lector["Puntos"].ToString());

                         corredor = new Corredor(id, nombreCorredor, nacionalidad,edad, marca, puntos);

                    }
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return corredor;

        }

        public string EditCorredor(string id, string nombreCorredor, string nacionalidad, int edad, string marca, int puntos)
        {
           
            try
            {
                using(SqlConnection conn = new SqlConnection(cadenaAcceso))
                {
                    conn.Open();
                    string query = "UPDATE Corredores SET NombreCorredor = @nombre, Nacionalidad = @nacionalidad, Edad = @edad, Marca = @marca, Puntos = @puntos WHERE Id = @id";
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.Parameters.AddWithValue("id", id);
                    comando.Parameters.AddWithValue("nombre", nombreCorredor);
                    comando.Parameters.AddWithValue("nacionalidad", nacionalidad);
                    comando.Parameters.AddWithValue("edad", edad);
                    comando.Parameters.AddWithValue("marca", marca);
                    comando.Parameters.AddWithValue("puntos", puntos);

                    int res = comando.ExecuteNonQuery();
                    return "Corredor actualizado con éxito. Actualice la tabla para visualizar los cambios.";
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