using ClasesBase;
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

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarCliente>().FirstOrDefault();
            FrmMostrarCliente frmMostrarCliente = form ?? new FrmMostrarCliente();
            AddFormInPanel(frmMostrarCliente);
            cargarCliente();
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

        private void btnOrdenApellido_Click(object sender, EventArgs e)
        {
            dataCliente.DataSource = TrabajarCliente.ListaClientesPorApellido();
            dataCliente.Refresh();
        }

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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarCliente>().FirstOrDefault();
            FrmMostrarCliente frmMostrarCliente = form ?? new FrmMostrarCliente();
            AddFormInPanel(frmMostrarCliente);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmAltaCliente>().FirstOrDefault();
            FrmAltaCliente frmAltaCliente = form ?? new FrmAltaCliente();
            AddFormInPanel(frmAltaCliente);
        }
    }
}
