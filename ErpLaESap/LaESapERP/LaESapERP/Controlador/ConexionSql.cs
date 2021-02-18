using LaESapERP.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaESapERP.Controlador
{
    public class ConexionSQL
    {

        SqlConnection Conexion;

        public ConexionSQL()
        {
            Conexion = null;
        }

        public SqlConnection getConexion()
        {
            try
            {
                Conexion = new SqlConnection(Settings.Default.ERP_PROYECTO_ConnectionStringDB1);
                Conexion.Open();
                return Conexion;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public SqlConnection getCadenaConexion()
        {
            try
            {
                Conexion = new SqlConnection(Settings.Default.ERP_PROYECTO_ConnectionStringDB1);
                return Conexion;
            }
            catch (Exception ex)
            {
                return null;
            }
        }



    }
}
