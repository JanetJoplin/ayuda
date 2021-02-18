using LaESapERP.Properties;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaESapERP.Modelo
{
    public class Conexion
    {

        private OleDbConnection conAccess;
        private SqlConnection conSQL;
        private OleDbConnection conExcel;

        public Conexion()
        {
            conAccess = null;
            conSQL = null;
            conExcel = null;
        }

        public OleDbConnection conectarAccess()
        {
            try
            {
                conAccess = new OleDbConnection(Settings.Default.ERP_PROYECTO_ConnectionStringTemporal);
                conAccess.Open();
                return conAccess;
            }
            catch (Exception)
            {
                return conAccess;
            }
        }

        public OleDbConnection conectarAccessSrv()
        {
            try
            {
                conAccess = new OleDbConnection(Settings.Default.ERP_PROYECTO_ConnectionStringDB1);
                conAccess.Open();
                return conAccess;
            }
            catch (Exception)
            {
                return conAccess;
            }
        }

        public SqlConnection conectarSQL(string empresa)
        {
            try
            {
                conSQL = new SqlConnection(empresa);
                conSQL.Open();
                return conSQL;
            }
            catch (Exception)
            {
                return conSQL;
            }
        }

        public SqlConnection conectarWINLAB_EP()
        {
            try
            {
                conSQL = new SqlConnection(Settings.Default.ERP_PROYECTO_strConex_WINLAB_EP);
                conSQL.Open();
                return conSQL;
            }
            catch (Exception)
            {
                return conSQL;
            }
        }

        public OleDbConnection conexExcel(string archivo)
        {
            try
            {
                conExcel = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;");
                conExcel.Open();
                return conExcel;

            }
            catch (Exception)
            {
                return conExcel;
            }
        }


    }



}
