namespace Vistas
{
    partial class FrmVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehiculo));
            this.panelVehiculo = new System.Windows.Forms.Panel();
            this.btnAlta = new System.Windows.Forms.Button();
            this.panelListaVehiculo = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnVendido = new System.Windows.Forms.RadioButton();
            this.rbtnDisponible = new System.Windows.Forms.RadioButton();
            this.lblcantVehiculo = new System.Windows.Forms.Label();
            this.dataVehiculo = new System.Windows.Forms.DataGridView();
            this.btnClase = new System.Windows.Forms.Button();
            this.btnTipo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarVehiculo = new System.Windows.Forms.TextBox();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.rbtnMarca = new System.Windows.Forms.RadioButton();
            this.rbtnLinea = new System.Windows.Forms.RadioButton();
            this.Informacion = new System.Windows.Forms.GroupBox();
            this.lblVehDiponibles = new System.Windows.Forms.Label();
            this.lblVehiculosVendi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.panelListaVehiculo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gBox.SuspendLayout();
            this.Informacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVehiculo
            // 
            this.panelVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.panelVehiculo.Location = new System.Drawing.Point(800, 59);
            this.panelVehiculo.Name = "panelVehiculo";
            this.panelVehiculo.Size = new System.Drawing.Size(205, 399);
            this.panelVehiculo.TabIndex = 30;
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.Black;
            this.btnAlta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Location = new System.Drawing.Point(905, 21);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(100, 38);
            this.btnAlta.TabIndex = 28;
            this.btnAlta.Text = "Nuevo Vehiculo";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // panelListaVehiculo
            // 
            this.panelListaVehiculo.BackColor = System.Drawing.Color.Black;
            this.panelListaVehiculo.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.panelListaVehiculo.Controls.Add(this.groupBox2);
            this.panelListaVehiculo.Controls.Add(this.dataVehiculo);
            this.panelListaVehiculo.Controls.Add(this.btnTipo);
            this.panelListaVehiculo.Controls.Add(this.btnClase);
            this.panelListaVehiculo.Controls.Add(this.groupBox1);
            this.panelListaVehiculo.Controls.Add(this.gBox);
            this.panelListaVehiculo.Controls.Add(this.Informacion);
            this.panelListaVehiculo.Location = new System.Drawing.Point(24, 21);
            this.panelListaVehiculo.Name = "panelListaVehiculo";
            this.panelListaVehiculo.Size = new System.Drawing.Size(770, 437);
            this.panelListaVehiculo.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbtnVendido);
            this.groupBox2.Controls.Add(this.rbtnDisponible);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(491, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 52);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar:";
            // 
            // rbtnVendido
            // 
            this.rbtnVendido.AutoSize = true;
            this.rbtnVendido.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnVendido.Location = new System.Drawing.Point(150, 20);
            this.rbtnVendido.Name = "rbtnVendido";
            this.rbtnVendido.Size = new System.Drawing.Size(64, 17);
            this.rbtnVendido.TabIndex = 9;
            this.rbtnVendido.TabStop = true;
            this.rbtnVendido.Text = "Vendido";
            this.rbtnVendido.UseVisualStyleBackColor = true;
            this.rbtnVendido.CheckedChanged += new System.EventHandler(this.rbtnVendido_CheckedChanged);
            // 
            // rbtnDisponible
            // 
            this.rbtnDisponible.AutoSize = true;
            this.rbtnDisponible.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnDisponible.Location = new System.Drawing.Point(35, 19);
            this.rbtnDisponible.Name = "rbtnDisponible";
            this.rbtnDisponible.Size = new System.Drawing.Size(74, 17);
            this.rbtnDisponible.TabIndex = 8;
            this.rbtnDisponible.TabStop = true;
            this.rbtnDisponible.Text = "Disponible";
            this.rbtnDisponible.UseVisualStyleBackColor = true;
            this.rbtnDisponible.CheckedChanged += new System.EventHandler(this.rbtnDisponible_CheckedChanged);
            // 
            // lblcantVehiculo
            // 
            this.lblcantVehiculo.AutoSize = true;
            this.lblcantVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.lblcantVehiculo.ForeColor = System.Drawing.Color.White;
            this.lblcantVehiculo.Location = new System.Drawing.Point(163, 10);
            this.lblcantVehiculo.Name = "lblcantVehiculo";
            this.lblcantVehiculo.Size = new System.Drawing.Size(0, 13);
            this.lblcantVehiculo.TabIndex = 40;
            // 
            // dataVehiculo
            // 
            this.dataVehiculo.AllowUserToAddRows = false;
            this.dataVehiculo.AllowUserToDeleteRows = false;
            this.dataVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataVehiculo.BackgroundColor = System.Drawing.Color.White;
            this.dataVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVehiculo.GridColor = System.Drawing.Color.DarkOrange;
            this.dataVehiculo.Location = new System.Drawing.Point(19, 69);
            this.dataVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.dataVehiculo.Name = "dataVehiculo";
            this.dataVehiculo.ReadOnly = true;
            this.dataVehiculo.RowTemplate.Height = 24;
            this.dataVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVehiculo.Size = new System.Drawing.Size(730, 326);
            this.dataVehiculo.TabIndex = 1;
            this.dataVehiculo.CurrentCellChanged += new System.EventHandler(this.dataVehiculo_CurrentCellChanged);
            // 
            // btnClase
            // 
            this.btnClase.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.btnClase.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClase.ForeColor = System.Drawing.Color.White;
            this.btnClase.Location = new System.Drawing.Point(141, 402);
            this.btnClase.Name = "btnClase";
            this.btnClase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClase.Size = new System.Drawing.Size(116, 23);
            this.btnClase.TabIndex = 32;
            this.btnClase.Text = "Clase vehiculo";
            this.btnClase.UseVisualStyleBackColor = true;
            this.btnClase.Click += new System.EventHandler(this.btnClase_Click);
            // 
            // btnTipo
            // 
            this.btnTipo.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.btnTipo.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipo.ForeColor = System.Drawing.Color.White;
            this.btnTipo.Location = new System.Drawing.Point(19, 402);
            this.btnTipo.Name = "btnTipo";
            this.btnTipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTipo.Size = new System.Drawing.Size(116, 23);
            this.btnTipo.TabIndex = 31;
            this.btnTipo.Text = "Tipo vehiculo";
            this.btnTipo.UseVisualStyleBackColor = true;
            this.btnTipo.Click += new System.EventHandler(this.btnTipo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscarVehiculo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 52);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AllowDrop = true;
            this.btnBuscar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(187, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 23);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarVehiculo
            // 
            this.txtBuscarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarVehiculo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBuscarVehiculo.Location = new System.Drawing.Point(6, 19);
            this.txtBuscarVehiculo.Name = "txtBuscarVehiculo";
            this.txtBuscarVehiculo.Size = new System.Drawing.Size(180, 20);
            this.txtBuscarVehiculo.TabIndex = 2;
            this.txtBuscarVehiculo.Text = "Buscar Vehiculo";
            this.txtBuscarVehiculo.Enter += new System.EventHandler(this.placeHolderVehiculo);
            this.txtBuscarVehiculo.Leave += new System.EventHandler(this.placeHolderVehiculo_Leave);
            // 
            // gBox
            // 
            this.gBox.BackColor = System.Drawing.Color.Transparent;
            this.gBox.Controls.Add(this.rbtnMarca);
            this.gBox.Controls.Add(this.rbtnLinea);
            this.gBox.ForeColor = System.Drawing.SystemColors.Window;
            this.gBox.Location = new System.Drawing.Point(243, 12);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(242, 52);
            this.gBox.TabIndex = 9;
            this.gBox.TabStop = false;
            this.gBox.Text = "Ordenar segun:";
            // 
            // rbtnMarca
            // 
            this.rbtnMarca.AutoSize = true;
            this.rbtnMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnMarca.Location = new System.Drawing.Point(43, 20);
            this.rbtnMarca.Name = "rbtnMarca";
            this.rbtnMarca.Size = new System.Drawing.Size(55, 17);
            this.rbtnMarca.TabIndex = 7;
            this.rbtnMarca.TabStop = true;
            this.rbtnMarca.Text = "Marca";
            this.rbtnMarca.UseVisualStyleBackColor = true;
            this.rbtnMarca.CheckedChanged += new System.EventHandler(this.rbtnMarca_CheckedChanged);
            // 
            // rbtnLinea
            // 
            this.rbtnLinea.AutoSize = true;
            this.rbtnLinea.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnLinea.Location = new System.Drawing.Point(145, 20);
            this.rbtnLinea.Name = "rbtnLinea";
            this.rbtnLinea.Size = new System.Drawing.Size(51, 17);
            this.rbtnLinea.TabIndex = 6;
            this.rbtnLinea.TabStop = true;
            this.rbtnLinea.Text = "Linea";
            this.rbtnLinea.UseVisualStyleBackColor = true;
            this.rbtnLinea.CheckedChanged += new System.EventHandler(this.rbtnLinea_CheckedChanged);
            // 
            // Informacion
            // 
            this.Informacion.BackColor = System.Drawing.Color.Transparent;
            this.Informacion.Controls.Add(this.lblVehDiponibles);
            this.Informacion.Controls.Add(this.lblcantVehiculo);
            this.Informacion.Controls.Add(this.lblVehiculosVendi);
            this.Informacion.Controls.Add(this.label6);
            this.Informacion.Controls.Add(this.label7);
            this.Informacion.Controls.Add(this.label8);
            this.Informacion.ForeColor = System.Drawing.Color.White;
            this.Informacion.Location = new System.Drawing.Point(264, 400);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(485, 26);
            this.Informacion.TabIndex = 36;
            this.Informacion.TabStop = false;
            this.Informacion.Text = "Informacion";
            // 
            // lblVehDiponibles
            // 
            this.lblVehDiponibles.AutoSize = true;
            this.lblVehDiponibles.BackColor = System.Drawing.Color.Transparent;
            this.lblVehDiponibles.Location = new System.Drawing.Point(294, 10);
            this.lblVehDiponibles.Name = "lblVehDiponibles";
            this.lblVehDiponibles.Size = new System.Drawing.Size(0, 13);
            this.lblVehDiponibles.TabIndex = 41;
            // 
            // lblVehiculosVendi
            // 
            this.lblVehiculosVendi.AutoSize = true;
            this.lblVehiculosVendi.Location = new System.Drawing.Point(419, 10);
            this.lblVehiculosVendi.Name = "lblVehiculosVendi";
            this.lblVehiculosVendi.Size = new System.Drawing.Size(0, 13);
            this.lblVehiculosVendi.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(65, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Total de Vehiculos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(208, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Veh.Disponibles:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(334, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Veh. Vendidos:";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Black;
            this.btnMostrar.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(800, 21);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 38);
            this.btnMostrar.TabIndex = 27;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1029, 479);
            this.Controls.Add(this.panelVehiculo);
            this.Controls.Add(this.panelListaVehiculo);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAlta);
            this.Name = "FrmVehiculo";
            this.Text = "FrmVehiculo";
            this.Load += new System.EventHandler(this.FrmVehiculo_Load);
            this.panelListaVehiculo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.Informacion.ResumeLayout(false);
            this.Informacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVehiculo;
        private System.Windows.Forms.Panel panelListaVehiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscarVehiculo;
        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.RadioButton rbtnMarca;
        private System.Windows.Forms.RadioButton rbtnLinea;
        public System.Windows.Forms.DataGridView dataVehiculo;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnClase;
        private System.Windows.Forms.Button btnTipo;
        private System.Windows.Forms.GroupBox Informacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblcantVehiculo;
        private System.Windows.Forms.Label lblVehiculosVendi;
        private System.Windows.Forms.Label lblVehDiponibles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnVendido;
        private System.Windows.Forms.RadioButton rbtnDisponible;
    }
}