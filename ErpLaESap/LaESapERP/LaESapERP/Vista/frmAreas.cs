using LaESap.Negocio;
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
    public partial class frmAreas : Form
    {



        public frmAreas()
        {
            InitializeComponent();
            SpecialMethods.Titulo(this, "Areas");
            Refrescar();
        }


        public void Refrescar()
        {
            var Negox= new AreaBL();
            var Records = Negox.ObtenerAreas();
            this.dataGridView1.DataSource = Records;

        }

        private void picAltas_Click(object sender, EventArgs e)
        {
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picActualizar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void picEditar_Click(object sender, EventArgs e)
        {
           
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                return null;
            }
        }

        private void picBorrar_Click(object sender, EventArgs e)
        {
        }

        private void picEditar_Click_1(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                frmArea oF = new frmArea(id);

                oF.ShowDialog();
            }
        }

        private void picSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picAltas_Click_1(object sender, EventArgs e)
        {
            frmArea oF = new frmArea();

            oF.ShowDialog();

        }

        private void picBorrar_Click_1(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                frmArea oF = new frmArea(id, true);
                Refrescar();

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.txtBuscar.Visible = true;
            this.ActiveControl = txtBuscar;
            txtBuscar.Focus();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var Negox = new AreaBL();
            var Records = Negox.ObtenerAreasByFiltering( txtBuscar.Text);
            this.dataGridView1.DataSource = Records;

        }

        private void picActualizar_Click_1(object sender, EventArgs e)
        {
            Refrescar();
        }
    }
}
