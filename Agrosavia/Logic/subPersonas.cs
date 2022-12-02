using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosavia.Logic
{
    internal class subPersonas
    {
        #region Variables privadas

        private int _idarticulo;
        private int _idpersona;
        private string _estado;

        #endregion

        #region Variables publicas

        public Conexion conexion = new Conexion();
        public int Idarticulo { get => _idarticulo; set => _idarticulo = value; }
        public int Idpersona { get => _idpersona; set => _idpersona = value; }
        public string Estado { get => _estado; set => _estado = value; }



        #endregion

        #region Constructores

        public subPersonas(int idarticulo, int idpersona, string estado)
        {
            Idarticulo = idarticulo;
            Idpersona = idpersona;
            Estado = estado;
        }

        public subPersonas()
        {

        }

        #endregion


        #region Metodos

        public DataTable buscarSubPersonas(string arg)
        {
            DataTable tabla = new DataTable();

            tabla.Columns.Add("IdArticulo", typeof(string));
            tabla.Columns.Add("Código", typeof(string));
            tabla.Columns.Add("Título", typeof(string));
            tabla.Columns.Add("Estado", typeof(string));

            try
            {
                SqlCommand sql = new SqlCommand(String.Format("SELECT A.*, S.estado FROM articulos as A INNER JOIN subpersonas as S on A.idarticulo=S.idarticulo WHERE S.idpersona like '%"+arg+"%' order by A.codigo ASC"), conexion.conectar());
                SqlDataReader dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    tabla.Rows.Add(dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetString(3));
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Se produjo el siguiente error en la clase subPersonas al tratar de llenar la tabla: " + ex);
            }

            return tabla;
        }

        public bool asignarArticulo()
        {
            bool respuesta = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("INSERT INTO subpersonas(idpersona,idarticulo,estado) values('{0}','{1}','{2}')", Idpersona, Idarticulo,Estado), conexion.conectar());
                if (sql.ExecuteNonQuery() != 0)
                {
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Se produjo el siguiente error en la clase subPersonas al tratar de asignar un articulo: " + ex);
            }

            return respuesta;
        }


        public bool editarEstado()
        {
            bool respuesta = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("UPDATE subpersonas SET estado='{0}' WHERE idpersona='{1}' and idarticulo='{2}'",Estado,Idpersona,Idarticulo), conexion.conectar());
                if (sql.ExecuteNonQuery() != 0)
                {
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Se produjo el siguiente error en la clase subPersonas al tratar de editar un articulo: " + ex);
            }

            return respuesta;
        }



        public bool eliminarArticulo()
        {
            bool respuesta = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("DELETE FROM subpersonas WHERE idpersona='{0}' and idarticulo='{1}'", Idpersona, Idarticulo), conexion.conectar());
                if (sql.ExecuteNonQuery() != 0)
                {
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Se produjo el siguiente error en la clase subPersonas al tratar de eliminar un articulo: " + ex);
            }

            return respuesta;
        }
        #endregion

    }
}
