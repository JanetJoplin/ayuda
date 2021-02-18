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
    public partial class frmMarca : Form
    {
 
        
        public int? id;
        Marca oMarca = null;

        public frmMarca(int? id=null, Boolean? Borrar=false)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)
                CargaDatos();

            if (Borrar==true)
            {
                picSave.Visible = false;
                DialogResult dialogResult = MessageBox.Show("¿ ESTAS SEGURO DE ELIMINAR ?", Settings.Default.ERP_PROYECTO_NOMBRE, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    var Negocio = new MarcaBL();
                        Negocio.EliminarMarcaByID((int)id);

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

            var Negocio = new MarcaBL();
            
                 oMarca =  Negocio.ObtenerMarca((int)id);

            this.txtNombre.Text = oMarca.Nombre;
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
            if (id ==null)
            {
                oMarca = new Marca();
                oMarca.FechaAlta = DateTime.Now;
            }
            else 
            {
                oMarca.FechaCambio= DateTime.Now;
            }
            
            oMarca.Nombre = this.txtNombre.Text;
            
            var Negocio = new MarcaBL();


            if (id == null)
            {
                Negocio.CrearMarca(oMarca);
            }
            else
            {
                Negocio.ActualizarMarca(oMarca);

            }
                

            MessageBox.Show("Marca registrada.");

            this.txtNombre.Text = "";
            this.txtLogin.Text = "";
            this.txtPassword.Text = "";
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {

        }

        private void frmMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                Alta();
            }

        }
    }
}
