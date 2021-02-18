using LaESap.Negocio;
using LaESapERP.Controlador;
using LaESapERP.Properties;
using LaESsap.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md

namespace LaESapERP
{
    
    public partial class frmEquipos : Form  // zzequipos
    {
        int col = 0;

  

        public frmEquipos()
        {
            InitializeComponent();

            dataGridView1.DoubleBuffered(true);

            SpecialMethods.Titulo(this, "Equipos Informáticos");
            
           
        }

        private void frmEquipos_Load(object sender, EventArgs e)
        {

            Refrescar();    //  ZZEQUIPOS

            InitGrid();



        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picAltas_Click(object sender, EventArgs e)
        {
            frmAgregarEquipo oF = new frmAgregarEquipo();
                            oF.ShowDialog();

        }


        private int? GetId()
        {
            try
            {
                int? elId = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                return elId;
            }
            catch (Exception e)
            {
                // MessageBox.Show(e.ToString());
                return null;
            }
        }


        private void AbreEquipo()
        {
            int? id = GetId();

            if (id != null)
            {
                frmAgregarEquipo oF = new frmAgregarEquipo(id);
                oF.ShowDialog();


                Refrescar();

                if (txtBuscar.Text!="")
                {
                    var Negox = new EquiposBL();
                    var Records = Negox.ObtenerEquiposByFiltering(txtBuscar.Text, cboCampoBúsq.Text);
                    this.dataGridView1.DataSource = Records;
                }

                xBuscar(Convert.ToString(id));


            }
            else
                MessageBox.Show("Elija un registro.", LaESapERP.Properties.Settings.Default.ERP_PROYECTO_NOMBRE);

        }

        
        private void picEditar_Click(object sender, EventArgs e)
        {
            AbreEquipo();
        }

        private void picBorrar_Click(object sender, EventArgs e)
        {
            int? id = GetId();  // kk
            if (id != null)
            {
                frmAgregarEquipo oF = new frmAgregarEquipo(id, true);
                Refrescar();

            }
        }
        public void Refrescar()
        {

            SpecialMethods.xEquiposUpdate();




            var Negox = new EquiposBL();
            var Eqps= Negox.ObtenerEquipos();
            this.dataGridView1.DataSource = Eqps;

        }

        private void picActualizar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void InitGrid()
        {
           // this.dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);


            this.dataGridView1.Columns["Id"].Visible = false;
            this.dataGridView1.Columns["Nombre"].Visible = false;

            this.dataGridView1.Columns["UsuarioId"].Visible = false;
            this.dataGridView1.Columns["Usuario"].Visible = false;

            this.dataGridView1.Columns["MarcaId"].Visible = false;
            this.dataGridView1.Columns["Marca"].Visible = false;

            this.dataGridView1.Columns["DepartamentoId"].Visible = false;
            this.dataGridView1.Columns["Depto"].Visible = false;
            
            this.dataGridView1.Columns["Departamento"].Width = 150;
            this.dataGridView1.Columns["NombreUsuario"].Width = 280;
            this.dataGridView1.Columns["IdEquipo"].Width = 150;

            this.dataGridView1.Columns["TipoEquipoId"].Visible = false;
            this.dataGridView1.Columns["TipoEquipo"].Visible = false;

            

            this.cboCampoBúsq.Items.Add("ActividadUtilizado");
            //this.cboCampoBúsq.Items.Add("IdEquipo");

           

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
               // this.cboCampoBúsq.Items.Add(col.Name);

                switch (col.Name)
                {
                    case "ActividadUtilizado":
                    case "IdEquipo":
                    case "NombreUsuario": 
                    case "NumeroInventarioCPU":
                    case "NumeroSerieCPU": 
                    case "MarcaCPU": 
                    case "ModeloCPU": 
                    case "Procesador":
                    case "EstadoGarantia":
                        this.cboCampoBúsq.Items.Add(col.Name);
                        break;
                }

            }
            cboCampoBúsq.Text = "IdEquipo";



        }

        private void picFinder_Click(object sender, EventArgs e)
        {
            this.txtBuscar.Visible = true;
            this.ActiveControl = txtBuscar;

            this.cboCampoBúsq.Left = this.txtBuscar.Left + this.txtBuscar.Width + 5;
            this.cboCampoBúsq.Top = this.txtBuscar.Top; this.cboCampoBúsq.Visible = true;

            txtBuscar.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var Negox = new EquiposBL();
            var Records = Negox.ObtenerEquiposByFiltering(txtBuscar.Text, cboCampoBúsq.Text);
            this.dataGridView1.DataSource = Records;
            this.dataGridView1.Columns[col].Selected = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbreEquipo();
        }

        private void xBuscar(String searchValue)
        {

            //String searchValue = "somestring";
            int rowIndex = -1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(searchValue))
                {
                    rowIndex = row.Index;
                    //dataGridView1.Rows[rowIndex].Selected = true;

                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowIndex].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                    dataGridView1.Focus();

                    break;
                }
            }

        }


        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }


        public static class ExtensionMethods
        {
            
        }



        //private void button3_Click_1(object sender, EventArgs e)
        //{
        //    copyAlltoClipboard();
        //    Microsoft.Office.Interop.Excel.Application xlexcel;
        //    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        //    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
        //    object misValue = System.Reflection.Missing.Value;
        //    xlexcel = new Excel.Application();
        //    xlexcel.Visible = true;
        //    xlWorkBook = xlexcel.Workbooks.Add(misValue);
        //    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
        //    Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
        //    CR.Select();
        //    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        //}

    }
}
