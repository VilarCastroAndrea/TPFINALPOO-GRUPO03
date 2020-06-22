using ClasesBase;
using System;
using System.Data;
using System.Drawing;
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
        /// <summary>
        /// al cargar el formulario pone en el panel el formulario mostrar cliente y carga los clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarCliente>().FirstOrDefault();
            FrmMostrarCliente frmMostrarCliente = form ?? new FrmMostrarCliente();
            AddFormInPanel(frmMostrarCliente);
            cargarCliente();
        }

        /// <summary>
        /// restringe el acceso al usuario tipo vendedor
        /// </summary>
        public void restringirAcceso()
        {
            Form frmLogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmLogin);
            if (frmLogin != null)
            {
                if (((FrmLogin)frmLogin).user.Rol_Codigo == "Auditor")
                {
                    btnAgregar.Visible = false;
                    panelCliente.Enabled = false;
                }
                else
                {
                    btnAgregar.Visible = true;
                    panelCliente.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Carga de clietes
        /// </summary>
        public void cargarCliente()
        {
            dataCliente.DataSource = TrabajarCliente.ListaCliente();
            contar();
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


        /// <summary>
        /// carga los datos de la table con los clientes en el formulario frmMostrarCliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    ((FrmMostrarCliente)frmMostrarCliente).btnMCliente.Enabled = false;
                }
            }
        }


        /// <summary>
        /// realiza el orden de clientes por apellido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrdenApellido_Click(object sender, EventArgs e)
        {
            dataCliente.DataSource = TrabajarCliente.ListaClientesPorApellido();
            dataCliente.Refresh();
        }

        /// <summary>
        /// realiza la busqueda de cliente en la bd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarC.Text != "Buscar Cliente")
            {
                dataCliente.DataSource = TrabajarCliente.buscarCliente(txtBuscarC.Text);
            }
            else
            {
                cargarCliente();
            }
        }

        /// <summary>
        /// carga el formulario frmMostrarCliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarCliente>().FirstOrDefault();
            FrmMostrarCliente frmMostrarCliente = form ?? new FrmMostrarCliente();
            AddFormInPanel(frmMostrarCliente);
        }

        /// <summary>
        /// Carga el formulario frmAltaCliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmAltaCliente>().FirstOrDefault();
            FrmAltaCliente frmAltaCliente = form ?? new FrmAltaCliente();
            AddFormInPanel(frmAltaCliente);
        }

        /// <summary>
        /// cuenta vehiculos: vendidos.disponibles,total
        /// </summary>
        public void contar()
        {
            int t = dataCliente.Rows.Count;
            lblCliente.Text = Convert.ToString(t);

            int disponible = 0;

            foreach (DataGridViewRow fila in dataCliente.Rows)
            {
                if (fila.Cells[5].Value.Equals(true))
                {
                    disponible = disponible + 1;
                }

            }
            lblClienteDisponible.Text = Convert.ToString(disponible);
        }

        private void placeHolderCliente_Enter(object sender, EventArgs e)
        {
            if (txtBuscarC.Text == "Buscar Cliente")
            {
                txtBuscarC.Text = "";
                txtBuscarC.ForeColor = Color.Black;
            }
        }

        private void placeHolderCliente_Leave(object sender, EventArgs e)
        {
            if (txtBuscarC.Text == "")
            {
                txtBuscarC.Text = "Buscar Cliente";
                txtBuscarC.ForeColor = Color.Silver;
            }
        }
    }
}
