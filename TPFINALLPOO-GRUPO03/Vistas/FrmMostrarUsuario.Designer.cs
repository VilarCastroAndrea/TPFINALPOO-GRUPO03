namespace Vistas
{
    partial class FrmMostrarUsuario
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
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblNombreApellidoUsuario = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreApellidoUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(19, 313);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(171, 23);
            this.btnEliminarUsuario.TabIndex = 35;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.BackColor = System.Drawing.Color.DarkOrange;
            this.btnActualizarUsuario.Enabled = false;
            this.btnActualizarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnActualizarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnActualizarUsuario.Location = new System.Drawing.Point(19, 284);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(171, 23);
            this.btnActualizarUsuario.TabIndex = 34;
            this.btnActualizarUsuario.Text = "Modificar Usuario";
            this.btnActualizarUsuario.UseVisualStyleBackColor = false;
            this.btnActualizarUsuario.Click += new System.EventHandler(this.btnActualizarUsuario_Click);
            // 
            // cmbRoles
            // 
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(19, 210);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(171, 21);
            this.cmbRoles.TabIndex = 29;
            this.cmbRoles.SelectedIndexChanged += new System.EventHandler(this.cmbRoles_SelectedIndexChanged);
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblRolUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRolUsuario.Location = new System.Drawing.Point(16, 194);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(23, 13);
            this.lblRolUsuario.TabIndex = 33;
            this.lblRolUsuario.Text = "Rol";
            // 
            // lblNombreApellidoUsuario
            // 
            this.lblNombreApellidoUsuario.AutoSize = true;
            this.lblNombreApellidoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreApellidoUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreApellidoUsuario.Location = new System.Drawing.Point(16, 143);
            this.lblNombreApellidoUsuario.Name = "lblNombreApellidoUsuario";
            this.lblNombreApellidoUsuario.Size = new System.Drawing.Size(92, 13);
            this.lblNombreApellidoUsuario.TabIndex = 32;
            this.lblNombreApellidoUsuario.Text = "Apellido y Nombre";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPass.Location = new System.Drawing.Point(16, 93);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 13);
            this.lblPass.TabIndex = 31;
            this.lblPass.Text = "Contraseña";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreUsuario.Location = new System.Drawing.Point(16, 43);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(83, 13);
            this.lblNombreUsuario.TabIndex = 30;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // txtNombreApellidoUsuario
            // 
            this.txtNombreApellidoUsuario.Location = new System.Drawing.Point(19, 159);
            this.txtNombreApellidoUsuario.Name = "txtNombreApellidoUsuario";
            this.txtNombreApellidoUsuario.Size = new System.Drawing.Size(171, 20);
            this.txtNombreApellidoUsuario.TabIndex = 28;
            this.txtNombreApellidoUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreApellidoUsuario_KeyDown);
            this.txtNombreApellidoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreApellidoUsuario_KeyPress);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Location = new System.Drawing.Point(19, 59);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(171, 20);
            this.txtNombreUsuario.TabIndex = 26;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(19, 109);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(171, 20);
            this.txtPass.TabIndex = 27;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(19, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(171, 20);
            this.txtId.TabIndex = 36;
            this.txtId.Visible = false;
            // 
            // FrmMostrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(209, 357);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnActualizarUsuario);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.lblRolUsuario);
            this.Controls.Add(this.lblNombreApellidoUsuario);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.txtNombreApellidoUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtPass);
            this.Name = "FrmMostrarUsuario";
            this.Text = "FrmMostrarUsuario";
            this.Load += new System.EventHandler(this.FrmMostrarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarUsuario;
        public System.Windows.Forms.Button btnActualizarUsuario;
        public System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblNombreApellidoUsuario;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblNombreUsuario;
        public System.Windows.Forms.TextBox txtNombreApellidoUsuario;
        public System.Windows.Forms.TextBox txtNombreUsuario;
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.TextBox txtId;
    }
}
