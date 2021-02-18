using LaESap.Modelo;
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
    public partial class frmUsuarios : Form     //  ZZUSUARIOS
    {
        public frmUsuarios()
        {

            InitializeComponent();
            SpecialMethods.Titulo(this, "Usuarios");

        }

        
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            Refrescar();

        }
        public void Refrescar()
        {
            var usuarioNegocio = new UsuarioBL();
            var usuarios = usuarioNegocio.ObtenerUsuarios();
            this.dataGridView1.DataSource = usuarios;

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        

        private void picSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void picAltas_Click(object sender, EventArgs e)
        {
            frmUsuario oF = new frmUsuario();

            oF.ShowDialog();


        }

        private void picActualizar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var Negox = new UsuarioBL();
            var Records = Negox.ObtenerUsuariosByFiltering(txtBuscar.Text);
            this.dataGridView1.DataSource = Records;

        }

        private void picFinder_Click(object sender, EventArgs e)
        {
            this.txtBuscar.Top = this.picFinder.Top + 15;
            this.txtBuscar.Left = this.picFinder.Left + 60;
            this.txtBuscar.Visible = true;
            this.ActiveControl = txtBuscar;
            txtBuscar.Focus();
        }

        private void AbreUsuario()
        {
            int? id = GetId();
            if (id != null)
            {
                frmUsuario oF = new frmUsuario(id);

                oF.ShowDialog();
            }

        }

        private void picEditar_Click(object sender, EventArgs e)
        {
            AbreUsuario();

            Refrescar();

            if (txtBuscar.Text!="")
            {
                var Negox = new UsuarioBL();
                var Records = Negox.ObtenerUsuariosByFiltering(txtBuscar.Text);
                this.dataGridView1.DataSource = Records;
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

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {

            var Negox = new UsuarioBL();
            var Records = Negox.ObtenerUsuariosByFiltering(txtBuscar.Text);
            this.dataGridView1.DataSource = Records;

        }



        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

            MessageBox.Show("Error happened " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AbreUsuario();
        }
    }


}
