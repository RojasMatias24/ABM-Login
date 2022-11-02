using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Acceso_Datos;
using System.Data;

namespace Logica_de_Negocio
{
    public class CN_ABM
    {
        private ABMData DatosABM = new ABMData();

        public DataTable MostrarUsers()
        {
            DataTable dt = new DataTable();
            dt = DatosABM.Mostrar();
            return dt;
        }

        public void AgregarUsuario(string usuario, string contraseña, string nombre, string apellido,
            string email, string fecha,string fechalimite ,string estado)
        {
            DatosABM.Insertar(usuario, contraseña, nombre, apellido, email, Convert.ToDateTime(fecha), Convert.ToDateTime(fechalimite), estado);
        }

        public void EditarUsuario(string usuario, string nombre, string apellido,
            string email, string estado, string id)
        {
            DatosABM.Editar(usuario, nombre, apellido, email, estado,id);
        }

       public void EliminarUsuario(string id)
       {
            DatosABM.EliminarUsuer(Convert.ToInt32(id));
       }

      
        
    }
}
