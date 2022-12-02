using Agrosavia.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrosavia
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void resetearBotones()
        {
            btpersonas.Checked = false;
            btarticulos.Checked = false;
        }

        public void abrirForm(object frm)
        {
            if (this.pnEscritorio.Controls.Count > 0)
            {
                this.pnEscritorio.Controls.RemoveAt(0);
                Form sub = frm as Form;
                sub.TopLevel = false;
                sub.Dock = DockStyle.Fill;
                this.pnEscritorio.Controls.Add(sub);
                this.pnEscritorio.Tag = sub;
                sub.Show();
            }
            else
            {
                Form sub = frm as Form;
                sub.TopLevel = false;
                sub.Dock = DockStyle.Fill;
                this.pnEscritorio.Controls.Add(sub);
                this.pnEscritorio.Tag = sub;
                sub.Show();
            }
        }

            private void btpersonas_Click(object sender, EventArgs e)
        {
            resetearBotones();
            btpersonas.Checked = true;
            abrirForm(new frmPersonas());
        }

        private void btarticulos_Click(object sender, EventArgs e)
        {
            resetearBotones();
            btarticulos.Checked = true;
            abrirForm(new frmArticulos());
        }
    }
}
