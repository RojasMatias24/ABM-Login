using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using CapaComun;


namespace Acceso_Datos
{
    public class UserData : ConexionSQL
    {
        
        public bool Logearse(string user, string pass, string estado)
        {
            using (SqlConnection cnn = GetConexion())
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = cnn;
                    command.CommandText = "SELECT * FROM Usuario WHERE Usuario=@user and Contraseña=@pass and Estado=@estado";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            Cache.ID_USUARIO = reader.GetInt32(0);
                            Cache.Password = reader.GetString(2);
                            Cache.Estado = reader.GetString(8);
                            Cache.Fecha=reader.GetString(6);
                            Cache.FechaFinal=reader.GetString(7);
                        }
                        
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
        }

        public void CambioPass(int id, string contraseña)
        {
            using (SqlConnection cnn = GetConexion())
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = cnn;
                    command.CommandText = "update Usuario set Contraseña=@contraseña where ID_usuario=@id";
                    command.Parameters.AddWithValue("@contraseña", contraseña);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;

                    command.ExecuteNonQuery();

                    command.Parameters.Clear();

                }
            }
        }

        public void CambioFechaPass(int id, string fecha, string fechalimite)
        {
            using (SqlConnection cnn = GetConexion())
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = cnn;
                    command.CommandText = "update Usuario set Fecha=@fecha, FechaLimite=@fechalimite where ID_usuario=@id";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@fechalimite", fechalimite);
                    command.CommandType = CommandType.Text;

                    command.ExecuteNonQuery();

                    command.Parameters.Clear();

                }
            }

        }

        public void CambiarEstado(int id, string estado)
        {
            using (SqlConnection cnn = GetConexion())
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = cnn;
                    command.CommandText = "update Usuario set Estado=@estado where ID_usuario=@id";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.CommandType = CommandType.Text;

                    command.ExecuteNonQuery();

                    command.Parameters.Clear();

                }
            }
        }
    }
}


