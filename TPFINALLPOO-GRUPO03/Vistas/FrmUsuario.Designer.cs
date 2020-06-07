namespace Vistas
{
    partial class FrmUsuario
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
            this.btnMostrarUsuario = new System.Windows.Forms.Button();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelListaCliente = new System.Windows.Forms.Panel();
            this.Buscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.panelListaCliente.SuspendLayout();
            this.Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarUsuario
            // 
            this.btnMostrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostrarUsuario.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.btnMostrarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnMostrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnMostrarUsuario.Location = new System.Drawing.Point(791, 22);
            this.btnMostrarUsuario.Name = "btnMostrarUsuario";
            this.btnMostrarUsuario.Size = new System.Drawing.Size(110, 38);
            this.btnMostrarUsuario.TabIndex = 32;
            this.btnMostrarUsuario.Text = "Mostrar";
            this.btnMostrarUsuario.UseVisualStyleBackColor = false;
            this.btnMostrarUsuario.Click += new System.EventHandler(this.btnMostrarUsuario_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.panelUsuario.Location = new System.Drawing.Point(791, 60);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(215, 399);
            this.panelUsuario.TabIndex = 30;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(905, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 38);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Nuevo Usuario";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panelListaCliente
            // 
            this.panelListaCliente.BackColor = System.Drawing.Color.Transparent;
            this.panelListaCliente.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.panelListaCliente.Controls.Add(this.Buscar);
            this.panelListaCliente.Controls.Add(this.dgvListaUsuarios);
            this.panelListaCliente.Location = new System.Drawing.Point(27, 22);
            this.panelListaCliente.Name = "panelListaCliente";
            this.panelListaCliente.Size = new System.Drawing.Size(758, 437);
            this.panelListaCliente.TabIndex = 29;
            // 
            // Buscar
            // 
            this.Buscar.Controls.Add(this.btnBuscar);
            this.Buscar.Controls.Add(this.txtBuscarUsuario);
            this.Buscar.ForeColor = System.Drawing.Color.White;
            this.Buscar.Location = new System.Drawing.Point(19, 13);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(239, 45);
            this.Buscar.TabIndex = 7;
            this.Buscar.TabStop = false;
            this.Buscar.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AllowDrop = true;
            this.btnBuscar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(208, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "B";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(6, 17);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(204, 20);
            this.txtBuscarUsuario.TabIndex = 2;
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuarios.Location = new System.Drawing.Point(19, 63);
            this.dgvListaUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.RowTemplate.Height = 24;
            this.dgvListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaUsuarios.Size = new System.Drawing.Size(721, 355);
            this.dgvListaUsuarios.TabIndex = 1;
            this.dgvListaUsuarios.CurrentCellChanged += new System.EventHandler(this.dgvListaUsuarios_CurrentCellChanged_1);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1005, 459);
            this.Controls.Add(this.btnMostrarUsuario);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.panelListaCliente);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.panelListaCliente.ResumeLayout(false);
            this.Buscar.ResumeLayout(false);
            this.Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarUsuario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Panel panelListaCliente;
        private System.Windows.Forms.GroupBox Buscar;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        public System.Windows.Forms.DataGridView dgvListaUsuarios;
        private System.Windows.Forms.Button btnBuscar;
    }
}