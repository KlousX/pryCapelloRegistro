namespace pryCapelloRegistro
{
    partial class frmListadoDeudores
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
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblPromDeuda = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblQClientes = new System.Windows.Forms.Label();
            this.lblMuestraDeuda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colLimite,
            this.colDeuda});
            this.dgvListado.Location = new System.Drawing.Point(35, 26);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.Size = new System.Drawing.Size(784, 388);
            this.dgvListado.TabIndex = 5;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            // 
            // colLimite
            // 
            this.colLimite.HeaderText = "Límite de Crédito";
            this.colLimite.MinimumWidth = 6;
            this.colLimite.Name = "colLimite";
            // 
            // colDeuda
            // 
            this.colDeuda.HeaderText = "Deuda";
            this.colDeuda.MinimumWidth = 6;
            this.colDeuda.Name = "colDeuda";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblMuestraDeuda);
            this.panel1.Controls.Add(this.lblPromedio);
            this.panel1.Controls.Add(this.lblPromDeuda);
            this.panel1.Controls.Add(this.lblClientes);
            this.panel1.Controls.Add(this.lblQClientes);
            this.panel1.Controls.Add(this.lblTotalDeuda);
            this.panel1.Location = new System.Drawing.Point(23, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 534);
            this.panel1.TabIndex = 7;
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.Location = new System.Drawing.Point(481, 421);
            this.lblTotalDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(89, 18);
            this.lblTotalDeuda.TabIndex = 2;
            this.lblTotalDeuda.Text = "Total deuda:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(481, 495);
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(141, 18);
            this.lblPromedio.TabIndex = 11;
            this.lblPromedio.Text = "Promedio de deuda:";
            // 
            // lblPromDeuda
            // 
            this.lblPromDeuda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPromDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromDeuda.Location = new System.Drawing.Point(664, 495);
            this.lblPromDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromDeuda.Name = "lblPromDeuda";
            this.lblPromDeuda.Size = new System.Drawing.Size(132, 18);
            this.lblPromDeuda.TabIndex = 12;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(481, 458);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(144, 18);
            this.lblClientes.TabIndex = 9;
            this.lblClientes.Text = "Cantidad de clientes:";
            // 
            // lblQClientes
            // 
            this.lblQClientes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblQClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQClientes.Location = new System.Drawing.Point(664, 458);
            this.lblQClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQClientes.Name = "lblQClientes";
            this.lblQClientes.Size = new System.Drawing.Size(132, 18);
            this.lblQClientes.TabIndex = 10;
            // 
            // lblMuestraDeuda
            // 
            this.lblMuestraDeuda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMuestraDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMuestraDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuestraDeuda.Location = new System.Drawing.Point(664, 420);
            this.lblMuestraDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMuestraDeuda.Name = "lblMuestraDeuda";
            this.lblMuestraDeuda.Size = new System.Drawing.Size(132, 18);
            this.lblMuestraDeuda.TabIndex = 13;
            // 
            // frmListadoDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 564);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListadoDeudores";
            this.Text = "Listado de deudores";
            this.Load += new System.EventHandler(this.frmListadoDeudores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblMuestraDeuda;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblPromDeuda;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblQClientes;
    }
}