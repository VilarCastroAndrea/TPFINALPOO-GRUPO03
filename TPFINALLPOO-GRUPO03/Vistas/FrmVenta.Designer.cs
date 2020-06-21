namespace Vistas
{
    partial class FrmVenta
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
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.panelVenta = new System.Windows.Forms.Panel();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.panelListaVenta = new System.Windows.Forms.Panel();
            this.Informacion = new System.Windows.Forms.GroupBox();
            this.ingreso = new System.Windows.Forms.Label();
            this.anuladas = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFp = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBusacar = new System.Windows.Forms.Button();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.dataVenta = new System.Windows.Forms.DataGridView();
            this.panelListaVenta.SuspendLayout();
            this.Informacion.SuspendLayout();
            this.Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.BackColor = System.Drawing.Color.Black;
            this.btnRegistrarVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(909, 21);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(102, 38);
            this.btnRegistrarVenta.TabIndex = 29;
            this.btnRegistrarVenta.Text = "Nueva Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = false;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // panelVenta
            // 
            this.panelVenta.BackColor = System.Drawing.Color.Transparent;
            this.panelVenta.Location = new System.Drawing.Point(806, 58);
            this.panelVenta.Name = "panelVenta";
            this.panelVenta.Size = new System.Drawing.Size(205, 400);
            this.panelVenta.TabIndex = 31;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostrar.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(806, 21);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 38);
            this.btnMostrar.TabIndex = 32;
            this.btnMostrar.Text = "Mostrar Venta";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // panelListaVenta
            // 
            this.panelListaVenta.BackColor = System.Drawing.Color.Transparent;
            this.panelListaVenta.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.panelListaVenta.Controls.Add(this.Informacion);
            this.panelListaVenta.Controls.Add(this.btnFp);
            this.panelListaVenta.Controls.Add(this.Buscar);
            this.panelListaVenta.Controls.Add(this.dataVenta);
            this.panelListaVenta.Location = new System.Drawing.Point(22, 21);
            this.panelListaVenta.Name = "panelListaVenta";
            this.panelListaVenta.Size = new System.Drawing.Size(778, 437);
            this.panelListaVenta.TabIndex = 30;
            // 
            // Informacion
            // 
            this.Informacion.Controls.Add(this.ingreso);
            this.Informacion.Controls.Add(this.anuladas);
            this.Informacion.Controls.Add(this.Total);
            this.Informacion.Controls.Add(this.label8);
            this.Informacion.Controls.Add(this.label7);
            this.Informacion.Controls.Add(this.label6);
            this.Informacion.ForeColor = System.Drawing.Color.White;
            this.Informacion.Location = new System.Drawing.Point(154, 403);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(604, 26);
            this.Informacion.TabIndex = 35;
            this.Informacion.TabStop = false;
            this.Informacion.Text = "Informacion";
            this.Informacion.Enter += new System.EventHandler(this.Informacion_Enter);
            // 
            // ingreso
            // 
            this.ingreso.AutoSize = true;
            this.ingreso.Location = new System.Drawing.Point(469, 8);
            this.ingreso.Name = "ingreso";
            this.ingreso.Size = new System.Drawing.Size(0, 13);
            this.ingreso.TabIndex = 39;
            // 
            // anuladas
            // 
            this.anuladas.AutoSize = true;
            this.anuladas.Location = new System.Drawing.Point(341, 8);
            this.anuladas.Name = "anuladas";
            this.anuladas.Size = new System.Drawing.Size(0, 13);
            this.anuladas.TabIndex = 38;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(147, 8);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(0, 13);
            this.Total.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(391, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Importe Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(207, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Can. de ventas anuladas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(68, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Can. de ventas:";
            // 
            // btnFp
            // 
            this.btnFp.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.btnFp.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnFp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFp.ForeColor = System.Drawing.Color.White;
            this.btnFp.Location = new System.Drawing.Point(19, 406);
            this.btnFp.Name = "btnFp";
            this.btnFp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFp.Size = new System.Drawing.Size(129, 23);
            this.btnFp.TabIndex = 33;
            this.btnFp.Text = "Nueva Forma de Pago";
            this.btnFp.UseVisualStyleBackColor = true;
            this.btnFp.Click += new System.EventHandler(this.btnFp_Click);
            // 
            // Buscar
            // 
            this.Buscar.Controls.Add(this.label1);
            this.Buscar.Controls.Add(this.btnBusacar);
            this.Buscar.Controls.Add(this.cmbClientes);
            this.Buscar.Controls.Add(this.dtpHasta);
            this.Buscar.Controls.Add(this.label4);
            this.Buscar.Controls.Add(this.label5);
            this.Buscar.Controls.Add(this.label3);
            this.Buscar.Controls.Add(this.dtpDesde);
            this.Buscar.Controls.Add(this.label2);
            this.Buscar.Controls.Add(this.cmbMarca);
            this.Buscar.ForeColor = System.Drawing.Color.White;
            this.Buscar.Location = new System.Drawing.Point(19, 12);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(598, 80);
            this.Buscar.TabIndex = 14;
            this.Buscar.TabStop = false;
            this.Buscar.Text = "Buscar por";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente";
            // 
            // btnBusacar
            // 
            this.btnBusacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBusacar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnBusacar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusacar.ForeColor = System.Drawing.Color.White;
            this.btnBusacar.Location = new System.Drawing.Point(502, 16);
            this.btnBusacar.Name = "btnBusacar";
            this.btnBusacar.Size = new System.Drawing.Size(74, 26);
            this.btnBusacar.TabIndex = 4;
            this.btnBusacar.Text = "Buscar";
            this.btnBusacar.UseVisualStyleBackColor = false;
            this.btnBusacar.Click += new System.EventHandler(this.btnBusacar_Click);
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(65, 18);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(216, 21);
            this.cmbClientes.TabIndex = 5;
            this.cmbClientes.TextUpdate += new System.EventHandler(this.cmbClientes_TextUpdate);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(325, 50);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(251, 20);
            this.dtpHasta.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(285, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hasta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Desde :";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(65, 49);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(215, 20);
            this.dtpDesde.TabIndex = 7;
            this.dtpDesde.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(286, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(325, 19);
            this.cmbMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(172, 21);
            this.cmbMarca.TabIndex = 10;
            // 
            // dataVenta
            // 
            this.dataVenta.AllowUserToAddRows = false;
            this.dataVenta.AllowUserToDeleteRows = false;
            this.dataVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataVenta.BackgroundColor = System.Drawing.Color.White;
            this.dataVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVenta.GridColor = System.Drawing.Color.DarkOrange;
            this.dataVenta.Location = new System.Drawing.Point(19, 97);
            this.dataVenta.Margin = new System.Windows.Forms.Padding(2);
            this.dataVenta.Name = "dataVenta";
            this.dataVenta.ReadOnly = true;
            this.dataVenta.RowTemplate.Height = 24;
            this.dataVenta.Size = new System.Drawing.Size(739, 301);
            this.dataVenta.TabIndex = 1;
            this.dataVenta.CurrentCellChanged += new System.EventHandler(this.dataVenta_CurrentCellChanged);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1029, 479);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.panelVenta);
            this.Controls.Add(this.panelListaVenta);
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.panelListaVenta.ResumeLayout(false);
            this.Informacion.ResumeLayout(false);
            this.Informacion.PerformLayout();
            this.Buscar.ResumeLayout(false);
            this.Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Panel panelVenta;
        private System.Windows.Forms.Panel panelListaVenta;
        private System.Windows.Forms.GroupBox Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBusacar;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMarca;
        public System.Windows.Forms.DataGridView dataVenta;
        private System.Windows.Forms.GroupBox Informacion;
        private System.Windows.Forms.Label ingreso;
        private System.Windows.Forms.Label anuladas;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnFp;
    }
}
