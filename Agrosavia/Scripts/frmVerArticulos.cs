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
    public partial class frmVerArticulos : Form
    {

        public int idPersona;
        public int idArticulo;
        public frmVerArticulos()
        {
            InitializeComponent();
        }


        public void buscarArticulos(string arg)
        {
            Articulos articulos = new Articulos();
            //Asignando los datos al datagrid

            tbarticulos.DataSource = null;
            tbarticulos.DataSource = articulos.buscarArticulos(arg);

            //Ocultando las columnas inecesarias

            tbarticulos.Columns[0].Visible = false;

            btpendiente.Enabled = false;
            btincumplido.Enabled = false;
            btevaluado.Enabled = false;
            bteliminar.Enabled = false;

            if (tbarticulos.Rows.Count != 0)
            {
                idArticulo = Int32.Parse(tbarticulos.Rows[0].Cells[0].Value.ToString());
                btasignar.Enabled = true;
            }
            else
            {
                btasignar.Enabled=false;
            }
        }


        public void buscarSubPeronas(string arg)
        {
            subPersonas subpersonas = new subPersonas();
            //Asignando los datos al datagrid

            tbarticulos.DataSource = null;
            tbarticulos.DataSource = subpersonas.buscarSubPersonas(arg);

            //Ocultando las columnas inecesarias

            tbarticulos.Columns[0].Visible = false;

            if (tbarticulos.Rows.Count!=0)
            {
                idArticulo = Int32.Parse(tbarticulos.Rows[0].Cells[0].Value.ToString());

                txtbuscar.Enabled = false;

                btasignar.Enabled = false;
                bteliminar.Enabled = true;
                btpendiente.Enabled = true;
                btevaluado.Enabled = true;
                btincumplido.Enabled = true;
                bteliminar.Enabled = true;
            }
            else
            {
                txtbuscar.Enabled = false;

                btasignar.Enabled = false;
                btpendiente.Enabled = false;
                bteliminar.Enabled = false;
                btevaluado.Enabled = false;
                btincumplido.Enabled = false;
                bteliminar.Enabled = false;
            }
        }

        private void btpendiente_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Cambiar el estado del artículo a PENDIENTE por evaluar?", "Agrosavia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                try
                {
                    subPersonas subpersonas = new subPersonas();

                    subpersonas.Idpersona = idPersona;
                    subpersonas.Idarticulo = idArticulo;
                    subpersonas.Estado = "PENDIENTE";

                    if (subpersonas.editarEstado())
                    {
                        MessageBox.Show("Se modificó el estado correctamente", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buscarSubPeronas("");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al tratar de modificar el estado", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Se produjo un error al tratar de cambiar el estado de un articulo en frmVerArticulos btpendiente : " + ex);
                }
            }
        }

        private void tbarticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idArticulo = Int32.Parse(tbarticulos.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btevaluado_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Cambiar el estado del artículo a EVALUADO ?", "Agrosavia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                try
                {
                    subPersonas subpersonas = new subPersonas();


                    subpersonas.Idpersona = idPersona;
                    subpersonas.Idarticulo = idArticulo;
                    subpersonas.Estado = "EVALUADO";

                    if (subpersonas.editarEstado())
                    {
                        MessageBox.Show("Se modificó el estado correctamente", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buscarSubPeronas("");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al tratar de modificar el estado", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Se produjo un error al tratar de cambiar el estado de un articulo en frmVerArticulos btpendiente : " + ex);
                }
            }
        }

        private void btincumplido_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Cambiar el estado del artículo a INCUMPLIDO?", "Agrosavia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                try
                {
                    subPersonas subpersonas = new subPersonas();

                    subpersonas.Idpersona = idPersona;
                    subpersonas.Idarticulo = idArticulo;
                    subpersonas.Estado = "INCUMPLIDO";

                    if (subpersonas.editarEstado())
                    {
                        MessageBox.Show("Se modificó el estado correctamente", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buscarSubPeronas("");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al tratar de modificar el estado", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Se produjo un error al tratar de cambiar el estado de un articulo en frmVerArticulos btpendiente : " + ex);
                }
            }
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Está seguro que desea ELIMINAR la asignación de este artículo?", "Agrosavia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                try
                {
                    subPersonas subpersonas = new subPersonas();
                    subpersonas.Idpersona = idPersona;
                    subpersonas.Idarticulo = idArticulo;

                    if (subpersonas.eliminarArticulo())
                    {
                        MessageBox.Show("Se desasignó el artículo correctamente", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buscarSubPeronas("");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al tratar de eliminar el articulo", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Se produjo un error al tratar de eliminar el articulo en frmVerArticulos bteliminar : " + ex);
                }
            }
        }

        private void btasignar_Click(object sender, EventArgs e)
        {
            if (tbarticulos.Rows.Count!=0)
            {
                try
                {
                    subPersonas sub = new subPersonas();

                    sub.Idarticulo = idArticulo;
                    sub.Idpersona = idPersona;
                    sub.Estado = "PENDIENTE";

                    if (sub.asignarArticulo())
                    {
                        MessageBox.Show("Se asignó el artículo correctamente", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buscarSubPeronas(idPersona.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al tratar de asignar el articulo", "Agrosavia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Se produjo un error al tratar de asignar el articulo en frmVerArticulos btasignar : " + ex);
                }

            }
        }
    }
}
