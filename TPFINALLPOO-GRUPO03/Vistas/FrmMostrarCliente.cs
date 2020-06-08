﻿using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMostrarCliente : Form
    {
        public FrmMostrarCliente()
        {
            InitializeComponent();
        }

        private void btnMCliente_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            Form frmCliente = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmCliente);
            if (frmCliente != null)
            {
                c.Cli_DNI = txtDni.Text;
                c.Cli_Nombre = txtNombre.Text;
                c.Cli_Apellido = txtApellido.Text;
                c.Cli_Direccion = txtDireccion.Text;
                c.Cli_Telefono = txtTelefono.Text;
                TrabajarCliente.modificarCliente(c);
                MessageBox.Show("Cliente Modificado");
                ((FrmCliente)frmCliente).cargarCliente();
            }
        }

        private void btnECliente_Click(object sender, EventArgs e)
        {
            Form frmCliente = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmCliente);
            String msj = "Esta seguro que quiere elimnar " + this.txtDni.Text;
            int id = Convert.ToInt32(txtDni.Text);
            DialogResult dialogResult = MessageBox.Show(msj, "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (frmCliente != null)
                {
                    TrabajarCliente.bajaCliente(txtDni.Text, false);
                    MessageBox.Show("Cliente Eliminado");
                    ((FrmCliente)frmCliente).cargarCliente();
                }
                MessageBox.Show("Eliminado");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }
    }
}
