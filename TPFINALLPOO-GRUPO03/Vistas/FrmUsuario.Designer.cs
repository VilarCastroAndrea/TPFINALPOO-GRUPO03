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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.btnMostrarUsuario = new System.Windows.Forms.Button();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelListaCliente = new System.Windows.Forms.Panel();
            this.Informacion = new System.Windows.Forms.GroupBox();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblAuditores = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lblAdministradores = new System.Windows.Forms.Label();
            this.lblVendedores = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.agenciaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelListaCliente.SuspendLayout();
            this.Informacion.SuspendLayout();
            this.Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaDataSetBindingSource)).BeginInit();
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
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelListaCliente.Controls.Add(this.Informacion);
            this.panelListaCliente.Controls.Add(this.Buscar);
            this.panelListaCliente.Controls.Add(this.dgvListaUsuarios);
            this.panelListaCliente.Location = new System.Drawing.Point(27, 22);
            this.panelListaCliente.Name = "panelListaCliente";
            this.panelListaCliente.Size = new System.Drawing.Size(758, 437);
            this.panelListaCliente.TabIndex = 29;
            // 
            // Informacion
            // 
            this.Informacion.Controls.Add(this.lblUsuarios);
            this.Informacion.Controls.Add(this.lblAuditores);
            this.Informacion.Controls.Add(this.lbl6);
            this.Informacion.Controls.Add(this.lblAdministradores);
            this.Informacion.Controls.Add(this.lblVendedores);
            this.Informacion.Controls.Add(this.lbl5);
            this.Informacion.Controls.Add(this.label7);
            this.Informacion.Controls.Add(this.lbl4);
            this.Informacion.ForeColor = System.Drawing.Color.White;
            this.Informacion.Location = new System.Drawing.Point(20, 399);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(720, 26);
            this.Informacion.TabIndex = 37;
            this.Informacion.TabStop = false;
            this.Informacion.Text = "Informacion de Usuarios";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(299, 10);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarios.TabIndex = 45;
            // 
            // lblAuditores
            // 
            this.lblAuditores.AutoSize = true;
            this.lblAuditores.Location = new System.Drawing.Point(666, 10);
            this.lblAuditores.Name = "lblAuditores";
            this.lblAuditores.Size = new System.Drawing.Size(0, 13);
            this.lblAuditores.TabIndex = 44;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.ForeColor = System.Drawing.Color.White;
            this.lbl6.Location = new System.Drawing.Point(606, 10);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(54, 13);
            this.lbl6.TabIndex = 43;
            this.lbl6.Text = "Auditores:";
            // 
            // lblAdministradores
            // 
            this.lblAdministradores.AutoSize = true;
            this.lblAdministradores.Location = new System.Drawing.Point(456, 10);
            this.lblAdministradores.Name = "lblAdministradores";
            this.lblAdministradores.Size = new System.Drawing.Size(0, 13);
            this.lblAdministradores.TabIndex = 41;
            // 
            // lblVendedores
            // 
            this.lblVendedores.AutoSize = true;
            this.lblVendedores.Location = new System.Drawing.Point(555, 10);
            this.lblVendedores.Name = "lblVendedores";
            this.lblVendedores.Size = new System.Drawing.Size(0, 13);
            this.lblVendedores.TabIndex = 42;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(482, 10);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(67, 13);
            this.lbl5.TabIndex = 36;
            this.lbl5.Text = "Vendedores:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(352, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Administradores:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(204, 10);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(89, 13);
            this.lbl4.TabIndex = 34;
            this.lbl4.Text = "Usuarios Totales:";
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
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(208, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBuscarUsuario.Location = new System.Drawing.Point(6, 17);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(204, 20);
            this.txtBuscarUsuario.TabIndex = 2;
            this.txtBuscarUsuario.Text = "Buscar Usuario";
            this.txtBuscarUsuario.Enter += new System.EventHandler(this.placeHolderUsuario_Enter);
            this.txtBuscarUsuario.Leave += new System.EventHandler(this.placeHolderUsuario_Leave);
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.AllowUserToAddRows = false;
            this.dgvListaUsuarios.AllowUserToDeleteRows = false;
            this.dgvListaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuarios.GridColor = System.Drawing.Color.DarkOrange;
            this.dgvListaUsuarios.Location = new System.Drawing.Point(19, 63);
            this.dgvListaUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.ReadOnly = true;
            this.dgvListaUsuarios.RowTemplate.Height = 24;
            this.dgvListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaUsuarios.Size = new System.Drawing.Size(721, 331);
            this.dgvListaUsuarios.TabIndex = 1;
            this.dgvListaUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaUsuarios_CellFormatting);
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
            this.Informacion.ResumeLayout(false);
            this.Informacion.PerformLayout();
            this.Buscar.ResumeLayout(false);
            this.Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource agenciaDataSetBindingSource;
        private System.Windows.Forms.GroupBox Informacion;
        private System.Windows.Forms.Label lblAdministradores;
        private System.Windows.Forms.Label lblVendedores;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblAuditores;
    }
}