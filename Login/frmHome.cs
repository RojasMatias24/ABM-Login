using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta seguro de salir?",
                "Close",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            this.Close();
        }

        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            frmABMUsuarios frmUsuarios=new frmABMUsuarios();
            frmUsuarios.ShowDialog();
            
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            frmCambioPass frmCambioClave = new frmCambioPass();
            frmCambioClave.ShowDialog();
            
        }
    }
}
