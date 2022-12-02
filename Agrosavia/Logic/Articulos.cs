using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosavia.Logic
{
    internal class Articulos
    {
        #region Variables privadas

        private int _idArticulo;
        private int _codigo;
        private string _titulo;

        #endregion

        #region Variables publicas

        public Conexion conexion = new Conexion();
        public int IdArticulo { get => _idArticulo; set => _idArticulo = value; }
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }


        #endregion

        #region Constructores

        public Articulos(int idArticulo, int codigo, string titulo)
        {
            IdArticulo = idArticulo;
            Codigo = codigo;
            Titulo = titulo;
        }

        public Articulos()
        {
        }

        #endregion


        #region Metodos

        public DataTable buscarArticulos(string arg)
        {
            DataTable tabla = new DataTable();

            tabla.Columns.Add("IdArticulo", typeof(string));
            tabla.Columns.Add("Código", typeof(string));
            tabla.Columns.Add("Título", typeof(string));

            try
            {
                SqlCommand sql = new SqlCommand(String.Format("SELECT * FROM articulos WHERE codigo like '%"+arg+"%' or titulo like '%"+arg+"%'"), conexion.conectar());
                SqlDataReader dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    tabla.Rows.Add(dr.GetInt32(0),dr.GetInt32(1),dr.GetString(2));
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Se produjo el siguiente error en la clase Articulos al tratar de llenar la tabla: " + ex);
            }

            return tabla;
        }


        public bool agregarArticulo()
        {
            bool respuesta = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("INSERT INTO articulos (codigo,titulo) values('{0}','{1}')", Codigo,Titulo), conexion.conectar());
                if (sql.ExecuteNonQuery()!=0)
                {
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Se produjo el siguiente error en la clase Articulos al tratar de agregar un articulo: " + ex);
            }

            return respuesta;
        }

        public bool editarArticulo()
        {
            bool respuesta = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("UPDATE articulos SET codigo='{0}',titulo='{1}' WHERE idarticulo='{2}'", Codigo, Titulo,IdArticulo), conexion.conectar());
                if (sql.ExecuteNonQuery() != 0)
                {
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Se produjo el siguiente error en la clase Articulos al tratar de editar un articulo: " + ex);
            }

            return respuesta;
        }

        public bool eliminarArticulo()
        {
            bool respuesta = false;

            try
            {
                SqlCommand sql = new SqlCommand(string.Format("DELETE FROM articulos WHERE idarticulo='{0}'", IdArticulo), conexion.conectar());
                if (sql.ExecuteNonQuery() != 0)
                {
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Se produjo el siguiente error en la clase Articulos al tratar de agregar un articulo: " + ex);
            }

            return respuesta;
        }
        #endregion

    }
}
