using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Datos
{
    public class ABMData: ConexionSQL
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        public DataTable Mostrar()
        {
            using(SqlConnection cnn = GetConexion())
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand())
                {

                    command.Connection = cnn;
                    command.CommandText = "SELECT * FROM Usuario";
                    command.CommandType = System.Data.CommandType.Text;
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    leer = sqlDataReader;
                    tabla.Load(leer);
                    return tabla;
                }
            }
          
        }
    

        public void Insertar(string usuario, string contraseña, string nombre, string apellido,
            string email, DateTime fecha, DateTime fechalimite, string estado)
        {
            using (SqlConnection cnn = GetConexion())
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand())
                {

                    command.Connection = cnn;
                    command.CommandText = "sp_AgregarUsuario";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@fecha ", fecha);
                    command.Parameters.AddWithValue("@fechalimite ", fechalimite);
                    command.Parameters.AddWithValue("@estado", estado);

                    command.ExecuteNonQuery();

                    command.Parameters.Clear();

                }
            }

        }
         public void Editar(string usuario, string nombre, string apellido,
            string email, string estado, string id)
         {
            using (SqlConnection cnn = GetConexion())
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = cnn;
                    command.CommandText = "sp_EditarDatos";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@id",id); 

                    command.ExecuteNonQuery();

                    command.Parameters.Clear();

                }
            }
         }

        public void EliminarUsuer(int id)
        {
            using (SqlConnection cnn = GetConexion())
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = cnn;
                    command.CommandText = "sp_EliminarUsuario";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@iduser", id);

                    command.ExecuteNonQuery();

                    command.Parameters.Clear();

                }
            }
        }
        




    }
}
