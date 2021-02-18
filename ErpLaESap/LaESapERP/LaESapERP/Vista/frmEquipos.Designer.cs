namespace LaESapERP
{
    partial class frmEquipos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cboCampoBúsq = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.picActualizar = new System.Windows.Forms.PictureBox();
            this.picFinder = new System.Windows.Forms.PictureBox();
            this.picAltas = new System.Windows.Forms.PictureBox();
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.picBorrar = new System.Windows.Forms.PictureBox();
            this.picEditar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAltas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.cboCampoBúsq);
            this.splitContainer1.Panel1.Controls.Add(this.txtBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.picActualizar);
            this.splitContainer1.Panel1.Controls.Add(this.picFinder);
            this.splitContainer1.Panel1.Controls.Add(this.picAltas);
            this.splitContainer1.Panel1.Controls.Add(this.picSalir);
            this.splitContainer1.Panel1.Controls.Add(this.picBorrar);
            this.splitContainer1.Panel1.Controls.Add(this.picEditar);
            this.splitContainer1.Panel1.Controls.Add(this.lblTitulo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(771, 450);
            this.splitContainer1.SplitterDistance = 95;
            this.splitContainer1.TabIndex = 0;
            // 
            // cboCampoBúsq
            // 
            this.cboCampoBúsq.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCampoBúsq.FormattingEnabled = true;
            this.cboCampoBúsq.Location = new System.Drawing.Point(644, 55);
            this.cboCampoBúsq.Name = "cboCampoBúsq";
            this.cboCampoBúsq.Size = new System.Drawing.Size(134, 29);
            this.cboCampoBúsq.TabIndex = 12;
            this.cboCampoBúsq.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(391, 55);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 29);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.Visible = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // picActualizar
            // 
            this.picActualizar.Image = global::LaESapERP.Properties.Resources.Refresh03;
            this.picActualizar.Location = new System.Drawing.Point(280, 50);
            this.picActualizar.Name = "picActualizar";
            this.picActualizar.Size = new System.Drawing.Size(51, 46);
            this.picActualizar.TabIndex = 9;
            this.picActualizar.TabStop = false;
            this.picActualizar.Click += new System.EventHandler(this.picActualizar_Click);
            // 
            // picFinder
            // 
            this.picFinder.Image = global::LaESapERP.Properties.Resources.buscar;
            this.picFinder.Location = new System.Drawing.Point(337, 46);
            this.picFinder.Name = "picFinder";
            this.picFinder.Size = new System.Drawing.Size(402, 55);
            this.picFinder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFinder.TabIndex = 10;
            this.picFinder.TabStop = false;
            this.picFinder.Click += new System.EventHandler(this.picFinder_Click);
            // 
            // picAltas
            // 
            this.picAltas.Image = global::LaESapERP.Properties.Resources.Agragar;
            this.picAltas.Location = new System.Drawing.Point(6, 55);
            this.picAltas.Name = "picAltas";
            this.picAltas.Size = new System.Drawing.Size(100, 50);
            this.picAltas.TabIndex = 11;
            this.picAltas.TabStop = false;
            this.picAltas.Click += new System.EventHandler(this.picAltas_Click);
            // 
            // picSalir
            // 
            this.picSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.picSalir.Image = global::LaESapERP.Properties.Resources.Salir;
            this.picSalir.Location = new System.Drawing.Point(636, 0);
            this.picSalir.Name = "picSalir";
            this.picSalir.Size = new System.Drawing.Size(135, 95);
            this.picSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSalir.TabIndex = 10;
            this.picSalir.TabStop = false;
            this.picSalir.Click += new System.EventHandler(this.picSalir_Click);
            // 
            // picBorrar
            // 
            this.picBorrar.Image = global::LaESapERP.Properties.Resources.Delete1;
            this.picBorrar.Location = new System.Drawing.Point(227, 55);
            this.picBorrar.Name = "picBorrar";
            this.picBorrar.Size = new System.Drawing.Size(34, 46);
            this.picBorrar.TabIndex = 8;
            this.picBorrar.TabStop = false;
            this.picBorrar.Click += new System.EventHandler(this.picBorrar_Click);
            // 
            // picEditar
            // 
            this.picEditar.Image = global::LaESapERP.Properties.Resources.Editar;
            this.picEditar.Location = new System.Drawing.Point(112, 55);
            this.picEditar.Name = "picEditar";
            this.picEditar.Size = new System.Drawing.Size(100, 50);
            this.picEditar.TabIndex = 7;
            this.picEditar.TabStop = false;
            this.picEditar.Click += new System.EventHandler(this.picEditar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(248, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(285, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ADMINISTRACION DE EQUIPOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(771, 351);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // frmEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmEquipos";
            this.Text = "frmEquipos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEquipos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAltas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picActualizar;
        private System.Windows.Forms.PictureBox picAltas;
        private System.Windows.Forms.PictureBox picSalir;
        private System.Windows.Forms.PictureBox picBorrar;
        private System.Windows.Forms.PictureBox picEditar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox picFinder;
        private System.Windows.Forms.ComboBox cboCampoBúsq;
    }
}