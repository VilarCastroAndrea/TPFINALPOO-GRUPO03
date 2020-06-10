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
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMoficar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.txtDetalleMarca = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dgwMarca.Size = new System.Drawing.Size(281, 201);
            this.dgwMarca.TabIndex = 9;
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(3, 23);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(158, 20);
            this.txtNuevo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(304, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descripcion";
            // 
            // btnMoficar
            // 
            this.btnMoficar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMoficar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoficar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoficar.ForeColor = System.Drawing.Color.White;
            this.btnMoficar.Location = new System.Drawing.Point(304, 58);
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
            this.btnEliminar.Location = new System.Drawing.Point(304, 87);
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
            this.btnAlta.Location = new System.Drawing.Point(3, 59);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(158, 23);
            this.btnAlta.TabIndex = 3;
            this.btnAlta.Text = "Agregar";
            this.btnAlta.UseVisualStyleBackColor = false;
            // 
            // txtDetalleMarca
            // 
            this.txtDetalleMarca.Location = new System.Drawing.Point(304, 32);
            this.txtDetalleMarca.Name = "txtDetalleMarca";
            this.txtDetalleMarca.Size = new System.Drawing.Size(164, 20);
            this.txtDetalleMarca.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNuevo);
            this.panel1.Controls.Add(this.btnAlta);
            this.panel1.Location = new System.Drawing.Point(304, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 88);
            this.panel1.TabIndex = 14;
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
            this.label3.Text = "Nueva Marca";
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(480, 227);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMoficar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtDetalleMarca);
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
        private System.Windows.Forms.TextBox txtNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMoficar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtDetalleMarca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}