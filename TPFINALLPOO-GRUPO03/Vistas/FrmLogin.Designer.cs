﻿namespace Vistas
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtResultadoCapcha = new System.Windows.Forms.TextBox();
            this.lblCapcha = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblInfoContra = new System.Windows.Forms.Label();
            this.lblnfoUsu = new System.Windows.Forms.Label();
            this.imgCapcha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapcha)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(17, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(16, 211);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // txtResultadoCapcha
            // 
            this.txtResultadoCapcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoCapcha.Location = new System.Drawing.Point(74, 276);
            this.txtResultadoCapcha.Name = "txtResultadoCapcha";
            this.txtResultadoCapcha.Size = new System.Drawing.Size(149, 21);
            this.txtResultadoCapcha.TabIndex = 17;
            // 
            // lblCapcha
            // 
            this.lblCapcha.AutoSize = true;
            this.lblCapcha.BackColor = System.Drawing.Color.Transparent;
            this.lblCapcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapcha.ForeColor = System.Drawing.Color.White;
            this.lblCapcha.Location = new System.Drawing.Point(137, 248);
            this.lblCapcha.Name = "lblCapcha";
            this.lblCapcha.Size = new System.Drawing.Size(86, 25);
            this.lblCapcha.TabIndex = 19;
            this.lblCapcha.Text = "Capcha";
            this.lblCapcha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(46, 214);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(177, 20);
            this.txtContra.TabIndex = 16;
            this.txtContra.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Location = new System.Drawing.Point(46, 173);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(177, 20);
            this.txtUsuario.TabIndex = 15;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Chocolate;
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIngresar.FlatAppearance.BorderSize = 25;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(16, 303);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(207, 23);
            this.btnIngresar.TabIndex = 18;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblInfoContra
            // 
            this.lblInfoContra.AutoSize = true;
            this.lblInfoContra.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoContra.ForeColor = System.Drawing.Color.White;
            this.lblInfoContra.Location = new System.Drawing.Point(50, 237);
            this.lblInfoContra.Name = "lblInfoContra";
            this.lblInfoContra.Size = new System.Drawing.Size(0, 13);
            this.lblInfoContra.TabIndex = 20;
            // 
            // lblnfoUsu
            // 
            this.lblnfoUsu.AutoSize = true;
            this.lblnfoUsu.BackColor = System.Drawing.Color.Transparent;
            this.lblnfoUsu.ForeColor = System.Drawing.Color.White;
            this.lblnfoUsu.Location = new System.Drawing.Point(50, 198);
            this.lblnfoUsu.Name = "lblnfoUsu";
            this.lblnfoUsu.Size = new System.Drawing.Size(0, 13);
            this.lblnfoUsu.TabIndex = 21;
            // 
            // imgCapcha
            // 
            this.imgCapcha.BackColor = System.Drawing.Color.Transparent;
            this.imgCapcha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgCapcha.BackgroundImage")));
            this.imgCapcha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgCapcha.Location = new System.Drawing.Point(17, 253);
            this.imgCapcha.Name = "imgCapcha";
            this.imgCapcha.Size = new System.Drawing.Size(51, 44);
            this.imgCapcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCapcha.TabIndex = 22;
            this.imgCapcha.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(239, 346);
            this.Controls.Add(this.imgCapcha);
            this.Controls.Add(this.lblnfoUsu);
            this.Controls.Add(this.lblInfoContra);
            this.Controls.Add(this.txtResultadoCapcha);
            this.Controls.Add(this.lblCapcha);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtResultadoCapcha;
        private System.Windows.Forms.Label lblCapcha;
        public System.Windows.Forms.TextBox txtContra;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblInfoContra;
        private System.Windows.Forms.Label lblnfoUsu;
        private System.Windows.Forms.PictureBox imgCapcha;
    }
}