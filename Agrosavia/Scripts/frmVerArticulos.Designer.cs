namespace Agrosavia.Scripts
{
    partial class frmVerArticulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnDerecha = new Guna.UI2.WinForms.Guna2Panel();
            this.lbid = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbarticulos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btasignar = new Guna.UI2.WinForms.Guna2Button();
            this.txtbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.bteliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btpendiente = new Guna.UI2.WinForms.Guna2Button();
            this.btincumplido = new Guna.UI2.WinForms.Guna2Button();
            this.btevaluado = new Guna.UI2.WinForms.Guna2Button();
            this.pnDerecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDerecha
            // 
            this.pnDerecha.Controls.Add(this.btevaluado);
            this.pnDerecha.Controls.Add(this.btincumplido);
            this.pnDerecha.Controls.Add(this.bteliminar);
            this.pnDerecha.Controls.Add(this.btpendiente);
            this.pnDerecha.Controls.Add(this.btasignar);
            this.pnDerecha.Controls.Add(this.lbid);
            this.pnDerecha.Controls.Add(this.tbarticulos);
            this.pnDerecha.Controls.Add(this.txtbuscar);
            this.pnDerecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDerecha.Location = new System.Drawing.Point(0, 0);
            this.pnDerecha.Name = "pnDerecha";
            this.pnDerecha.Size = new System.Drawing.Size(800, 450);
            this.pnDerecha.TabIndex = 4;
            // 
            // lbid
            // 
            this.lbid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbid.BackColor = System.Drawing.Color.Transparent;
            this.lbid.Font = new System.Drawing.Font("Tisa Sans Pro Med", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(53)))));
            this.lbid.Location = new System.Drawing.Point(207, 549);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(39, 21);
            this.lbid.TabIndex = 21;
            this.lbid.Text = "####";
            this.lbid.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbid.Visible = false;
            // 
            // tbarticulos
            // 
            this.tbarticulos.AllowUserToAddRows = false;
            this.tbarticulos.AllowUserToDeleteRows = false;
            this.tbarticulos.AllowUserToOrderColumns = true;
            this.tbarticulos.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tisa Sans Pro Med", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.tbarticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.tbarticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tisa Sans Pro ExtBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbarticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.tbarticulos.ColumnHeadersHeight = 25;
            this.tbarticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tisa Sans Pro Med", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbarticulos.DefaultCellStyle = dataGridViewCellStyle15;
            this.tbarticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tbarticulos.Location = new System.Drawing.Point(15, 66);
            this.tbarticulos.Name = "tbarticulos";
            this.tbarticulos.ReadOnly = true;
            this.tbarticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbarticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.tbarticulos.RowHeadersVisible = false;
            this.tbarticulos.Size = new System.Drawing.Size(642, 340);
            this.tbarticulos.TabIndex = 1;
            this.tbarticulos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tbarticulos.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Tisa Sans Pro Med", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbarticulos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Teal;
            this.tbarticulos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Teal;
            this.tbarticulos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbarticulos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tbarticulos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tbarticulos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbarticulos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tbarticulos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tisa Sans Pro ExtBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbarticulos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tbarticulos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tbarticulos.ThemeStyle.HeaderStyle.Height = 25;
            this.tbarticulos.ThemeStyle.ReadOnly = true;
            this.tbarticulos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tbarticulos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbarticulos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tisa Sans Pro Med", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbarticulos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Teal;
            this.tbarticulos.ThemeStyle.RowsStyle.Height = 22;
            this.tbarticulos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.tbarticulos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tbarticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbarticulos_CellContentClick);
            // 
            // btasignar
            // 
            this.btasignar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btasignar.BorderRadius = 5;
            this.btasignar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btasignar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btasignar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btasignar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btasignar.FillColor = System.Drawing.Color.Lime;
            this.btasignar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btasignar.ForeColor = System.Drawing.Color.White;
            this.btasignar.Image = global::Agrosavia.Properties.Resources.icono_mas_blanco_32;
            this.btasignar.Location = new System.Drawing.Point(682, 96);
            this.btasignar.Name = "btasignar";
            this.btasignar.Size = new System.Drawing.Size(97, 32);
            this.btasignar.TabIndex = 22;
            this.btasignar.Text = "Asignar";
            this.btasignar.Click += new System.EventHandler(this.btasignar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.BorderThickness = 0;
            this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.DefaultText = "";
            this.txtbuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbuscar.FillColor = System.Drawing.SystemColors.Control;
            this.txtbuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.Font = new System.Drawing.Font("Tisa Sans Pro Med", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.ForeColor = System.Drawing.Color.Black;
            this.txtbuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.IconLeft = global::Agrosavia.Properties.Resources.icono_buscar_negro_32;
            this.txtbuscar.Location = new System.Drawing.Point(15, 16);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.PasswordChar = '\0';
            this.txtbuscar.PlaceholderText = "Buscar";
            this.txtbuscar.SelectedText = "";
            this.txtbuscar.Size = new System.Drawing.Size(642, 37);
            this.txtbuscar.TabIndex = 0;
            // 
            // bteliminar
            // 
            this.bteliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bteliminar.BorderRadius = 5;
            this.bteliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bteliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bteliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bteliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bteliminar.FillColor = System.Drawing.Color.Red;
            this.bteliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bteliminar.ForeColor = System.Drawing.Color.White;
            this.bteliminar.Image = global::Agrosavia.Properties.Resources.icono_eliminar_blanco_32;
            this.bteliminar.Location = new System.Drawing.Point(682, 316);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(97, 32);
            this.bteliminar.TabIndex = 24;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // btpendiente
            // 
            this.btpendiente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btpendiente.BorderRadius = 5;
            this.btpendiente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btpendiente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btpendiente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btpendiente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btpendiente.FillColor = System.Drawing.Color.SandyBrown;
            this.btpendiente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btpendiente.ForeColor = System.Drawing.Color.White;
            this.btpendiente.Image = global::Agrosavia.Properties.Resources.icono_lapiz_blanco_32;
            this.btpendiente.Location = new System.Drawing.Point(682, 171);
            this.btpendiente.Name = "btpendiente";
            this.btpendiente.Size = new System.Drawing.Size(97, 32);
            this.btpendiente.TabIndex = 23;
            this.btpendiente.Click += new System.EventHandler(this.btpendiente_Click);
            // 
            // btincumplido
            // 
            this.btincumplido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btincumplido.BorderRadius = 5;
            this.btincumplido.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btincumplido.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btincumplido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btincumplido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btincumplido.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btincumplido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btincumplido.ForeColor = System.Drawing.Color.White;
            this.btincumplido.Image = global::Agrosavia.Properties.Resources.icono_cancelar_blanco_32;
            this.btincumplido.Location = new System.Drawing.Point(682, 247);
            this.btincumplido.Name = "btincumplido";
            this.btincumplido.Size = new System.Drawing.Size(97, 32);
            this.btincumplido.TabIndex = 25;
            this.btincumplido.Click += new System.EventHandler(this.btincumplido_Click);
            // 
            // btevaluado
            // 
            this.btevaluado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btevaluado.BorderRadius = 5;
            this.btevaluado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btevaluado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btevaluado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btevaluado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btevaluado.FillColor = System.Drawing.Color.Teal;
            this.btevaluado.Font = new System.Drawing.Font("Tisa Sans Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btevaluado.ForeColor = System.Drawing.Color.White;
            this.btevaluado.Image = global::Agrosavia.Properties.Resources.icono_ver_blanco_32;
            this.btevaluado.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btevaluado.ImageSize = new System.Drawing.Size(22, 22);
            this.btevaluado.Location = new System.Drawing.Point(682, 209);
            this.btevaluado.Name = "btevaluado";
            this.btevaluado.Size = new System.Drawing.Size(97, 32);
            this.btevaluado.TabIndex = 26;
            this.btevaluado.Click += new System.EventHandler(this.btevaluado_Click);
            // 
            // frmVerArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnDerecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVerArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerArticulos";
            this.pnDerecha.ResumeLayout(false);
            this.pnDerecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnDerecha;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbid;
        public Guna.UI2.WinForms.Guna2DataGridView tbarticulos;
        public Guna.UI2.WinForms.Guna2TextBox txtbuscar;
        public Guna.UI2.WinForms.Guna2Button btasignar;
        public Guna.UI2.WinForms.Guna2Button bteliminar;
        public Guna.UI2.WinForms.Guna2Button btpendiente;
        public Guna.UI2.WinForms.Guna2Button btincumplido;
        public Guna.UI2.WinForms.Guna2Button btevaluado;
    }
}