using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosavia.Logic
{
    public class Conexion
    {

        public SqlConnection conexion;
        public string mensajeError;
        public SqlConnection conectar()
        {
            try
            {
                string cadenaConexion = "Data Source=.;Initial Catalog=agrosavia;Integrated Security=True";
                conexion = new SqlConnection();
                conexion.ConnectionString = cadenaConexion;
                validarConexion();
            }
            catch (System.Exception ex)
            {
                mensajeError = ex.Message.ToString();
            }
            return conexion;
        }
        public void validarConexion()
        {
            if (conexion.State.Equals(ConnectionState.Open))
            {
                cerrarConexion();
            }
            else
            {
                abrirConexion();
            }
        }
        public void abrirConexion()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Error al abrir la conexion " + ex.Message.ToString());
                mensajeError = ex.Message.ToString();
            }
        }

        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
                conexion.Dispose();
                Console.WriteLine("Conexion cerrada");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexion " + ex.Message.ToString());
                mensajeError = ex.Message.ToString();
            }
        }

    }
}
