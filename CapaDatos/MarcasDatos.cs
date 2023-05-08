using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace CapaDatos
{
    internal class MarcasDatos
    {
        string cadenaAcceso =
    "Server=JL;" +
    "Database=carros;" +
    "User Id=sa;" +
    "Password=admin123;";

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public MarcasDatos()
        {

        }

        /// <summary>
        /// Obtener información sobre todos los corredores
        /// </summary>
        /// <returns> Una lista de objetos tipo Marca con la informacion de
        /// cada corredor. </returns>
        public List<Marca> GetMarcas()
        {
            List<Marca> marcas = new List<Marca>();

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaAcceso))
                {
                    conn.Open();
                    string query = "SELECT * FROM Marcas";
                    SqlCommand comando = new SqlCommand(query, conn);
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        string id = lector["Id"].ToString();
                        string nombreMarca = lector["NombreMarca"].ToString();
                        string paisFundacion = lector["PaisFundacion"].ToString();
                        int anio = int.Parse(lector["anioFundacion"].ToString());

                        Marca corredor = new Marca(id, nombreMarca, paisFundacion, anio);
                        marcas.Add(corredor);
                    }

                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }

            return marcas;
        }


        public string AgregarMarca(string nombreMarca, string paisFundacion, int anioFundacion)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaAcceso))
                {
                    Guid id = Guid.NewGuid();

                    conn.Open();
                    string query = "INSERT INTO Marcas(Id, NombreMarca, PaisFundacion, AnioFundacion) VALUES(@id, @nombre, @pais, @anio)";
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.Parameters.AddWithValue("id", id.ToString());
                    comando.Parameters.AddWithValue("nombre", nombreMarca);
                    comando.Parameters.AddWithValue("pais", paisFundacion);
                    comando.Parameters.AddWithValue("anio", anioFundacion);

                    int res = comando.ExecuteNonQuery();
                    return "Marca Agregada Exitosamente.";

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
        public string EliminarMarca(string id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaAcceso))
                {
                    conn.Open();
                    string query = "DELETE FROM Marcas WHERE Id = @id";
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.Parameters.AddWithValue("id", id);
                    int res = comando.ExecuteNonQuery();
                    return "Marca eliminada con éxito.";
                }
            }
            catch (SqlException ex)
            {
                return ex.Message;
                throw ex;
            }
        }

        public Marca GetMarca(string idMarca)
        {
            Marca marca = new Marca();

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaAcceso))
                {
                    conn.Open();
                    string query = "SELECT * FROM Marcas WHERE Id = @id";
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.Parameters.AddWithValue("id", idMarca);
                    int res = comando.ExecuteNonQuery();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        string id = lector["Id"].ToString();
                        string nombreMarca = lector["NombreMarca"].ToString();
                        string paisFundacion = lector["PaisFundacion"].ToString();
                        int anioFundacion = int.Parse(lector["AnioFundacion"].ToString());

                        marca = new Marca(id, nombreMarca, paisFundacion, anioFundacion);

                    }
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return marca;

        }

        public string EditMarca(string id, string nombreMarca, string paisFundacion, int anioFundacion)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaAcceso))
                {
                    conn.Open();
                    string query = "UPDATE Marcas SET NombreMarca = @nombre, PaisFundacion = @pais, AnioFundacion = @anio WHERE Id = @id";
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.Parameters.AddWithValue("id", id);
                    comando.Parameters.AddWithValue("nombre", nombreMarca);
                    comando.Parameters.AddWithValue("pais", paisFundacion);
                    comando.Parameters.AddWithValue("anio", anioFundacion);

                    int res = comando.ExecuteNonQuery();
                    return "Marca actualizada con éxito. Actualice la tabla para visualizar los cambios.";
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
