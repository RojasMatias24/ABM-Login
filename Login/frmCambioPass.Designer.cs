namespace Login
{
    partial class frmCambioPass
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.txtNConfirContraseña = new System.Windows.Forms.TextBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pctVerPass = new FontAwesome.Sharp.IconButton();
            this.icnMirar2 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Turquoise;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(50, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cambio de Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña Actual\r\n";
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.Location = new System.Drawing.Point(12, 114);
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.Size = new System.Drawing.Size(167, 20);
            this.txtContraseña2.TabIndex = 10;
            this.txtContraseña2.TextChanged += new System.EventHandler(this.txtContraseña2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nueva Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(12, 184);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(167, 20);
            this.txtNuevaContraseña.TabIndex = 13;
            this.txtNuevaContraseña.TextChanged += new System.EventHandler(this.txtNuevaContraseña_TextChanged);
            // 
            // txtNConfirContraseña
            // 
            this.txtNConfirContraseña.Location = new System.Drawing.Point(12, 255);
            this.txtNConfirContraseña.Name = "txtNConfirContraseña";
            this.txtNConfirContraseña.Size = new System.Drawing.Size(167, 20);
            this.txtNConfirContraseña.TabIndex = 14;
            this.txtNConfirContraseña.TextChanged += new System.EventHandler(this.txtNConfirContraseña_TextChanged);
            // 
            // btnCambiar
            // 
            this.btnCambiar.ForeColor = System.Drawing.Color.Salmon;
            this.btnCambiar.Location = new System.Drawing.Point(67, 295);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 15;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(-3, -14);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(230, 80);
            this.panel1.TabIndex = 16;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Turquoise;
            this.iconPictureBox1.ErrorImage = null;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(104, 22);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 9;
            this.iconPictureBox1.TabStop = false;
            // 
            // pctVerPass
            // 
            this.pctVerPass.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pctVerPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctVerPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pctVerPass.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.pctVerPass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.pctVerPass.IconColor = System.Drawing.Color.Black;
            this.pctVerPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pctVerPass.IconSize = 22;
            this.pctVerPass.Location = new System.Drawing.Point(185, 109);
            this.pctVerPass.Name = "pctVerPass";
            this.pctVerPass.Size = new System.Drawing.Size(35, 28);
            this.pctVerPass.TabIndex = 17;
            this.pctVerPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pctVerPass.UseVisualStyleBackColor = false;
            this.pctVerPass.Click += new System.EventHandler(this.pctVerPass_Click);
            // 
            // icnMirar2
            // 
            this.icnMirar2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.icnMirar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icnMirar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnMirar2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.icnMirar2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.icnMirar2.IconColor = System.Drawing.Color.Black;
            this.icnMirar2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnMirar2.IconSize = 22;
            this.icnMirar2.Location = new System.Drawing.Point(185, 184);
            this.icnMirar2.Name = "icnMirar2";
            this.icnMirar2.Size = new System.Drawing.Size(35, 28);
            this.icnMirar2.TabIndex = 18;
            this.icnMirar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.icnMirar2.UseVisualStyleBackColor = false;
            this.icnMirar2.Click += new System.EventHandler(this.icnMirar2_Click);
            // 
            // frmCambioPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(221, 330);
            this.Controls.Add(this.icnMirar2);
            this.Controls.Add(this.pctVerPass);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.txtNConfirContraseña);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseña2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.Name = "frmCambioPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.TextBox txtNConfirContraseña;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton pctVerPass;
        private FontAwesome.Sharp.IconButton icnMirar2;
    }
}