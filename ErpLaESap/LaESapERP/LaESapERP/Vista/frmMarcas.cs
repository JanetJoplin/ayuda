using LaESap.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace LaESapERP
{

    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
            

            SpecialMethods.Titulo(this, "Marcas");
            Refrescar();
        }


        public void Refrescar()
        {
            var marcaNegocio = new MarcaBL();
            var marcas = marcaNegocio.ObtenerMarcas();
            this.dataGridView1.DataSource = marcas;
            //dataGridView1.DoubleBuffered(true);
        }

        private void picAltas_Click(object sender, EventArgs e)
        {
            frmMarca oF = new frmMarca();

                oF.ShowDialog();

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
            int? id = GetId();
            if (id != null)
            {
                frmMarca oF = new frmMarca(id);

                oF.ShowDialog();
            }
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
            int? id = GetId();
            if (id != null)
            {
                frmMarca oF = new frmMarca(id,true);
                Refrescar();

            }
        }

       

    }
}
