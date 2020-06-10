namespace Vistas
{
    partial class FrmLinea
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
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.checkDisponible = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMoficar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgwLista = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLista)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(3, 23);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(158, 20);
            this.txtNuevo.TabIndex = 8;
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
            // checkDisponible
            // 
            this.checkDisponible.AutoSize = true;
            this.checkDisponible.BackColor = System.Drawing.Color.Transparent;
            this.checkDisponible.ForeColor = System.Drawing.Color.White;
            this.checkDisponible.Location = new System.Drawing.Point(385, 8);
            this.checkDisponible.Name = "checkDisponible";
            this.checkDisponible.Size = new System.Drawing.Size(75, 17);
            this.checkDisponible.TabIndex = 23;
            this.checkDisponible.Text = "Disponible";
            this.checkDisponible.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nueva";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(299, 28);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(164, 20);
            this.txtDetalle.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(299, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Linea";
            // 
            // btnMoficar
            // 
            this.btnMoficar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMoficar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoficar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoficar.ForeColor = System.Drawing.Color.White;
            this.btnMoficar.Location = new System.Drawing.Point(299, 54);
            this.btnMoficar.Name = "btnMoficar";
            this.btnMoficar.Size = new System.Drawing.Size(164, 23);
            this.btnMoficar.TabIndex = 19;
            this.btnMoficar.Text = "Modificar";
            this.btnMoficar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(299, 83);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgwLista
            // 
            this.dgwLista.AllowUserToAddRows = false;
            this.dgwLista.AllowUserToDeleteRows = false;
            this.dgwLista.BackgroundColor = System.Drawing.Color.White;
            this.dgwLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLista.Location = new System.Drawing.Point(12, 12);
            this.dgwLista.Name = "dgwLista";
            this.dgwLista.ReadOnly = true;
            this.dgwLista.Size = new System.Drawing.Size(281, 201);
            this.dgwLista.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNuevo);
            this.panel1.Controls.Add(this.btnAlta);
            this.panel1.Location = new System.Drawing.Point(299, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 88);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Linea de Vehiculo";
            // 
            // FrmLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(478, 227);
            this.Controls.Add(this.checkDisponible);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMoficar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgwLista);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLinea";
            this.Text = "FrmLinea";
            ((System.ComponentModel.ISupportInitialize)(this.dgwLista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNuevo;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.CheckBox checkDisponible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMoficar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgwLista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}