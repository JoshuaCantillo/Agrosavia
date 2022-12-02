using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosavia.Logic
{
    internal class Personas
    {

        #region Variables privadas

        private int _idPersona;
        private string _nombres;
        private string _filiacion;
        private string _pais;
        private string _lengua;
        private string _correo;
        private string _genero;
        private string _habilidades;
        private string _perfiles;
        private string _estado;

        #endregion


        #region Variables publicas

        public Conexion conexion = new Conexion();

        public int IdPersona { get => _idPersona; set => _idPersona = value; }
        public string Nombres { get => _nombres; set => _nombres = value; }
        public string Filiacion { get => _filiacion; set => _filiacion = value; }
        public string Pais { get => _pais; set => _pais = value; }
        public string Lengua { get => _lengua; set => _lengua = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public string Perfiles { get => _perfiles; set => _perfiles = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Habilidades { get => _habilidades; set => _habilidades = value; }


        #endregion

        #region Constructores

        public Personas(int idPersona, string nombres, string filiacion, string pais, string lengua, string correo, string genero, string perfiles, string estado, string habilidades)
        {
            IdPersona = idPersona;
            Nombres = nombres;
            Filiacion = filiacion;
            Pais = pais;
            Lengua = lengua;
            Correo = correo;
            Genero = genero;
            Perfiles = perfiles;
            Estado = estado;
            Habilidades = habilidades;
        }

        public Personas()
        {
        }

        #endregion


        #region Metodos publicos

        public DataTable buscarPersonas(string arg)
        {
            DataTable tabla = new DataTable();

            // Diseño de la cabecera

            tabla.Columns.Add("IdPersona", typeof(string));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Filiación", typeof(string));
            tabla.Columns.Add("País", typeof(string));
            tabla.Columns.Add("Lengua", typeof(string));
            tabla.Columns.Add("E-Mail", typeof(string));
            tabla.Columns.Add("Genero", typeof(string));
            tabla.Columns.Add("Habilidades/Intereses", typeof(string));
            tabla.Columns.Add("Perfiles", typeof(string));
            tabla.Columns.Add("Estado", typeof(string));

            try
            {
                SqlCommand sql = new SqlCommand(String.Format("SELECT * FROM personas WHERE nombres like '%" + arg + "%' or  filiacion like '%" + arg + "%' or correo like '%" + arg + "%' or  habilidades like '%" + arg + "%' or estado like '%" + arg + "%' or perfiles like '%" + arg + "%'"),conexion.conectar());
                SqlDataReader dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    tabla.Rows.Add(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8), dr.GetString(9));
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Se produjo el siguiente error en la clase Personas al tratar de llenar la tabla: "+ ex);
            }

            return tabla;
        }


        public bool agregarPersona()
        {
            bool respuesta = false;

            try
            {
                SqlCommand sql = new SqlCommand(String.Format("INSERT INTO personas (nombres,filiacion,pais,lengua,correo,genero,habilidades,perfiles,estado) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",Nombres.ToUpper(),Filiacion.ToUpper(),Pais.ToUpper(),Lengua.ToUpper(),Correo,Genero.ToUpper(),Habilidades,Perfiles,Estado.ToUpper()), conexion.conectar());
                if (sql.ExecuteNonQuery() != 0)
                {
                    respuesta = true;
                }            
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Se produjo el siguiente error en la clase Personas al tratar de agregar una persona: "+ ex);
            }

            return respuesta;
        }

        public bool editarPersona()
        {
            bool respuesta = false;

            try
            {
                SqlCommand sql = new SqlCommand(String.Format("UPDATE personas SET nombres='{0}',filiacion='{1}',pais='{2}',lengua='{3}',correo='{4}',genero='{5}',habilidades='{6}',perfiles='{7}',estado='{8}' WHERE idpersona='{9}'",Nombres.ToUpper(), Filiacion.ToUpper(), Pais.ToUpper(), Lengua.ToUpper(), Correo, Genero.ToUpper(), Habilidades, Perfiles, Estado.ToUpper(),IdPersona), conexion.conectar());
                if (sql.ExecuteNonQuery() != 0)
                {
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Se produjo el siguiente error en la clase Personas al tratar de editar una persona: "+ ex);
            }

            return respuesta;
        }

        public bool eliminarPersona()
        {
            bool respuesta = false;

            try
            {
                SqlCommand sql = new SqlCommand(String.Format("DELETE FROM personas WHERE idpersona='{0}'",IdPersona), conexion.conectar());
                if (sql.ExecuteNonQuery() != 0)
                {
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Se produjo el siguiente error en la clase Personas al tratar de eliminar una persona: "+ ex);
            }

            return respuesta;
        }

        #endregion


    }
}
