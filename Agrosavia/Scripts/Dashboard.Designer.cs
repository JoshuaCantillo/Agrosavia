namespace Agrosavia
{
    partial class Dashboard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.separador = new Guna.UI2.WinForms.Guna2Separator();
            this.btpersonas = new Guna.UI2.WinForms.Guna2Button();
            this.imgLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnEscritorio = new Guna.UI2.WinForms.Guna2Panel();
            this.btarticulos = new Guna.UI2.WinForms.Guna2Button();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.White;
            this.pnMenu.Controls.Add(this.btarticulos);
            this.pnMenu.Controls.Add(this.separador);
            this.pnMenu.Controls.Add(this.btpersonas);
            this.pnMenu.Controls.Add(this.imgLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(200, 767);
            this.pnMenu.TabIndex = 0;
            // 
            // separador
            // 
            this.separador.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(53)))));
            this.separador.FillThickness = 3;
            this.separador.Location = new System.Drawing.Point(9, 61);
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(181, 10);
            this.separador.TabIndex = 1;
            // 
            // btpersonas
            // 
            this.btpersonas.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(53)))));
            this.btpersonas.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btpersonas.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btpersonas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btpersonas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btpersonas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btpersonas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btpersonas.FillColor = System.Drawing.Color.White;
            this.btpersonas.Font = new System.Drawing.Font("Tisa Sans Pro Med", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpersonas.ForeColor = System.Drawing.Color.Black;
            this.btpersonas.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(105)))));
            this.btpersonas.HoverState.ForeColor = System.Drawing.Color.White;
            this.btpersonas.HoverState.Image = global::Agrosavia.Properties.Resources.icono_personas_blanco_32;
            this.btpersonas.Image = ((System.Drawing.Image)(resources.GetObject("btpersonas.Image")));
            this.btpersonas.ImageSize = new System.Drawing.Size(32, 32);
            this.btpersonas.Location = new System.Drawing.Point(9, 77);
            this.btpersonas.Name = "btpersonas";
            this.btpersonas.Size = new System.Drawing.Size(180, 45);
            this.btpersonas.TabIndex = 1;
            this.btpersonas.Text = "PERSONAS";
            this.btpersonas.Click += new System.EventHandler(this.btpersonas_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.ImageRotate = 0F;
            this.imgLogo.Location = new System.Drawing.Point(9, 5);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(181, 66);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // pnEscritorio
            // 
            this.pnEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEscritorio.Location = new System.Drawing.Point(200, 0);
            this.pnEscritorio.Name = "pnEscritorio";
            this.pnEscritorio.Size = new System.Drawing.Size(1146, 767);
            this.pnEscritorio.TabIndex = 1;
            // 
            // btarticulos
            // 
            this.btarticulos.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(53)))));
            this.btarticulos.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btarticulos.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btarticulos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btarticulos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btarticulos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btarticulos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btarticulos.FillColor = System.Drawing.Color.White;
            this.btarticulos.Font = new System.Drawing.Font("Tisa Sans Pro Med", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btarticulos.ForeColor = System.Drawing.Color.Black;
            this.btarticulos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(105)))));
            this.btarticulos.HoverState.ForeColor = System.Drawing.Color.White;
            this.btarticulos.HoverState.Image = global::Agrosavia.Properties.Resources.icono_personas_blanco_32;
            this.btarticulos.Image = ((System.Drawing.Image)(resources.GetObject("btarticulos.Image")));
            this.btarticulos.ImageSize = new System.Drawing.Size(32, 32);
            this.btarticulos.Location = new System.Drawing.Point(9, 128);
            this.btarticulos.Name = "btarticulos";
            this.btarticulos.Size = new System.Drawing.Size(180, 45);
            this.btarticulos.TabIndex = 2;
            this.btarticulos.Text = "ARTÍCULOS";
            this.btarticulos.Click += new System.EventHandler(this.btarticulos_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1346, 767);
            this.Controls.Add(this.pnEscritorio);
            this.Controls.Add(this.pnMenu);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrosavia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMenu;
        private Guna.UI2.WinForms.Guna2Separator separador;
        private Guna.UI2.WinForms.Guna2Button btpersonas;
        private Guna.UI2.WinForms.Guna2PictureBox imgLogo;
        private Guna.UI2.WinForms.Guna2Panel pnEscritorio;
        private Guna.UI2.WinForms.Guna2Button btarticulos;
    }
}

