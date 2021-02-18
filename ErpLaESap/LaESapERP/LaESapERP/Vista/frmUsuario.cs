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
using static LaESapERP.Controlador.Enums;

namespace LaESapERP
{
    public partial class frmUsuario : Form
    {
        public int? id;
        Usuario oEntity = null;
        //Usuario oUsuario = null;

        public frmUsuario(int? id = null, Boolean? Borrar = false)
        {
            InitializeComponent();

            cbEstatus.DataSource = Enum.GetNames(typeof(EstatusTablas));

            this.id = id;
            if (id != null)
                CargaDatos();

            if (Borrar == true)
            {
                picSave.Visible = false;
                DialogResult dialogResult = MessageBox.Show("¿ ESTAS SEGURO DE ELIMINAR ?", 
                    Settings.Default.ERP_PROYECTO_NOMBRE, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    var Negocio = new UsuarioBL();
                    Negocio.EliminarUsuarioByID((int)id);

                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //this.Close();
                }

            }
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
                oEntity = new Usuario();
                oEntity.FechaAlta = DateTime.Now;
                oEntity.Estatus = 1;
            }
            else
            {
                oEntity.FechaCambio = DateTime.Now;
            }

            oEntity.Nombre = this.txtNombre.Text;
            oEntity.Login = this.txtLogin.Text;
            oEntity.Password = this.txtPassword.Text;
            oEntity.CargoId = int.Parse( cboCargos.SelectedValue.ToString() );
            oEntity.CorreoElectronico = this.txtCorreoElectronico.Text;
            oEntity.Estatus = cbEstatus.Text == "Activo" ? 1 : 0;                   //  int.Parse( cbEstatus.SelectedIndex.ToString() );

            var usuarioNegocio = new UsuarioBL();

            if (id == null)
            {
                usuarioNegocio.CrearUsuario(oEntity);
            }
            else
            {
                usuarioNegocio.ActualizarUsuario(oEntity);
            }
                

            MessageBox.Show("Registros añadido", Settings.Default.ERP_PROYECTO_NOMBRE);

            this.Close();
            this.txtNombre.Text = "";
            this.txtLogin.Text = "";
            this.txtPassword.Text = "";

        }

        private void frmUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }


        }

        private void CargaDatos()
        {


            Font theFont = new Font(Settings.Default.ERP_PROYECTO_FONT_MAIN, 9.0F, FontStyle.Bold);   // Verdana, 9.75pt
            foreach (Control theControl in (SpecialMethods.GetAllControls(this)))
            {
                theControl.Font = theFont;
            }

            var CargosNegocio = new CargoBL();
            var Cargos = CargosNegocio.ObtenerCargos();
            this.cboCargos.DataSource = Cargos;
            this.cboCargos.ValueMember = "id";
            this.cboCargos.DisplayMember = "nombre";


            var Negocio = new UsuarioBL();

            oEntity = Negocio.ObtenerUsuario((int)id);

            this.txtNombre.Text = oEntity.Nombre;
            this.txtLogin.Text = oEntity.Login;
            this.txtPassword.Text = oEntity.Password;
            this.cboCargos.SelectedValue = oEntity.CargoId;
            this.txtCorreoElectronico.Text = oEntity.CorreoElectronico;

            cbEstatus.SelectedIndex = oEntity.Estatus == 1? 0 : 1;

        }

        private void cbEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstatus.Text == "Activo")
                picEstatus.Image = Properties.Resources.Circle_Max;
            else
                picEstatus.Image = Properties.Resources.Circle_Close;

            picEstatus.Refresh();
            picEstatus.Visible = true;
        }
    }




}

