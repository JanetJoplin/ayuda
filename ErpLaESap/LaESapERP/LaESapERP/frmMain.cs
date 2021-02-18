// ZZMAIN
using LaESapERP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaESapERP
{
    public partial class frmMain : Form
    {
        string ERP_Modulo_Select = "";


        public frmMain()
        {
            InitializeComponent();
            InitializeTreeView();

            Font theFont = new Font(Settings.Default.ERP_PROYECTO_FONT_MAIN, 9.0F, FontStyle.Bold);   // Verdana, 9.75pt
            foreach (Control theControl in (SpecialMethods.GetAllControls(this)))
            {
                theControl.Font = theFont;
            }

            SpecialMethods.Titulo(this, "Menú Principal");

        }

        // Populates a TreeView control with example nodes. 
        private void InitializeTreeView()
        {


            treeView1.BeginUpdate();
            treeView1.Nodes.Add("MENU LaESapGto ERP");

            //treeView1.Nodes.Add("Parent");
            //treeView1.Nodes[0].Nodes.Add("Child 1");
            //treeView1.Nodes[0].Nodes.Add("Child 2");
            //treeView1.Nodes[0].Nodes[1].Nodes.Add("Grandchild");
            //treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Great Grandchild");

            treeView1.Nodes[0].Nodes.Add("Sistema Control de Documentos");
            treeView1.Nodes[0].Nodes.Add("Sist Admin. Equipo Informático");

            treeView1.Nodes[0].Nodes[0].Nodes.Add("Control de Auditorias");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Admin de No Conformidades");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Mejora Continua");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Eficacia de Acciones");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Norma ISO 9000");

            treeView1.Nodes[0].Nodes[1].Nodes.Add("Inventarios Equipos");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Usuarios");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Marcas");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Cargos");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Departamentos");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Areas");



            //treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Usuarios");
            //treeView1.Nodes[1].Nodes[1].Nodes[2].Nodes.Add("Marcas");
            //treeView1.Nodes[1].Nodes[1].Nodes[3].Nodes.Add("Cargos (puestos)");
            //treeView1.Nodes[1].Nodes[1].Nodes[4].Nodes.Add("Departamentos");
            //treeView1.Nodes[1].Nodes[1].Nodes[5].Nodes.Add("Areas");

            
            this.treeView1.ExpandAll();

            treeView1.Visible = true;
            treeView1.EndUpdate();

            this.ActiveControl = treeView1;
                treeView1.Focus();
        }
        

        private void ERP_AbrirModulo(string ERP_Modulo)
        {
            try // If a node is double-clicked, open the file indicated by the TreeNode.
            {
                Cursor.Current = Cursors.WaitCursor;

                switch (ERP_Modulo )
                {

                    case "Inventarios Equipos":
                        frmEquipos oForm = new frmEquipos();
                        oForm.Show();       // .ShowDialog();
                        break;

                    case "Usuarios":

                        frmUsuarios oUsrs = new frmUsuarios();
                        oUsrs.Show();       // .ShowDialog();
                        break;

                    case "Marcas":
                        frmMarcas oMarcas = new frmMarcas();
                        oMarcas.Show(); // ShowDialog();
                        break;

                    case "Cargos":
                        frmCargos oC = new frmCargos();
                        oC.Show(); // ShowDialog();
                        break;

                    case "Departamentos":
                        frmDepartamentos frmDeptosListing = new frmDepartamentos();
                        frmDeptosListing.Show(); // ShowDialog();
                        break;

                    case "Areas":
                        frmAreas frmAreasListing = new frmAreas();
                        frmAreasListing.Show(); // ShowDialog();
                        break;

                    case "Return":
                        // MessageBox.Show(gvPagos.GetFocusedRowCellValue("PROVEEDOR").ToString());
                        break;
                }


                // Set cursor as default arrow
                Cursor.Current = Cursors.Default;


            }
            
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("File not found.");
            }

        }
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            ERP_AbrirModulo(e.Node.Text);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;

            ERP_Modulo_Select = node.Text;

            //MessageBox.Show(node.Name + "\n" + node.Text);

        }

        private void treeView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                
                ERP_AbrirModulo(ERP_Modulo_Select);  //MessageBox.Show("Enter key pressed");
            }
        }
    }
}
