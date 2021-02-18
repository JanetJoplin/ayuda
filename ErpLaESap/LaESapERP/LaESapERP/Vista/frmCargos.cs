﻿using LaESap.Negocio;
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
    public partial class frmCargos : Form
    {




        public frmCargos()
        {
            InitializeComponent();
            SpecialMethods.Titulo(this, "Puestos o Cargos");
            Refrescar();
        }


        public void Refrescar()
        {
            var Negox = new CargoBL();
            var Records = Negox.ObtenerCargos();
            this.dataGridView1.DataSource = Records;

        }

        private void picAltas_Click(object sender, EventArgs e)
        {
            frmCargo oF = new frmCargo();

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
                frmCargo oF = new frmCargo(id);

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
                frmCargo oF = new frmCargo(id, true);
                Refrescar();

            }
        }






        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var Negox = new CargoBL();
            var Records = Negox.ObtenerCargosByFiltering(txtBuscar.Text);
            this.dataGridView1.DataSource = Records;

        }

        private void picActualizar_Click_1(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void picFinder_Click(object sender, EventArgs e)
        {
            this.txtBuscar.Visible = true;
            this.ActiveControl = txtBuscar;
            txtBuscar.Focus();
        }





    }
}