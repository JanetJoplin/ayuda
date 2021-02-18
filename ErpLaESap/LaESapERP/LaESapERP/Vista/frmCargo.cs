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
    public partial class frmCargo : Form
    {

        public int? id;
        Cargo oCargo= null;  //ZZCARGOS


        public frmCargo(int? id = null, Boolean? Borrar = false)
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
                    var Negocio = new CargoBL();
                    Negocio.EliminarCargoByID((int)id);

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

            var Negocio = new CargoBL();

            oCargo = Negocio.ObtenerCargo((int)id);

            this.txtNombre.Text = oCargo.Nombre;
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picSave_Click(object sender, EventArgs e)
        {
            
            
            
            this.Altas();
        }



        private void Altas()
        {
            Cargo oCar = new Cargo();
            oCar.Nombre = this.txtNombre.Text;
            oCar.FechaAlta = DateTime.Now;

            var CargoNeg = new CargoBL();
            CargoNeg.CrearCargo(oCar);

            MessageBox.Show("Registros añadido");


            this.txtNombre.Text = "";
        }

        private void frmCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
