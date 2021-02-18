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
    public partial class frmDepartamento : Form
    {
        public int? id;
        Departamento oEntity= null;

        public frmDepartamento(int? id = null, Boolean? Borrar = false)
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
                    var Negocio = new DepartamentoBL();
                    Negocio.EliminarDepartamentoByID((int)id);

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

            var Negocio = new DepartamentoBL();

            oEntity = Negocio.ObtenerDepartamento((int)id);

            this.txtNombre.Text = oEntity.Nombre;
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
                oEntity = new Departamento();
                oEntity.FechaAlta = DateTime.Now;
                
                oEntity.Estatus = 1;
            }
            else
            {
                oEntity.FechaCambio = DateTime.Now;
            }

            oEntity.Nombre = this.txtNombre.Text;
            oEntity.Clave = this.txtClave.Text;


            var Negocio = new DepartamentoBL();


            if (id == null)
            {
                Negocio.CrearDepartamento(oEntity);
            }
            else
            {
                Negocio.ActualizarDepartamento(oEntity);

            }


            MessageBox.Show("Guardado OK...");

            this.txtNombre.Text = "";
            this.txtLogin.Text = "";
            this.txtClave.Text = "";
        }

        private void picSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDepartamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
