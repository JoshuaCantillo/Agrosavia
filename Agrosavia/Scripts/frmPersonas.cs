using Agrosavia.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrosavia.Scripts
{
    public partial class frmPersonas : Form
    {
        public frmPersonas()
        {
            InitializeComponent();

            resetear();
        }

        public void resetear()
        {
            buscarPersonas("");

            btagregar.Checked = false;
            bteditar.Checked = false;
            bteliminar.Checked = false;

            btagregar.Enabled = true;
            bteditar.Enabled = true;
            bteliminar.Enabled = true;
            btarticulos.Enabled = true;

            txtbuscar.Enabled = true;
            tbpersonas.Enabled = true;

            txtnombres.Enabled = false;
            txtfiliacion.Enabled = false;
            txtpais.Enabled = false;
            cblengua.Enabled = false;
            txtcorreo.Enabled = false;
            cbgenero.Enabled = false;
            txthabilidades.Enabled = false;
            txtperfiles.Enabled = false;
            cbestado.Enabled = false;

            txtbuscar.Text = "";

            buscarPersonas("");
        }

       public void buscarPersonas(string arg)
        {
            Personas personas = new Personas();
            //Asignando los datos al datagrid

            tbpersonas.DataSource = null;
            tbpersonas.DataSource = personas.buscarPersonas(arg);

            //Ocultando las columnas inecesarias

            tbpersonas.Columns[0].Visible = false;
            tbpersonas.Columns[5].Visible = false;
            tbpersonas.Columns[7].Visible = false;
            tbpersonas.Columns[8].Visible = false;

            int total = tbpersonas.RowCount;
            lbcontador.Text = total.ToString();

            llenar_campos(0);
        }

        public void llenar_campos(int index)
        {
            if (tbpersonas.RowCount != 0)
            {
                lbid.Text = tbpersonas.Rows[index].Cells[0].Value.ToString();
                txtnombres.Text = tbpersonas.Rows[index].Cells[1].Value.ToString();
                txtfiliacion.Text = tbpersonas.Rows[index].Cells[2].Value.ToString();
                txtpais.Text = tbpersonas.Rows[index].Cells[3].Value.ToString();
                cblengua.Text = tbpersonas.Rows[index].Cells[4].Value.ToString();
                txtcorreo.Text = tbpersonas.Rows[index].Cells[5].Value.ToString();
                cbgenero.Text = tbpersonas.Rows[index].Cells[6].Value.ToString();
                txthabilidades.Text = tbpersonas.Rows[index].Cells[7].Value.ToString();
                txtperfiles.Text = tbpersonas.Rows[index].Cells[8].Value.ToString();
                cbestado.Text = tbpersonas.Rows[index].Cells[9].Value.ToString();
            }
        }


        private void btcancelar_Click(object sender, EventArgs e)
        {
            resetear();
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            if (btagregar.Checked==false)
            {
                txtnombres.Enabled = true;
                txtfiliacion.Enabled = true;
                txtpais.Enabled = true;
                cblengua.Enabled = true;
                txtcorreo.Enabled = true;
                cbgenero.Enabled = true;
                txthabilidades.Enabled = true;
                txtperfiles.Enabled = true;
                cbestado.Enabled = true;

                btagregar.Checked = true;

                bteditar.Enabled = false;
                bteliminar.Enabled = false;
                btarticulos.Enabled = false;

                tbpersonas.Enabled = false;
                txtbuscar.Enabled = false;

            }
            else
            {

                string nombre = txtnombres.Text;
                string filiacion = txtfiliacion.Text;
                string pais = txtpais.Text;
                string lengua = cblengua.SelectedItem.ToString();
                string correo = txtcorreo.Text;
                string genero = cbgenero.SelectedItem.ToString();
                string habilidades = txthabilidades.Text;
                string perfiles = txtperfiles.Text;
                string estado = cbestado.SelectedItem.ToString();

                try
                {
                    Personas personas = new Personas();

                    personas.Nombres = nombre;
                    personas.Filiacion = filiacion;
                    personas.Pais = pais;
                    personas.Lengua = lengua;
                    personas.Correo = correo;
                    personas.Genero = genero;
                    personas.Habilidades = habilidades;
                    personas.Perfiles = perfiles;
                    personas.Estado = estado;

                    if (personas.agregarPersona())
                    {
                        MessageBox.Show("Se agregó la persona correctamente", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetear();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al agregar la persona, por favor intente nuevamente", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Ocurrió un error al tratar de agregar una persona (frmPersonas) btagregar: "+ex);
                }
            }
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            if (bteditar.Checked == false)
            {
                txtnombres.Enabled = true;
                txtfiliacion.Enabled = true;
                txtpais.Enabled = true;
                cblengua.Enabled = true;
                txtcorreo.Enabled = true;
                cbgenero.Enabled = true;
                txthabilidades.Enabled = true;
                txtperfiles.Enabled = true;
                cbestado.Enabled = true;

                bteditar.Checked = true;

                btagregar.Enabled = false;
                bteliminar.Enabled = false;
                btarticulos.Enabled = false;

                tbpersonas.Enabled = false;
                txtbuscar.Enabled = false;

            }
            else
            {
                Int32 id = Int32.Parse(lbid.Text);
                string nombre = txtnombres.Text;
                string filiacion = txtfiliacion.Text;
                string pais = txtpais.Text;
                string lengua = cblengua.SelectedItem.ToString();
                string correo = txtcorreo.Text;
                string genero = cbgenero.SelectedItem.ToString();
                string habilidades = txthabilidades.Text;
                string perfiles = txtperfiles.Text;
                string estado = cbestado.SelectedItem.ToString();

                try
                {
                    Personas personas = new Personas();

                    personas.IdPersona = id;
                    personas.Nombres = nombre;
                    personas.Filiacion = filiacion;
                    personas.Pais = pais;
                    personas.Lengua = lengua;
                    personas.Correo = correo;
                    personas.Genero = genero;
                    personas.Habilidades = habilidades;
                    personas.Perfiles = perfiles;
                    personas.Estado = estado;

                    if (personas.editarPersona())
                    {
                        MessageBox.Show("Se editó la persona correctamente", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetear();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al editar la persona, por favor intente nuevamente", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Ocurrió un error al tratar de editar una persona (frmPersonas) bteditar: "+ex);
                }
            }
        }

        private void tbpersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenar_campos(e.RowIndex);
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            if (bteliminar.Checked == false)
            {

                bteliminar.Checked = true;

                btagregar.Enabled = false;
                bteditar.Enabled = false;
                btarticulos.Enabled = false;

                tbpersonas.Enabled = false;
                txtbuscar.Enabled = false;
            }
            else
            {
                if ((MessageBox.Show("¿Desea eliminar la persona?", "Agrosavia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) )
                {
                    try
                    {
                        Personas personas = new Personas();

                        personas.IdPersona = Int32.Parse(lbid.Text);

                        if (personas.eliminarPersona())
                        {
                            MessageBox.Show("Se eliminó la persona correctamente", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetear();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al eliminar la persona, por favor intente nuevamente", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Console.WriteLine("Ocurrió un error al tratar de eliminar una persona (frmPersonas) bteliminar: /n "+ ex);
                    }
                }
            }
        }

        private void btarticulos_Click(object sender, EventArgs e)
        {
            frmVerArticulos verArticulos = new frmVerArticulos();
            AddOwnedForm(verArticulos);

            

            verArticulos.idPersona = Int32.Parse(lbid.Text);

            verArticulos.buscarSubPeronas(lbid.Text);


            verArticulos.ShowDialog();
        }

        private void btasignar_Click(object sender, EventArgs e)
        {
            frmVerArticulos verArticulos = new frmVerArticulos();
            AddOwnedForm(verArticulos);



            verArticulos.idPersona = Int32.Parse(lbid.Text);

            verArticulos.buscarArticulos("");


            verArticulos.ShowDialog();
        }
    }
}
