using Logica_de_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun;

namespace Login
{
    public partial class frmCambioPass : Form
    {
        public frmCambioPass()
        {
            InitializeComponent();
        }
        UserModel userModel = new UserModel();
        private string hoydia =null;
        private string fechalimit=null;

        private void txtContraseña2_TextChanged(object sender, EventArgs e)
        {
            txtContraseña2.UseSystemPasswordChar = true;
        }

        private void txtNuevaContraseña_TextChanged(object sender, EventArgs e)
        {
            txtNuevaContraseña.UseSystemPasswordChar = true;
        }

        private void txtNConfirContraseña_TextChanged(object sender, EventArgs e)
        {
            txtNConfirContraseña.UseSystemPasswordChar = true;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (txtNuevaContraseña.Text == txtNConfirContraseña.Text)
            {
                if (txtContraseña2.Text == Cache.Password)
                {
                    FechaLimit();
                    CurrentFecha();
                    userModel.PassChange(Cache.ID_USUARIO, txtNuevaContraseña.Text);
                    userModel.Cambiofecha(Cache.ID_USUARIO,hoydia, fechalimit);
                    limpiar();
                    MessageBox.Show("La contrasela se cambio con exito.",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("La contraseña actual es erronea.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            txtContraseña2.Clear();
            txtNConfirContraseña.Clear();
            txtNuevaContraseña.Clear();
        }


        private void FechaLimit()
        {
            DateTime hoy = DateTime.Now;
            hoy = hoy.AddDays(30);
            fechalimit = hoy.ToString("dd/MM/yyyy");
        }

        private void CurrentFecha()
        {
            DateTime ahora= DateTime.Now;
            hoydia= ahora.ToString("dd/MM/yyyy");
        }

        private void pctVerPass_Click(object sender, EventArgs e)
        {
            if (txtContraseña2.UseSystemPasswordChar == true)
            {
                txtContraseña2.UseSystemPasswordChar = false;
                pctVerPass.Visible = true;
            }
            else if (txtContraseña2.UseSystemPasswordChar == false)
            {
                txtContraseña2.UseSystemPasswordChar = true;
            }
        }

        private void icnMirar2_Click(object sender, EventArgs e)
        {
            if (txtNuevaContraseña.UseSystemPasswordChar == true && txtNConfirContraseña.UseSystemPasswordChar == true)
            {
                txtNuevaContraseña.UseSystemPasswordChar = false;
                txtNConfirContraseña.UseSystemPasswordChar = false;
                pctVerPass.Visible = true;
            }
            else if (txtNuevaContraseña.UseSystemPasswordChar == false)
            {
                txtNuevaContraseña.UseSystemPasswordChar = true;
                txtNConfirContraseña.UseSystemPasswordChar = true;
            }
        }

       
    }
}
