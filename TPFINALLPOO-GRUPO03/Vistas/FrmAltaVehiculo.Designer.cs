namespace Vistas
{
    partial class FrmAltaVehiculo
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
            this.GPS = new System.Windows.Forms.GroupBox();
            this.nGps = new System.Windows.Forms.RadioButton();
            this.sGps = new System.Windows.Forms.RadioButton();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbCantPuert = new System.Windows.Forms.ComboBox();
            this.txtAPrecio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAMatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtALinea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAltaVeh = new System.Windows.Forms.Button();
            this.cmbClase = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.GPS.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPS
            // 
            this.GPS.Controls.Add(this.nGps);
            this.GPS.Controls.Add(this.sGps);
            this.GPS.ForeColor = System.Drawing.Color.White;
            this.GPS.Location = new System.Drawing.Point(20, 292);
            this.GPS.Name = "GPS";
            this.GPS.Size = new System.Drawing.Size(170, 32);
            this.GPS.TabIndex = 61;
            this.GPS.TabStop = false;
            this.GPS.Text = "GPS";
            // 
            // nGps
            // 
            this.nGps.AutoSize = true;
            this.nGps.BackColor = System.Drawing.Color.Transparent;
            this.nGps.ForeColor = System.Drawing.Color.White;
            this.nGps.Location = new System.Drawing.Point(118, 10);
            this.nGps.Name = "nGps";
            this.nGps.Size = new System.Drawing.Size(39, 17);
            this.nGps.TabIndex = 51;
            this.nGps.Text = "No";
            this.nGps.UseVisualStyleBackColor = false;
            // 
            // sGps
            // 
            this.sGps.AutoSize = true;
            this.sGps.BackColor = System.Drawing.Color.Transparent;
            this.sGps.Checked = true;
            this.sGps.ForeColor = System.Drawing.Color.White;
            this.sGps.Location = new System.Drawing.Point(58, 10);
            this.sGps.Name = "sGps";
            this.sGps.Size = new System.Drawing.Size(34, 17);
            this.sGps.TabIndex = 50;
            this.sGps.TabStop = true;
            this.sGps.Text = "Si";
            this.sGps.UseVisualStyleBackColor = false;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Chevrolet",
            "Fiat",
            "Ford",
            "Peugeot",
            "Renault",
            "Toyota",
            "Volkswagen"});
            this.cmbMarca.Location = new System.Drawing.Point(20, 64);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(169, 21);
            this.cmbMarca.TabIndex = 43;
            // 
            // cmbModelo
            // 
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.cmbModelo.Location = new System.Drawing.Point(71, 130);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(118, 21);
            this.cmbModelo.TabIndex = 45;
            this.cmbModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbModelo_KeyPress);
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Azul",
            "Negro",
            "Rojo",
            "Verde",
            "Gris",
            "Blanco",
            "Amarillo"});
            this.cmbColor.Location = new System.Drawing.Point(71, 157);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(118, 21);
            this.cmbColor.TabIndex = 46;
            this.cmbColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbColor_KeyPress);
            // 
            // cmbCantPuert
            // 
            this.cmbCantPuert.FormattingEnabled = true;
            this.cmbCantPuert.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.cmbCantPuert.Location = new System.Drawing.Point(138, 184);
            this.cmbCantPuert.Name = "cmbCantPuert";
            this.cmbCantPuert.Size = new System.Drawing.Size(51, 21);
            this.cmbCantPuert.TabIndex = 47;
            this.cmbCantPuert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCantPuert_KeyPress);
            // 
            // txtAPrecio
            // 
            this.txtAPrecio.Location = new System.Drawing.Point(72, 330);
            this.txtAPrecio.MaxLength = 7;
            this.txtAPrecio.Name = "txtAPrecio";
            this.txtAPrecio.Size = new System.Drawing.Size(118, 20);
            this.txtAPrecio.TabIndex = 52;
            this.txtAPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAPrecio_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(18, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Precio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(18, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Clase de Vehiculo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Tipo de Vehiculo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Cantidad de Puertas";
            // 
            // txtAMatricula
            // 
            this.txtAMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAMatricula.Location = new System.Drawing.Point(20, 25);
            this.txtAMatricula.Name = "txtAMatricula";
            this.txtAMatricula.Size = new System.Drawing.Size(170, 20);
            this.txtAMatricula.TabIndex = 42;
            this.txtAMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAMatricula_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Matricula";
            // 
            // txtALinea
            // 
            this.txtALinea.Location = new System.Drawing.Point(20, 104);
            this.txtALinea.Name = "txtALinea";
            this.txtALinea.Size = new System.Drawing.Size(169, 20);
            this.txtALinea.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Linea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Marca";
            // 
            // btnAltaVeh
            // 
            this.btnAltaVeh.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAltaVeh.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnAltaVeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaVeh.ForeColor = System.Drawing.Color.White;
            this.btnAltaVeh.Location = new System.Drawing.Point(20, 356);
            this.btnAltaVeh.Name = "btnAltaVeh";
            this.btnAltaVeh.Size = new System.Drawing.Size(169, 23);
            this.btnAltaVeh.TabIndex = 53;
            this.btnAltaVeh.Text = "Agregar";
            this.btnAltaVeh.UseVisualStyleBackColor = false;
            this.btnAltaVeh.Click += new System.EventHandler(this.btnAltaVeh_Click);
            // 
            // cmbClase
            // 
            this.cmbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClase.FormattingEnabled = true;
            this.cmbClase.Location = new System.Drawing.Point(20, 266);
            this.cmbClase.Name = "cmbClase";
            this.cmbClase.Size = new System.Drawing.Size(169, 21);
            this.cmbClase.TabIndex = 49;
            this.cmbClase.DropDown += new System.EventHandler(this.cmbClase_DropDown);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(20, 226);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(169, 21);
            this.cmbTipo.TabIndex = 48;
            this.cmbTipo.DropDown += new System.EventHandler(this.cmbTipo_DropDown);
            // 
            // FrmAltaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(207, 389);
            this.Controls.Add(this.cmbClase);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.GPS);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbCantPuert);
            this.Controls.Add(this.txtAPrecio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtALinea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAltaVeh);
            this.Name = "FrmAltaVehiculo";
            this.Text = "FrmAltaVehiculo";
            this.Load += new System.EventHandler(this.FrmAltaVehiculo_Load);
            this.GPS.ResumeLayout(false);
            this.GPS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GPS;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbCantPuert;
        private System.Windows.Forms.TextBox txtAPrecio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtALinea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAltaVeh;
        public System.Windows.Forms.ComboBox cmbClase;
        public System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.RadioButton nGps;
        private System.Windows.Forms.RadioButton sGps;
    }
}