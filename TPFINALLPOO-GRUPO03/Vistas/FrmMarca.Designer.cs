namespace Vistas
{
    partial class FrmMarca
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
            this.dgwMarca = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMoficar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMarca)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwMarca
            // 
            this.dgwMarca.AllowUserToAddRows = false;
            this.dgwMarca.AllowUserToDeleteRows = false;
            this.dgwMarca.BackgroundColor = System.Drawing.Color.White;
            this.dgwMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMarca.Location = new System.Drawing.Point(12, 14);
            this.dgwMarca.Name = "dgwMarca";
            this.dgwMarca.ReadOnly = true;
            this.dgwMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMarca.Size = new System.Drawing.Size(281, 280);
            this.dgwMarca.TabIndex = 9;
            this.dgwMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMarca_CellContentClick);
            this.dgwMarca.CurrentCellChanged += new System.EventHandler(this.dgwMarca_CurrentCellChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(3, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(158, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(301, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Marca";
            // 
            // btnMoficar
            // 
            this.btnMoficar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMoficar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoficar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoficar.ForeColor = System.Drawing.Color.White;
            this.btnMoficar.Location = new System.Drawing.Point(304, 88);
            this.btnMoficar.Name = "btnMoficar";
            this.btnMoficar.Size = new System.Drawing.Size(164, 23);
            this.btnMoficar.TabIndex = 16;
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
            this.btnEliminar.Location = new System.Drawing.Point(304, 115);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAlta.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Location = new System.Drawing.Point(2, 92);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(158, 23);
            this.btnAlta.TabIndex = 3;
            this.btnAlta.Text = "Agregar";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(304, 25);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(164, 20);
            this.txtMarca.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.btnAlta);
            this.panel1.Location = new System.Drawing.Point(304, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 154);
            this.panel1.TabIndex = 14;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(3, 65);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(158, 20);
            this.txtDescripcion.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Descripcion";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(304, 63);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(164, 20);
            this.txtDetalle.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(301, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Descripcion";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSalir.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1, 123);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(158, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(480, 306);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMoficar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwMarca);
            this.Name = "FrmMarca";
            this.Text = "FrmMarca";
            ((System.ComponentModel.ISupportInitialize)(this.dgwMarca)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMarca;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMoficar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
    }
}