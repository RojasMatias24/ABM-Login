using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_Datos;

namespace Logica_de_Negocio
{
    public class UserModel
    {
        UserData UsarDatos = new UserData();
        public bool LoginUsuario(string user, string pass, string estado)
        {
            return UsarDatos.Logearse(user, pass, estado);
        }

        public string PassChange(int id, string contraseña)
        {
            UsarDatos.CambioPass(id, contraseña);
            return "";
        }

        public string Cambiofecha(int id, string fecha, string fechalimite)
        {
            UsarDatos.CambioFechaPass(id, fecha, fechalimite);
            return "";
        }

        public string CambioEstado(int id, string estado)
        {
            UsarDatos.CambiarEstado(id, estado);
            return "";
        }
    }
}
