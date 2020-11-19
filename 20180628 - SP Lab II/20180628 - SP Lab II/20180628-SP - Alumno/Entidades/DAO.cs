using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Entidades
{
    public class DAO<T> : IArchivos<T>
        where T: Votacion
    {


        public DAO()
        {
        }
           
        public T Leer(string rutaArchivo)
        {
            throw new ErrorArchivoExcepcion("Error de daos");
        }

        public bool Guardar(string rutaArchivo,T objeto)
        {
            SqlConnection sqlConnection = null;
            try
            {
            string command = "INSERT INTO Votaciones (nombreLey,afirmativos,negativos,abstenciones,nombreAlumno) VALUES (@nombreLey,@afirmativos,@negativos,@abstenciones,@nombreAlumno)";
            sqlConnection = new SqlConnection(rutaArchivo);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("nombreLey", objeto.NombreLey);
            sqlCommand.Parameters.AddWithValue("afirmativos", objeto.ContadorAfirmativo);
            sqlCommand.Parameters.AddWithValue("negativos", objeto.ContadorNegativo);
            sqlCommand.Parameters.AddWithValue("abstenciones", objeto.ContadorAbstencion);
            sqlCommand.Parameters.AddWithValue("nombreAlumno", "Ricardo Rios");
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw new ErrorArchivoExcepcion();
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return true;
        }
    }
}
