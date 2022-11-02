using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica_de_Negocio;
using CapaComun;

namespace Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        UserModel usuarioModel=new UserModel();
        Cache cache =new Cache();
        private int intento = 0;
        private string usuario = "";

        frmCambioPass frmCambioPass = new frmCambioPass();
        private void txtUser_MouseEnter(object sender, EventArgs e)
        {
            if (txtUser.Text == "User")
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "User";
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Password")
            {
                txtContraseña.Text = "";
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_MouseLeave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Password";
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "User")
            {
                if (txtContraseña.Text != "Password")
                {

                    var ValidLogin = usuarioModel.LoginUsuario(txtUser.Text, txtContraseña.Text,txtEstado.Text);
                    if (ValidLogin == true)
                    {
                        if(Cache.Estado==txtEstado.Text)
                        {
                            CambiarContraxExpiracion();
                            frmHome Home = new frmHome();
                            Home.ShowDialog();
                            this.Hide();
                        }
                        else
                        {
                            UsuarioBloq();
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña invalido./n Revise que su usuario no este bloqueado. ",
                        "warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        if (intento < 3)
                        {
                            if (intento == 0)
                            {
                                usuario = txtUser.Text;
                                intento = 1;
                                txtContraseña.Clear();
                            }
                            else
                            {
                                if (usuario == txtUser.Text)
                                {
                                    intento++;
                                    txtContraseña.Clear();
                                }
                            }
                        }
                        else
                        {
                            UsuarioBloq();

                        }
                    }
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
                pctVerPass.Visible = true;              
            }
            else if (txtContraseña.UseSystemPasswordChar == false)
            {
                txtContraseña.UseSystemPasswordChar = true;              
            }
        }

        private void UsuarioBloq()
        {
            string usuario = "Bloqueado";
            usuarioModel.CambioEstado(Cache.ID_USUARIO, usuario);
            MessageBox.Show("Usuario bloqueado",
                            "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            txtContraseña.Clear();
            txtUser.Focus();           
        }

        private void CambiarContraxExpiracion()
        {
            DateTime dateTime = DateTime.Now;
            string current = dateTime.ToString("dd/MM/yyyy");

            if (current==Cache.FechaFinal)
            {
                MessageBox.Show("Su Contraseña expiro.",
                    "",
                    MessageBoxButtons.OK);
                frmCambioPass.ShowDialog();


            }
        }

       
    }
}
