namespace Vistas
{
    partial class FrmAltaVenta
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
            this.cmbMedioDePago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnVender = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDatosVendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVehiculos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClientesDNI = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbMedioDePago
            // 
            this.cmbMedioDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioDePago.FormattingEnabled = true;
            this.cmbMedioDePago.Location = new System.Drawing.Point(19, 192);
            this.cmbMedioDePago.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMedioDePago.Name = "cmbMedioDePago";
            this.cmbMedioDePago.Size = new System.Drawing.Size(171, 21);
            this.cmbMedioDePago.TabIndex = 17;
            this.cmbMedioDePago.DropDown += new System.EventHandler(this.cmbMedioDePago_DropDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Forma de Pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(19, 242);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(171, 20);
            this.dtpFecha.TabIndex = 18;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVender.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.Location = new System.Drawing.Point(19, 341);
            this.btnVender.Margin = new System.Windows.Forms.Padding(2);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(171, 23);
            this.btnVender.TabIndex = 22;
            this.btnVender.Text = "Realizar Venta";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Precio Final";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(19, 293);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(171, 20);
            this.txtPrecio.TabIndex = 20;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtDatosVendedor
            // 
            this.txtDatosVendedor.Enabled = false;
            this.txtDatosVendedor.Location = new System.Drawing.Point(19, 141);
            this.txtDatosVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatosVendedor.Name = "txtDatosVendedor";
            this.txtDatosVendedor.Size = new System.Drawing.Size(171, 20);
            this.txtDatosVendedor.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Vendedor";
            // 
            // cmbVehiculos
            // 
            this.cmbVehiculos.FormattingEnabled = true;
            this.cmbVehiculos.Location = new System.Drawing.Point(19, 89);
            this.cmbVehiculos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVehiculos.Name = "cmbVehiculos";
            this.cmbVehiculos.Size = new System.Drawing.Size(171, 21);
            this.cmbVehiculos.TabIndex = 13;
            this.cmbVehiculos.DropDown += new System.EventHandler(this.cmbVehiculos_DropDown);
            this.cmbVehiculos.SelectedIndexChanged += new System.EventHandler(this.cmbVehiculos_SelectedIndexChanged);
            this.cmbVehiculos.TextUpdate += new System.EventHandler(this.cmbVehiculos_TextUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Vehiculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cliente";
            // 
            // cmbClientesDNI
            // 
            this.cmbClientesDNI.FormattingEnabled = true;
            this.cmbClientesDNI.Location = new System.Drawing.Point(19, 38);
            this.cmbClientesDNI.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClientesDNI.Name = "cmbClientesDNI";
            this.cmbClientesDNI.Size = new System.Drawing.Size(171, 21);
            this.cmbClientesDNI.TabIndex = 12;
            this.cmbClientesDNI.DropDown += new System.EventHandler(this.cmbClientesDNI_DropDown);
            this.cmbClientesDNI.TextUpdate += new System.EventHandler(this.cmbClientesDNI_TextUpdate);
            // 
            // FrmAltaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(209, 371);
            this.Controls.Add(this.cmbMedioDePago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDatosVendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbVehiculos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClientesDNI);
            this.Name = "FrmAltaVenta";
            this.Text = "FrmAltaVenta";
            this.Load += new System.EventHandler(this.FrmAltaVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMedioDePago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDatosVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVehiculos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClientesDNI;
    }
}