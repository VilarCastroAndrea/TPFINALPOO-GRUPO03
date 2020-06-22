namespace Vistas
{
    partial class FrmTipoVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoVehiculo));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMoficar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.checkDisponible = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgwLista = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(302, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nuevo";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Enabled = false;
            this.txtDetalle.Location = new System.Drawing.Point(302, 29);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(164, 20);
            this.txtDetalle.TabIndex = 16;
            this.txtDetalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDetalle_KeyDown);
            this.txtDetalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDetalle_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(302, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tipo Vehiculo";
            // 
            // btnMoficar
            // 
            this.btnMoficar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMoficar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoficar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoficar.ForeColor = System.Drawing.Color.White;
            this.btnMoficar.Location = new System.Drawing.Point(302, 55);
            this.btnMoficar.Name = "btnMoficar";
            this.btnMoficar.Size = new System.Drawing.Size(164, 23);
            this.btnMoficar.TabIndex = 17;
            this.btnMoficar.Text = "Modificar";
            this.btnMoficar.UseVisualStyleBackColor = false;
            this.btnMoficar.Click += new System.EventHandler(this.btnMoficar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(302, 84);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNuevo);
            this.panel1.Controls.Add(this.btnAlta);
            this.panel1.Location = new System.Drawing.Point(302, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 78);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo Vehiculo";
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(3, 23);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(158, 20);
            this.txtNuevo.TabIndex = 19;
            this.txtNuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNuevo_KeyPress);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAlta.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Location = new System.Drawing.Point(3, 49);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(158, 23);
            this.btnAlta.TabIndex = 20;
            this.btnAlta.Text = "Agregar";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // checkDisponible
            // 
            this.checkDisponible.AutoSize = true;
            this.checkDisponible.BackColor = System.Drawing.Color.Transparent;
            this.checkDisponible.ForeColor = System.Drawing.Color.White;
            this.checkDisponible.Location = new System.Drawing.Point(388, 9);
            this.checkDisponible.Name = "checkDisponible";
            this.checkDisponible.Size = new System.Drawing.Size(75, 17);
            this.checkDisponible.TabIndex = 15;
            this.checkDisponible.Text = "Disponible";
            this.checkDisponible.UseVisualStyleBackColor = false;
            this.checkDisponible.CheckedChanged += new System.EventHandler(this.checkDisponible_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(302, 210);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(164, 23);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgwLista
            // 
            this.dgwLista.AllowUserToAddRows = false;
            this.dgwLista.AllowUserToDeleteRows = false;
            this.dgwLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwLista.BackgroundColor = System.Drawing.Color.White;
            this.dgwLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLista.Location = new System.Drawing.Point(15, 13);
            this.dgwLista.Name = "dgwLista";
            this.dgwLista.ReadOnly = true;
            this.dgwLista.Size = new System.Drawing.Size(281, 219);
            this.dgwLista.TabIndex = 8;
            this.dgwLista.CurrentCellChanged += new System.EventHandler(this.dgwLista_CurrentCellChanged);
            // 
            // FrmTipoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(480, 244);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.checkDisponible);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMoficar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgwLista);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTipoVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Vehiculo";
            this.Load += new System.EventHandler(this.FrmTipoVehiculo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMoficar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNuevo;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.CheckBox checkDisponible;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgwLista;
    }
}
