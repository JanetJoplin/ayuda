using LaESap.Modelo;
using LaESap.Negocio;
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
    public partial class frmArea : Form
    {
		/// <summary>
		/// AQUI MODIFICQUE
		/// 
		/// </summary>

        public int? id;
        Area oArea = null;  //ZZAREAS

        public frmArea(int? id = null, Boolean? Borrar = false)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)
                CargaDatos();

            if (Borrar == true)
            {
                picSave.Visible = false;
                DialogResult dialogResult = MessageBox.Show("¿ ESTAS SEGURO DE ELIMINAR ?", Settings.Default.ERP_PROYECTO_NOMBRE, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    var Negocio = new AreaBL();
                    Negocio.EliminarAreaByID((int)id);

                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //this.Close();
                }

            }
        }

        private void CargaDatos()
        {

            var Negocio = new AreaBL();

            oArea = Negocio.ObtenerArea((int)id);

            this.txtNombre.Text = oArea.Nombre;
        }



        private void picSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picSave_Click(object sender, EventArgs e)
        {
            Alta();

        }

        private void Alta()
        {
            if (id == null)
            {
                oArea = new Area();
                oArea.FechaAlta = DateTime.Now;
                oArea.Estatus = 1;
            }
            else
            {
                oArea.FechaCambio = DateTime.Now;
            }

            oArea.Nombre = this.txtNombre.Text;

            var Negocio = new AreaBL();


            if (id == null)
            {
                Negocio.CrearArea(oArea);
            }
            else
            {
                Negocio.ActualizarArea(oArea);

            }


            MessageBox.Show("Guardado OK...");

            this.txtNombre.Text = "";
            this.txtLogin.Text = "";
            this.txtPassword.Text = "";
        }

        private void picSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
