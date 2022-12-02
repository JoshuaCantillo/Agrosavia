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
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();

            resetear();
        }

        public void resetear()
        {
            btagregar.Enabled = true;
            bteditar.Enabled = true;
            bteliminar.Enabled = true;

            btagregar.Checked = false;
            bteditar.Checked = false;
            bteliminar.Checked = false;

            txtbuscar.Enabled = true;

            txtcodigo.Enabled = false;
            txttitulo.Enabled = false;

            tbarticulos.Enabled = true;

            buscarArticulo("");
        }

        public void buscarArticulo(string arg)
        {
                Articulos articulos = new Articulos();
                //Asignando los datos al datagrid

                tbarticulos.DataSource = null;
                tbarticulos.DataSource = articulos.buscarArticulos(arg);

            //Ocultando las columnas inecesarias

                tbarticulos.Columns[0].Visible = false;

                int total = tbarticulos.RowCount;
                lbcontador.Text = total.ToString();

                llenar_campos(0);
        }

        public void llenar_campos(int index)
        {
            if (tbarticulos.RowCount != 0)
            {
                lbid.Text = tbarticulos.Rows[index].Cells[0].Value.ToString();
                txtcodigo.Text = tbarticulos.Rows[index].Cells[1].Value.ToString();
                txttitulo.Text = tbarticulos.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            if (btagregar.Checked == false)
            {
                txttitulo.Enabled = true;
                txtcodigo.Enabled = true;

                txtbuscar.Enabled = false;

                tbarticulos.Enabled = false;

                bteditar.Enabled = false;
                bteliminar.Enabled = false;

                btagregar.Checked = true;

                txtcodigo.Text = "";
                txttitulo.Text = "";

            }
            else
            {
                int codigo = Int32.Parse(txtcodigo.Text);
                string titulo = txttitulo.Text;

                try
                {
                    Articulos articulos = new Articulos();

                    articulos.Codigo = codigo;
                    articulos.Titulo = titulo;

                    if (articulos.agregarArticulo())
                    {
                        MessageBox.Show("Se agregó el artículo correctamente", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetear();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al agregar el artículo", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Ocurrió el siguiente error al tratar de agregar el artículo (btAgregar): " + ex);
                }
            }
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            if (bteditar.Checked == false)
            {
                txttitulo.Enabled = true;
                txtcodigo.Enabled = true;

                txtbuscar.Enabled = false;

                tbarticulos.Enabled = false;

                btagregar.Enabled = false;
                bteliminar.Enabled = false;

                bteditar.Checked = true;


            }
            else
            {
                int id = Int32.Parse(lbid.Text);
                int codigo = Int32.Parse(txtcodigo.Text);
                string titulo = txttitulo.Text;

                try
                {
                    Articulos articulos = new Articulos();

                    articulos.IdArticulo = id;
                    articulos.Codigo = codigo;
                    articulos.Titulo = titulo;

                    if (articulos.editarArticulo())
                    {
                        MessageBox.Show("Se modificó el artículo correctamente", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetear();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al modificar el artículo", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Ocurrió el siguiente error al tratar de modificar el artículo (bteditar): " + ex);
                }
            }
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            if (bteliminar.Checked == false)
            {
                txtbuscar.Enabled = false;

                tbarticulos.Enabled = false;

                btagregar.Enabled = false;
                bteditar.Enabled = false;

                bteliminar.Checked = true;


            }
            else
            {
                if ((MessageBox.Show("¿Desea eliminar el artículo?", "Agrosavia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                {
                    int id = Int32.Parse(lbid.Text);

                    try
                    {
                        Articulos articulos = new Articulos();

                        articulos.IdArticulo = id;

                        if (articulos.eliminarArticulo())
                        {
                            MessageBox.Show("Se eliminó el artículo correctamente", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetear();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al eliminar el artículo", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Console.WriteLine("Ocurrió el siguiente error al tratar de eliminar el artículo (bteliminar): " + ex);
                    }
                }
            }
        }
    }
}
