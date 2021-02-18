using LaESap.Modelo;
using LaESap.Negocio;
using LaESapERP.Controlador;
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
    public partial class frmAgregarEquipo : Form
    {
        public int? id;
        Equipo equipoNuevo = null;//ZZEQUIPOS
        
        

        public frmAgregarEquipo(int? id = null, Boolean? Borrar = false)
        {
            InitializeComponent();
            button1.Visible = false;

            lblVigenciaGarantia.Links.Add(0, 100, "https://support.hp.com/mx-es/checkwarranty");
            lblVigenciaGarantia.LinkClicked += new LinkLabelLinkClickedEventHandler(lblVigenciaGarantia_LinkClicked);

            lblVigenciaLenovo.Links.Add(0, 100, "https://pcsupport.lenovo.com/mx/es/warrantylookup#/");
            lblVigenciaLenovo.LinkClicked += new LinkLabelLinkClickedEventHandler(lblVigenciaLenovo_LinkClicked);


            Font theFont = new Font(Settings.Default.ERP_PROYECTO_FONT_MAIN, 9.0F, FontStyle.Bold);   // Verdana, 9.75pt
            foreach (Control theControl in (SpecialMethods.GetAllControls(this)))
            {
                theControl.Font = theFont;
            }

            SpecialMethods.Titulo(this, "Equipo Nuevo");


            CargaCombos();

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
                    var Negocio = new EquiposBL();
                    Negocio.EliminarEquipoByID((int)id);

                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //this.Close();
                }

            }
        }


        private void CargaCombos()
        {
            cbPropietario.DataSource = Enum.GetNames(typeof(Propietario));
            cbEstatus.DataSource = Enum.GetNames(typeof(EstatusTablas));

            cbEstadoEquipo.DataSource = Enum.GetNames(typeof(EstadoEquipo));

            cbTipoMantenimiento.DataSource = Enum.GetNames(typeof(TipoMantenimiento));
            

            var MarcaNegocio = new MarcaBL();
            var Marcas = MarcaNegocio.ObtenerMarcas();
            this.cbMarcaCPU.DataSource = Marcas;
            this.cbMarcaCPU.ValueMember = "id";
            this.cbMarcaCPU.DisplayMember = "nombre";

            // Carga Usuarios
            var UsuarioNegocio = new UsuarioBL();
            var Usuarios = UsuarioNegocio.ObtenerUsuarios();
            this.cbNombreUsuario.DataSource = Usuarios;
            this.cbNombreUsuario.ValueMember = "id";
            this.cbNombreUsuario.DisplayMember = "nombre";

            // Carga Deptos
            var DepartamentoNegocio = new DepartamentoBL();
            var Departamentos = DepartamentoNegocio.ObtenerDepartamentos();
            this.cbDepartamento.DataSource = Departamentos;
            this.cbDepartamento.ValueMember = "id";
            this.cbDepartamento.DisplayMember = "nombre";

            //Tipos de Equipos
            var TipoEquiposNegocio = new TipoEquipoBL();
            var TiposEq = TipoEquiposNegocio.ObtenerTipoEquipos();
            this.cbTipoEquipo.DataSource = TiposEq;
            this.cbTipoEquipo.ValueMember = "id";
            this.cbTipoEquipo.DisplayMember = "nombre";

            
        }
        private void CargaDatos()
        {


            var Negocio = new EquiposBL();

            equipoNuevo= Negocio.ObtenerEquipo((int)id);

            SpecialMethods.Titulo(this, "Equipo ID " + equipoNuevo.IdEquipo + " ");


            cbPropietario.Text = equipoNuevo.Propietario;
            cbNombreUsuario.Text = equipoNuevo.NombreUsuario;   //equipoNuevo.NombreUsuario = Convert.ToString(cbNombreUsuario.SelectedItem);  //Console.Write(cbDepartamento.SelectedText);
            cbDepartamento.Text = equipoNuevo.Departamento;     //equipoNuevo.Departamento = Convert.ToString(cbDepartamento.SelectedItem);
            cbEstadoEquipo.SelectedIndex = (int)equipoNuevo.EstadoEquipo;
            cbMarcaCPU.Text = equipoNuevo.MarcaCPU; //equipoNuevo.MarcaCPU = Convert.ToString(cbMarcaCPU.SelectedItem);
            cbTipoEquipo.SelectedValue = (int)equipoNuevo.TipoEquipoId;                                                                                                                                                                                                                         // https://stackoverflow.com/questions/59825268/get-index-from-combobox-based-on-valuemember

            txtId.Text = equipoNuevo.IdEquipo;
            

            if (equipoNuevo.Estatus == 1)
                cbEstatus.SelectedIndex = 0;
            else
                cbEstatus.SelectedIndex = 1;

            txtPassword.Text = equipoNuevo.Password;
            txtDireccionIP.Text = equipoNuevo.DireccionIP;
            txtNumeroInventario.Text = equipoNuevo.NumeroInventarioCPU;
            txtAtividad.Text = equipoNuevo.ActividadUtilizado;
            dtAdquisicion.Value = (DateTime)equipoNuevo.FechaAdquisicion;

            //equipoNuevo.NumeroPersonas = Convert.ToInt32(cbNumeroPersonas.SelectedItem);   
            dtGarantia.Value = (DateTime)equipoNuevo.VigenciaGarantia;
            txtVida.Text = equipoNuevo.TiempoVida;
            if (equipoNuevo.ConectadoInternet==1)//equipoNuevo.ConectadoInternet = cbConectadoInternet.SelectedIndex;
            {
                cbConectadoInternet.Text = "Sí";
            }
            else 
            {
                cbConectadoInternet.Text = "No";
            }
                
            txtMantenimientoPreventivo.Text = equipoNuevo.MantenimientoPreventivo ;
            txtMantenimientoCorrectivo.Text =equipoNuevo.MantenimientoCorrectivo  ;
            txtNumeroSerieCPU.Text= equipoNuevo.NumeroSerieCPU;
            txtModeloCPU.Text=equipoNuevo.ModeloCPU;
            txtProcesador.Text = equipoNuevo.Procesador;
            txtDiscoDuro.Text=equipoNuevo.DiscoDuro;
            txtRam.Text= equipoNuevo.RAM;
            txtNumeroInventarioMonitor.Text= equipoNuevo.NumeroInventarioMonitor;
            txtNumeroSerieMonitor.Text = equipoNuevo.NumeroSerieMonitor;
            txtMarcaMonitor.Text= equipoNuevo.MarcaMonitor;
            txtModeloMonitor.Text= equipoNuevo.ModeloMonitor;
            txtPulgadasMonitor.Text= equipoNuevo.PulgadasMonitor;
            txtTipoMonitor.Text= equipoNuevo.TipoMonitor;
            txtNumeroInventarioTeclado.Text= equipoNuevo.NumeroInventarioTeclado;
            txtNumeroSerieTeclado.Text= equipoNuevo.NumeroSerieTeclado;
            txtMarcaTeclado.Text= equipoNuevo.MarcaTeclado;
            txtModeloTeclado.Text= equipoNuevo.ModeloTeclado;
            txtNumeroInventarioMouse.Text= equipoNuevo.NumeroInventarioRaton;
            txtNumeroSerieMouse.Text= equipoNuevo.NumeroSerieRaton;
            txtMarcaMouse.Text= equipoNuevo.MarcaRaton;
            txtModeloMouse.Text= equipoNuevo.ModeloRaton;
            txtDiasDeVida.Text = Convert.ToString( equipoNuevo.DiasDeVida);
            txtNumeroInventarioOtroAccesorio.Text = equipoNuevo.NumeroInventarioOtroAccesorio;
            txtDiasRestantesGarantia.Text = Convert.ToString( equipoNuevo.DiasRestantesGarantia);
            
            
            if (equipoNuevo.DiasRestantesGarantia < 0)
            {
                lblEstadoGarantia.Text = "Caducado";
                lblEstadoGarantia.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblEstadoGarantia.Text = "Activo";
                lblEstadoGarantia.ForeColor = System.Drawing.Color.Green;
            }
            


            label39.Visible = true;            lblVigenciaLenovo.Visible = false;            lblVigenciaGarantia.Visible = false;

            string mkt = cbMarcaCPU.Text;
            switch (mkt)
            {
                case "LENOVO":
                    picMarca.Image = Properties.Resources.LENOVO;
                    lblVigenciaLenovo.Visible = true;
                    lblVigenciaLenovo.Top = lblVigenciaGarantia.Top;
                    lblVigenciaLenovo.Left = lblVigenciaGarantia.Left;
                    label39.Visible = false;
                    break;

                case "HP":
                case "HP COMPAQ":

                    picMarca.Image = Properties.Resources.HP;
                    lblVigenciaGarantia.Visible = true;
                    label39.Visible = false;
                    break;

            }



        }

        public void agregarEquipo()
        {
            equipoNuevo.Propietario = cbPropietario.Text;
            equipoNuevo.IdEquipo = txtId.Text;

            equipoNuevo.Password = txtPassword.Text;
            equipoNuevo.DireccionIP = txtDireccionIP.Text;

            //equipoNuevo.Departamento = Convert.ToString(cbDepartamento.SelectedItem);
            Console.Write(cbDepartamento.SelectedText);
            equipoNuevo.ActividadUtilizado = txtAtividad.Text;
            //equipoNuevo.NombreUsuario = Convert.ToString(cbNombreUsuario.SelectedItem);
            equipoNuevo.FechaAdquisicion = dtAdquisicion.Value.Date;
            equipoNuevo.NumeroPersonas = 1; // Convert.ToInt32(cbNumeroPersonas.Text); // .SelectedItem);   
            equipoNuevo.VigenciaGarantia = dtGarantia.Value.Date;
            equipoNuevo.TiempoVida = txtVida.Text;
            equipoNuevo.ConectadoInternet = cbConectadoInternet.SelectedIndex;
            equipoNuevo.MantenimientoPreventivo = txtMantenimientoPreventivo.Text;
            equipoNuevo.MantenimientoCorrectivo = txtMantenimientoCorrectivo.Text;
            equipoNuevo.NumeroSerieCPU = txtNumeroSerieCPU.Text;
            //equipoNuevo.MarcaCPU = Convert.ToString(cbMarcaCPU.SelectedItem);
            equipoNuevo.ModeloCPU = txtModeloCPU.Text;
            equipoNuevo.ModeloCPU = txtModeloCPU.Text;
            equipoNuevo.Procesador = txtProcesador.Text;
            equipoNuevo.DiscoDuro = txtDiscoDuro.Text;
            equipoNuevo.RAM = txtRam.Text;
            equipoNuevo.NumeroInventarioMonitor = txtNumeroInventarioMonitor.Text;
            equipoNuevo.NumeroSerieMonitor = txtNumeroSerieMonitor.Text;
            equipoNuevo.MarcaMonitor = txtMarcaMonitor.Text;
            equipoNuevo.ModeloMonitor = txtModeloMonitor.Text;
            equipoNuevo.PulgadasMonitor = txtPulgadasMonitor.Text;
            equipoNuevo.TipoMonitor = txtTipoMonitor.Text;
            equipoNuevo.NumeroInventarioTeclado = txtNumeroInventarioTeclado.Text;
            equipoNuevo.NumeroSerieTeclado = txtNumeroSerieTeclado.Text;
            equipoNuevo.MarcaTeclado = txtMarcaTeclado.Text;
            equipoNuevo.ModeloTeclado = txtModeloTeclado.Text;
            equipoNuevo.NumeroInventarioRaton= txtNumeroInventarioMouse.Text;
            equipoNuevo.NumeroSerieRaton = txtNumeroSerieMouse.Text;
            equipoNuevo.MarcaRaton = txtMarcaMouse.Text;
            equipoNuevo.ModeloRaton = txtModeloMouse.Text;

            equipoNuevo.TipoEquipoId = int.Parse(cbTipoEquipo.SelectedValue.ToString());




            equipoNuevo.MarcaId = int.Parse( cbMarcaCPU.SelectedValue.ToString() );
            equipoNuevo.UsuarioId = int.Parse(cbNombreUsuario.SelectedValue.ToString());
            equipoNuevo.DepartamentoId = int.Parse(cbDepartamento.SelectedValue.ToString());
            equipoNuevo.EstadoEquipo = int.Parse(cbEstadoEquipo.SelectedIndex.ToString());

            equipoNuevo.MarcaCPU = cbMarcaCPU.Text;
            equipoNuevo.NombreUsuario = cbNombreUsuario.Text;
            equipoNuevo.Departamento = cbDepartamento.Text;

            equipoNuevo.NumeroInventarioOtroAccesorio = txtNumeroInventarioOtroAccesorio.Text;

            if (cbEstatus.Text == "Activo")
                equipoNuevo.Estatus = 1;
            else
                equipoNuevo.Estatus = 0;


        }

        private void frmAgregarEquipo_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void picSave_Click(object sender, EventArgs e)
        {
            UpSert();
        }


        private void UpSert()
        {
            if (id == null)
            {
                equipoNuevo = new Equipo();
                equipoNuevo.FechaAlta = DateTime.Now;
            }
            else
            {
                equipoNuevo.FechaCambio = DateTime.Now;
            }

            agregarEquipo();

            var Negocio = new EquiposBL();


            if (id == null)
            {
                Negocio.CrearEquipo(equipoNuevo);
            }
            else
            {
                Negocio.ActualizarEquipo(equipoNuevo);

            }

            MessageBox.Show("Equipo registrado.", Settings.Default.ERP_PROYECTO_NOMBRE);
            this.Close();
        }


        private void cbEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstatus.Text =="Activo")
                picEstatus.Image = Properties.Resources.Circle_Max;
            else
                picEstatus.Image = Properties.Resources.Circle_Close;

            picEstatus.Refresh();
            picEstatus.Visible = true;

        }

        private void cbMarcaCPU_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mkt = null;
            mkt = cbMarcaCPU.Text;

            switch (mkt)
            {
                case "SERCOMM":                   picMarca.Image = Properties.Resources.SERCOM;                       break;
                case "HUAWEI":                    picMarca.Image = Properties.Resources.HUAWEI;                    break;
                case "LENOVO":                    picMarca.Image = Properties.Resources.LENOVO;                    break;
                case "ACER":                      picMarca.Image = Properties.Resources.ACER;                     break;
                case "HP":                        picMarca.Image = Properties.Resources.HP;                     break;
                case "DELL":                      picMarca.Image = Properties.Resources.DELL;                    break;
                case "COMPAQ":                    picMarca.Image = Properties.Resources.CONTPAQ;                    break;
                case "LEXMARK":                   picMarca.Image = Properties.Resources.LEXMARK;                    break;
                case "LG":                        picMarca.Image = Properties.Resources.LG;                    break;
                case "MICROSOFT":                 picMarca.Image = Properties.Resources.MICROSOFT;                    break;
                case "TOSHIBA":                   picMarca.Image = Properties.Resources.TOSHIBA;                    break;
                case "SONY":                      picMarca.Image = Properties.Resources.SONY;                    break;
                case "XEROX":                     picMarca.Image = Properties.Resources.XEROX;                     break;                
                case "ASUS":                      picMarca.Image = Properties.Resources.ASUS;                     break;
                case "BENQ":                      picMarca.Image = Properties.Resources.BENQ;                     break;
                case "SAMSUNG":                   picMarca.Image = Properties.Resources.SAMSUNG;                  break;

            }


            picEstatus.Refresh();
            picEstatus.Visible = true;


        }

        private void txtDiasDeVida_TextChanged(object sender, EventArgs e)
        {
            int? DiasDeVida;

            

            if (int.Parse(txtDiasDeVida.Text) < pgbDiasDeVida.Maximum)
                pgbDiasDeVida.Value = int.Parse(txtDiasDeVida.Text);
            else
                pgbDiasDeVida.Value = pgbDiasDeVida.Maximum;

            DiasDeVida = int.Parse(txtDiasDeVida.Text);
            switch (DiasDeVida)
            {
                case int n when DiasDeVida <= (365 * 2):
                    pgbDiasDeVida.SetState(1); // 1 = normal (green); 2 = error (red); 3 = warning (yellow).
                    break;

                case int n when DiasDeVida > (365 * 2)  && DiasDeVida <= (365 * 3):
                    pgbDiasDeVida.SetState(3); // 1 = normal (green); 2 = error (red); 3 = warning (yellow).
                    break;

                case int n when DiasDeVida > (365 * 3):
                    pgbDiasDeVida.SetState(2); // 1 = normal (green); 2 = error (red); 3 = warning (yellow).
                    break;

            }

        }

        private void lblVigenciaGarantia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(this.txtNumeroSerieCPU.Text);
            this.lblVigenciaGarantia.Links[lblVigenciaGarantia.Links.IndexOf(e.Link)].Visited = true;
            string target = e.Link.LinkData as string;

            System.Diagnostics.Process.Start(target);
        }

        private void lblVigenciaLenovo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(this.txtNumeroSerieCPU.Text);
            this.lblVigenciaLenovo.Links[lblVigenciaLenovo.Links.IndexOf(e.Link)].Visited = true;
            string target = e.Link.LinkData as string;

            System.Diagnostics.Process.Start(target);

        }

        private void txtProcesador_TextChanged(object sender, EventArgs e)
        {
            picProcesador.Image = Properties.Resources.CPU;

            string mkt = null;
            mkt = txtProcesador.Text.ToUpper();

            if (mkt.Contains("INTEL"))
                picProcesador.Image = Properties.Resources.INTEL;

            if (mkt.Contains("AMD"))
                picProcesador.Image = Properties.Resources.AMD;

        }
    }
}
