namespace Login
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarUsuarios = new System.Windows.Forms.Button();
            this.btnCambiarContra = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarUsuarios
            // 
            this.btnAgregarUsuarios.ForeColor = System.Drawing.Color.Salmon;
            this.btnAgregarUsuarios.Location = new System.Drawing.Point(86, 47);
            this.btnAgregarUsuarios.Name = "btnAgregarUsuarios";
            this.btnAgregarUsuarios.Size = new System.Drawing.Size(100, 67);
            this.btnAgregarUsuarios.TabIndex = 0;
            this.btnAgregarUsuarios.Text = "Agregar Usuarios";
            this.btnAgregarUsuarios.UseVisualStyleBackColor = true;
            this.btnAgregarUsuarios.Click += new System.EventHandler(this.btnAgregarUsuarios_Click);
            // 
            // btnCambiarContra
            // 
            this.btnCambiarContra.ForeColor = System.Drawing.Color.Salmon;
            this.btnCambiarContra.Location = new System.Drawing.Point(86, 138);
            this.btnCambiarContra.Name = "btnCambiarContra";
            this.btnCambiarContra.Size = new System.Drawing.Size(100, 71);
            this.btnCambiarContra.TabIndex = 1;
            this.btnCambiarContra.Text = "Cambio de Contraseña";
            this.btnCambiarContra.UseVisualStyleBackColor = true;
            this.btnCambiarContra.Click += new System.EventHandler(this.btnCambiarContra_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Salmon;
            this.btnCerrarSesion.Location = new System.Drawing.Point(171, 265);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(83, 26);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Salir";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(266, 303);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnCambiarContra);
            this.Controls.Add(this.btnAgregarUsuarios);
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarUsuarios;
        private System.Windows.Forms.Button btnCambiarContra;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}