﻿using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
        //al cargar el formulario pone en el panel el formulario mostrar cliente y carga los clientes
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarCliente>().FirstOrDefault();
            FrmMostrarCliente frmMostrarCliente = form ?? new FrmMostrarCliente();
            AddFormInPanel(frmMostrarCliente);
            cargarCliente();
        }

        //restringe el acceso al usuario tipo vendedor
        public void restringirAcceso()
        {
            Form frmLogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmLogin);
            if (frmLogin != null)
            {
                if (((FrmLogin)frmLogin).user.Rol_Codigo != "Vendedor")
                {
                    btnMostrar.Visible = false;
                    btnAgregar.Visible = false;
                    panelCliente.Visible = false;
                }
                else
                {
                    btnMostrar.Visible = true;
                    btnAgregar.Visible = true;
                    panelCliente.Visible = true;
                }
            }
        }

        /// <summary>
        /// Carga de clietes
        /// </summary>
        public void cargarCliente()
        {
            dataCliente.DataSource = TrabajarCliente.ListaCliente();
        }

        /// <summary>
        /// Llamada a sub frmulario
        /// </summary>
        /// <param name="fh"></param>
        private void AddFormInPanel(Form fh)
        {
            if (this.panelCliente.Controls.Count > 0)
                this.panelCliente.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelCliente.Controls.Add(fh);
            this.panelCliente.Tag = fh;
            fh.Show();
        }


        //carga los datos de la table con los clientes en el formulario frmMostrarCliente
        private void dataCliente_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataCliente.CurrentRow != null)
            {
                FrmMostrarCliente mc = new FrmMostrarCliente();
                Form frmMostrarCliente = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmMostrarCliente);
                if (frmMostrarCliente != null)
                {
                    ((FrmMostrarCliente)frmMostrarCliente).txtDni.Text = dataCliente.CurrentRow.Cells["Dni"].Value.ToString();
                    ((FrmMostrarCliente)frmMostrarCliente).txtNombre.Text = dataCliente.CurrentRow.Cells["Nombre"].Value.ToString();
                    ((FrmMostrarCliente)frmMostrarCliente).txtApellido.Text = dataCliente.CurrentRow.Cells["Apellido"].Value.ToString();
                    ((FrmMostrarCliente)frmMostrarCliente).txtDireccion.Text = dataCliente.CurrentRow.Cells["Direccion"].Value.ToString();
                    ((FrmMostrarCliente)frmMostrarCliente).txtTelefono.Text = dataCliente.CurrentRow.Cells["Telefono"].Value.ToString();
                    ((FrmMostrarCliente)frmMostrarCliente).disponibilidadDelCliente(Convert.ToBoolean(dataCliente.CurrentRow.Cells["Disponible"].Value));
                }
            }
        }


        //realiza el orden de clientes por apellido
        private void btnOrdenApellido_Click(object sender, EventArgs e)
        {
            dataCliente.DataSource = TrabajarCliente.ListaClientesPorApellido();
            dataCliente.Refresh();
        }

        //realiza la busqueda de cliente en la bd
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarC.Text != "")
            {
                dataCliente.DataSource = TrabajarCliente.buscarCliente(txtBuscarC.Text);
            }
            else
            {
                cargarCliente();
            }
        }

        //carga el formulario frmMostrarCliente
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarCliente>().FirstOrDefault();
            FrmMostrarCliente frmMostrarCliente = form ?? new FrmMostrarCliente();
            AddFormInPanel(frmMostrarCliente);
        }

        //Carga el formulario frmAltaCliente
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmAltaCliente>().FirstOrDefault();
            FrmAltaCliente frmAltaCliente = form ?? new FrmAltaCliente();
            AddFormInPanel(frmAltaCliente);
        }
    }
}
