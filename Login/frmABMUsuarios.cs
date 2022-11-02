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

namespace Login
{
    public partial class frmABMUsuarios : Form
    {
        CN_ABM ABMC = new CN_ABM();
        private string idUsuario=null;
        private bool Editar = false;


        public frmABMUsuarios()
        {
            InitializeComponent();
            
        }
        private void frmABMUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUser();
            fecha();
            FechaLimite();
            cargarcombo();
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void MostrarUser()
        {
            CN_ABM ABM = new CN_ABM();
            dtgUsuarios.DataSource = ABM.MostrarUsers();
           dtgUsuarios.Rows[0].Selected = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(Editar==false)
            {
                if (string.IsNullOrEmpty(txtUser.Text.Trim()) || string.IsNullOrEmpty(txtPass.Text.Trim()) ||
              string.IsNullOrEmpty(txtNombre.Text.Trim()) || string.IsNullOrEmpty(txtApellido.Text.Trim()) ||
              string.IsNullOrEmpty(txtEmail.Text.Trim()) || string.IsNullOrEmpty(txtFecha.Text.Trim()) ||
              string.IsNullOrEmpty(txtFechaLimite.Text.Trim()) || string.IsNullOrEmpty(cmbEstado.Text.Trim()))
                {
                    MessageBox.Show("Uno de los campos esta vacio",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    ABMC.AgregarUsuario(txtUser.Text, txtPass.Text, txtNombre.Text,
                   txtApellido.Text, txtEmail.Text, txtFecha.Text, txtFechaLimite.Text,
                   cmbEstado.Text);
                    limpiearbtn();
                    MostrarUser();
                }
            }
            if(Editar == true)
            {
                ABMC.EditarUsuario(txtUser.Text, txtNombre.Text,
                   txtApellido.Text, txtEmail.Text, cmbEstado.Text, idUsuario);
                MostrarUser();
                limpiearbtn();
                Editar = false;
            }

                
            
           
        }
        private void limpiearbtn()
        {
            txtUser.Clear();
            txtPass.Clear();
            txtNombre.Clear();
            txtFecha.Clear();
            txtFechaLimite.Clear();
            cmbEstado.SelectedIndex = -1;
            txtEmail.Clear();
            txtApellido.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dtgUsuarios.SelectedRows.Count > 0)
            {
                Editar = true;
                txtUser.Text = dtgUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                txtNombre.Text= dtgUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text= dtgUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
                txtEmail.Text= dtgUsuarios.CurrentRow.Cells["Email"].Value.ToString();
                cmbEstado.Text= dtgUsuarios.CurrentRow.Cells["Estado"].Value.ToString();
                idUsuario= dtgUsuarios.CurrentRow.Cells["ID_Usuario"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila a editar",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgUsuarios.SelectedRows.Count > 0)
            {
                idUsuario= dtgUsuarios.CurrentRow.Cells["ID_Usuario"].Value.ToString();
                ABMC.EliminarUsuario(idUsuario);
                MessageBox.Show("Se elimino correctamente");
                MostrarUser();
            }
            else
            {
                MessageBox.Show("Seleccione la fila a editar",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
            }
        }

       private void fecha()
       {
            DateTime today = DateTime.Now;
            txtFecha.Text = today.ToString("dd/MM/yyyy");
       }

        private void FechaLimite()
        {
            DateTime hoy = DateTime.Now;
            hoy= hoy.AddDays(30);
            txtFechaLimite.Text = hoy.ToString("dd/MM/yyyy");
        }

       private void cargarcombo()
        {
            cmbEstado.Items.Add("Desbloqueado");
            cmbEstado.Items.Add("Bloqueado");
        }

        

       
    }
}
