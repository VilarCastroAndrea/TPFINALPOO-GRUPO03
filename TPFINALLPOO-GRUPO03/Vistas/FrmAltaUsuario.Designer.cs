namespace Vistas
{
    partial class FrmAltaUsuario
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
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblNombreApellidoUsuario = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreApellidoUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAgregarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(24, 301);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(171, 23);
            this.btnAgregarUsuario.TabIndex = 35;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // cmbRoles
            // 
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(24, 212);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(171, 21);
            this.cmbRoles.TabIndex = 34;
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRolUsuario.Location = new System.Drawing.Point(21, 196);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(23, 13);
            this.lblRolUsuario.TabIndex = 39;
            this.lblRolUsuario.Text = "Rol";
            // 
            // lblNombreApellidoUsuario
            // 
            this.lblNombreApellidoUsuario.AutoSize = true;
            this.lblNombreApellidoUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreApellidoUsuario.Location = new System.Drawing.Point(21, 147);
            this.lblNombreApellidoUsuario.Name = "lblNombreApellidoUsuario";
            this.lblNombreApellidoUsuario.Size = new System.Drawing.Size(92, 13);
            this.lblNombreApellidoUsuario.TabIndex = 38;
            this.lblNombreApellidoUsuario.Text = "Apellido y Nombre";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPass.Location = new System.Drawing.Point(21, 95);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 13);
            this.lblPass.TabIndex = 37;
            this.lblPass.Text = "Contraseña";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreUsuario.Location = new System.Drawing.Point(21, 45);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(83, 13);
            this.lblNombreUsuario.TabIndex = 36;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // txtNombreApellidoUsuario
            // 
            this.txtNombreApellidoUsuario.Location = new System.Drawing.Point(24, 163);
            this.txtNombreApellidoUsuario.Name = "txtNombreApellidoUsuario";
            this.txtNombreApellidoUsuario.Size = new System.Drawing.Size(171, 20);
            this.txtNombreApellidoUsuario.TabIndex = 33;
            this.txtNombreApellidoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreApellidoUsuario_KeyPress_1);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(24, 61);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(171, 20);
            this.txtNombreUsuario.TabIndex = 31;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(24, 111);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(171, 20);
            this.txtPass.TabIndex = 32;
            // 
            // FrmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(209, 357);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.lblRolUsuario);
            this.Controls.Add(this.lblNombreApellidoUsuario);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.txtNombreApellidoUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtPass);
            this.Name = "FrmAltaUsuario";
            this.Text = "FrmAltaUsuario";
            this.Load += new System.EventHandler(this.FrmAltaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblNombreApellidoUsuario;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreApellidoUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtPass;
    }
}