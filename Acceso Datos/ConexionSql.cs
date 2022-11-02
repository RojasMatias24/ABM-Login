using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Datos
{
    public abstract class ConexionSQL
    {
        private readonly string connection;
        public ConexionSQL()
        {
            connection = "Server=localhost\\SQLEXPRESS; DataBase=Login; integrated security=true";

        }

        protected SqlConnection GetConexion()
        {
            return new SqlConnection(connection);
        }
    }
}
