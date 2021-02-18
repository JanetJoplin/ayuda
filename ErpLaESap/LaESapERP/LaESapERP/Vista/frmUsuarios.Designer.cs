namespace LaESapERP
{
    partial class frmUsuarios
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
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.picActualizar = new System.Windows.Forms.PictureBox();
            this.picFinder = new System.Windows.Forms.PictureBox();
            this.picAltas = new System.Windows.Forms.PictureBox();
            this.picBorrar = new System.Windows.Forms.PictureBox();
            this.picEditar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAltas)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.picSalir);
            this.splitContainer1.Panel1.Controls.Add(this.txtBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.picActualizar);
            this.splitContainer1.Panel1.Controls.Add(this.picFinder);
            this.splitContainer1.Panel1.Controls.Add(this.picAltas);
            this.splitContainer1.Panel1.Controls.Add(this.picBorrar);
            this.splitContainer1.Panel1.Controls.Add(this.picEditar);
            this.splitContainer1.Panel1.Controls.Add(this.lblTitulo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(856, 450);
            this.splitContainer1.SplitterDistance = 83;
            this.splitContainer1.TabIndex = 0;
            // 
            // picSalir
            // 
            this.picSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.picSalir.Image = global::LaESapERP.Properties.Resources.Salir;
            this.picSalir.Location = new System.Drawing.Point(721, 0);
            this.picSalir.Name = "picSalir";
            this.picSalir.Size = new System.Drawing.Size(135, 83);
            this.picSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSalir.TabIndex = 5;
            this.picSalir.TabStop = false;
            this.picSalir.Click += new System.EventHandler(this.picSalir_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(452, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(228, 29);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.Visible = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // picActualizar
            // 
            this.picActualizar.Image = global::LaESapERP.Properties.Resources.Refresh03;
            this.picActualizar.Location = new System.Drawing.Point(310, 31);
            this.picActualizar.Name = "picActualizar";
            this.picActualizar.Size = new System.Drawing.Size(51, 46);
            this.picActualizar.TabIndex = 6;
            this.picActualizar.TabStop = false;
            this.picActualizar.Click += new System.EventHandler(this.picActualizar_Click);
            // 
            // picFinder
            // 
            this.picFinder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picFinder.Image = global::LaESapERP.Properties.Resources.buscar;
            this.picFinder.Location = new System.Drawing.Point(400, 30);
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
            this.picAltas.Location = new System.Drawing.Point(12, 31);
            this.picAltas.Name = "picAltas";
            this.picAltas.Size = new System.Drawing.Size(100, 50);
            this.picAltas.TabIndex = 6;
            this.picAltas.TabStop = false;
            this.picAltas.Click += new System.EventHandler(this.picAltas_Click);
            // 
            // picBorrar
            // 
            this.picBorrar.Image = global::LaESapERP.Properties.Resources.Delete1;
            this.picBorrar.Location = new System.Drawing.Point(253, 31);
            this.picBorrar.Name = "picBorrar";
            this.picBorrar.Size = new System.Drawing.Size(51, 46);
            this.picBorrar.TabIndex = 4;
            this.picBorrar.TabStop = false;
            // 
            // picEditar
            // 
            this.picEditar.Image = global::LaESapERP.Properties.Resources.Editar;
            this.picEditar.Location = new System.Drawing.Point(127, 31);
            this.picEditar.Name = "picEditar";
            this.picEditar.Size = new System.Drawing.Size(100, 50);
            this.picEditar.TabIndex = 3;
            this.picEditar.TabStop = false;
            this.picEditar.Click += new System.EventHandler(this.picEditar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(282, -1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(404, 23);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "ADMINISTRACION DE USUARIOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(856, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAltas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox picBorrar;
        private System.Windows.Forms.PictureBox picEditar;
        private System.Windows.Forms.PictureBox picSalir;
        private System.Windows.Forms.PictureBox picAltas;
        private System.Windows.Forms.PictureBox picActualizar;
        private System.Windows.Forms.PictureBox picFinder;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}