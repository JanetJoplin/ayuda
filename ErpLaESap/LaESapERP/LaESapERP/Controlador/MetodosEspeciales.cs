using LaESapERP.Controlador;
using LaESapERP.Properties;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;
using System.Reflection;

public static class SpecialMethods
{

    public static void DoubleBuffered(this DataGridView dgv, bool setting)
    {
        Type dgvType = dgv.GetType();
        PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
        pi.SetValue(dgv, setting, null);
    }

    public static IEnumerable<Control> GetAllControls(Control aControl)
    {
        Stack<Control> stack = new Stack<Control>();

        stack.Push(aControl);

        while (stack.Any())
        {
            var nextControl = stack.Pop();

            foreach (Control childControl in nextControl.Controls)
            {
                stack.Push(childControl);
            }

            yield return nextControl;
        }
    }

    public static void Titulo(Form f, string ModuloNombre)
    {
        f.Text = Settings.Default.ERP_PROYECTO_NOMBRE + " - [ "+  ModuloNombre +" ] - ";
        if (!Settings.Default.ERP_PROYECTO_PRODUCTION)
        {
            f.Text += " (test environment)";
        }
        f.Update();
    }

    public static void xEquiposUpdate()
    {
        string sSql;

    
        

        using (SqlConnection SQLcnn = new SqlConnection(Settings.Default.ERP_PROYECTO_ConnectionStringDB1))
        {
            SQLcnn.Open();


            sSql = "UPDATE t1 SET   t1.NombreUsuario = t2.Nombre FROM equipo t1 INNER JOIN Usuario t2 ON  t1.UsuarioId=t2.Id WHERE  t1.UsuarioId > 0  ";
            SqlCommand SQLcmd = new SqlCommand()
            {
                Connection = SQLcnn,                CommandText = sSql,                CommandType = System.Data.CommandType.Text
            };
            SQLcmd.ExecuteNonQuery();

            sSql = "UPDATE t1 SET   t1.MarcaCPU= t2.Nombre FROM equipo t1 INNER JOIN Marca t2 ON  t1.MarcaId=t2.Id WHERE  t1.MarcaId > 0  ";
            SqlCommand SQLcmdMarcas = new SqlCommand()
            {
                Connection = SQLcnn,                CommandText = sSql,                CommandType = System.Data.CommandType.Text
            };
            SQLcmdMarcas.ExecuteNonQuery();

            sSql = "UPDATE t1 SET   t1.Departamento = t2.Nombre FROM equipo t1 INNER JOIN Departamento t2 ON  t1.DepartamentoId=t2.Id  WHERE t1.DepartamentoId > 0  ";
            SqlCommand SQLcmd5 = new SqlCommand()
            {
                Connection = SQLcnn,                 CommandText = sSql,                 CommandType = System.Data.CommandType.Text
            };
            SQLcmd5.ExecuteNonQuery();




            sSql = "UPDATE equipo SET DiasDeVida=DATEDIFF(day,  [FechaAdquisicion], GETDATE()  )  WHERE  year([FechaAdquisicion]) > 0  ";
            SqlCommand SQLcmd2 = new SqlCommand()
            {
                Connection = SQLcnn, CommandText = sSql, CommandType = System.Data.CommandType.Text
            };
            SQLcmd2.ExecuteNonQuery();


            sSql = "UPDATE equipo SET [AñosDeVida]=(DiasDeVida/365)  WHERE  DiasDeVida > 0  ";
            SqlCommand SQLcmd22 = new SqlCommand()
            {
                Connection = SQLcnn,
                CommandText = sSql,
                CommandType = System.Data.CommandType.Text
            };
            SQLcmd22.ExecuteNonQuery();


            sSql = "UPDATE equipo SET [Condiciones]='ACEPTABLES CONDICIONES'  WHERE  AñosDeVida <= 1 ";
            SqlCommand SQLcmdCondicion1 = new SqlCommand()
            {
                Connection = SQLcnn,                 CommandText = sSql,                 CommandType = System.Data.CommandType.Text
            };
            SQLcmdCondicion1.ExecuteNonQuery();

            sSql = "UPDATE equipo SET [Condiciones]='REGULAR (ALGUN DESGASTE)'  WHERE AñosDeVida>=2 AND  AñosDeVida <= 4 ";
            SqlCommand SQLcmdCondicion2 = new SqlCommand()
            {
                Connection = SQLcnn,                 CommandText = sSql,                 CommandType = System.Data.CommandType.Text
            };
            SQLcmdCondicion2.ExecuteNonQuery();


            sSql = "UPDATE equipo SET [Condiciones]='MALAS CONDICIONES (REQUIERE ACCION INMEDIATA)'  WHERE AñosDeVida >=5  ";
            SqlCommand SQLcmdCondicionesMalas = new SqlCommand()
            {
                Connection = SQLcnn,                CommandText = sSql,                CommandType = System.Data.CommandType.Text
            };
            SQLcmdCondicionesMalas.ExecuteNonQuery();






            // Actualizo los dias de garantía restantes que tiene cada equipo
            sSql = "UPDATE equipo SET DiasRestantesGarantia=DATEDIFF(day, GETDATE() ,  [VigenciaGarantia]   )  WHERE  year([VigenciaGarantia]) > 0  ";
            SqlCommand SQLcmd3 = new SqlCommand()
            {
                Connection = SQLcnn,                 CommandText = sSql,                 CommandType = System.Data.CommandType.Text
            };
            SQLcmd3.ExecuteNonQuery();



            sSql = "UPDATE equipo SET EstadoGarantia=iif(DiasRestantesGarantia>0,'Activo','Caducado') WHERE  DiasRestantesGarantia<>0  ";
            SqlCommand SQLcmd4 = new SqlCommand()
            {
                Connection = SQLcnn,                 CommandText = sSql,                 CommandType = System.Data.CommandType.Text
            };
            SQLcmd4.ExecuteNonQuery();





            SQLcnn.Close();
        }
    }


    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
    static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
    public static void SetState(this ProgressBar pBar, int state)
    {
        SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
    }

}
