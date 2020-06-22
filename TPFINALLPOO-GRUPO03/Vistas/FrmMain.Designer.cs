namespace Vistas
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContenedorPrincipar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnVehiculo = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.panel1.Controls.Add(this.panelContenedorPrincipar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnVenta);
            this.panel1.Controls.Add(this.btnVehiculo);
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblNom);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 474);
            this.panel1.TabIndex = 0;
            // 
            // panelContenedorPrincipar
            // 
            this.panelContenedorPrincipar.Location = new System.Drawing.Point(202, 0);
            this.panelContenedorPrincipar.Name = "panelContenedorPrincipar";
            this.panelContenedorPrincipar.Size = new System.Drawing.Size(1011, 474);
            this.panelContenedorPrincipar.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(0, 378);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(196, 35);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar sesion";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 337);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(196, 35);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.White;
            this.btnVenta.Location = new System.Drawing.Point(0, 296);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(196, 35);
            this.btnVenta.TabIndex = 12;
            this.btnVenta.Text = "Venta";
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnVehiculo.Location = new System.Drawing.Point(0, 255);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(196, 35);
            this.btnVehiculo.TabIndex = 11;
            this.btnVehiculo.Text = "Vehiculo";
            this.btnVehiculo.UseVisualStyleBackColor = false;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Location = new System.Drawing.Point(0, 214);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(196, 35);
            this.btnCliente.TabIndex = 10;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(0, 173);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(196, 35);
            this.btnUsuario.TabIndex = 9;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(3, 426);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(43, 17);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(4, 452);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.ForeColor = System.Drawing.Color.White;
            this.lblNom.Location = new System.Drawing.Point(3, 152);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(43, 13);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Vistas.Properties.Resources.log;
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(189, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1033, 474);
            this.panel2.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1214, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelContenedorPrincipar;
        public System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnVehiculo;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
    }
}