using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Vistas
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }


        /// <summary>
        /// restringe acceso segun usuario
        /// </summary>
        public void restringirAcceso()
        {
            Form frmLogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmLogin);
            if (frmLogin != null)
            {
                if (((FrmLogin)frmLogin).user.Rol_Codigo == "Auditor")
                {
                    btnFp.Visible = false;
                    btnRegistrarVenta.Visible = false;
                    panelVenta.Enabled = false;
                }
                else
                {
                    if (((FrmLogin)frmLogin).user.Rol_Codigo == "Vendedor")
                    {
                        btnFp.Visible = false;
                    }
                    btnRegistrarVenta.Visible = true;
                    panelVenta.Enabled = true;
                }
            }
        }
        /// <summary>
        /// eventos al cargar el formulario venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarVenta>().FirstOrDefault();
            FrmMostrarVenta frmVenta = form ?? new FrmMostrarVenta();
            frmVenta.restringirAcceso();
            AddFormInPanel(frmVenta);
            cargarVentas();
            cargarBoxCliente(TrabajarCliente.ListaCliente());
            cargarBoxMarca(TrabajarVehiculo.listaXMarca());
            dtpDesde.MinDate = new DateTime(2010, 1, 1);
            dtpDesde.MaxDate = DateTime.Today;
            dtpHasta.MinDate = new DateTime(2010, 1, 1);
            dtpHasta.MaxDate = DateTime.Today;
            contar();
        }
        /// <summary>
        /// lista las ventas en la tabla
        /// </summary>
        public void cargarVentas()
        {
            dataVenta.DataSource = TrabajarVenta.listarVenta();
            contar();
        }
        /// <summary>
        /// agregar formulario a un panel
        /// </summary>
        /// <param name="fh"></param>
        private void AddFormInPanel(Form fh)
        {
            if (this.panelVenta.Controls.Count > 0)
                this.panelVenta.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelVenta.Controls.Add(fh);
            this.panelVenta.Tag = fh;
            fh.Show();
        }
        /// <summary>
        /// cuenta las ventas 
        /// </summary>
        private void contar()
        {
            int t = dataVenta.Rows.Count;
            Total.Text = Convert.ToString(t);
            int an = 0;
            decimal to = 0;
            decimal p = 0;

            foreach (DataGridViewRow fila in dataVenta.Rows)
            {
                String a = null;
                a = Convert.ToString(fila.Cells["Estado de la Venta"].Value);
                if (a.Equals("ANULADA"))
                {
                    an = an + 1;
                }
                else
                {
                    p = Convert.ToDecimal(fila.Cells["Precio Final"].Value);
                    to = to + p;
                }
            }
            anuladas.Text = Convert.ToString(an);
            ingreso.Text = to.ToString("N2") + "$";
        }

        /// <summary>
        /// Carga una lista con clientes
        /// </summary>
        /// <param name="tablaCliente"></param>
        private void cargarBoxCliente(DataTable tablaCliente)
        {
            cmbClientes.Items.Clear();
            cmbClientes.SelectionStart = cmbClientes.Text.Length;
            for (int i = 0; i < tablaCliente.Rows.Count; i++)
            {
                cmbClientes.Items.Add(tablaCliente.Rows[i]["DNI"].ToString() + " | " +
                    tablaCliente.Rows[i]["Nombre"].ToString() + " | " + tablaCliente.Rows[i]["Apellido"].ToString());
            }
        }

        /// <summary>
        /// Carga una lista de marca
        /// </summary>
        /// <param name="tablaVehiculo"></param>
        private void cargarBoxMarca(DataTable tablaVehiculo)
        {
            cmbMarca.Items.Clear();
            cmbMarca.SelectionStart = cmbMarca.Text.Length;
            for (int i = 0; i < tablaVehiculo.Rows.Count; i++)
            {
                cmbMarca.Items.Add(tablaVehiculo.Rows[i][0].ToString());
            }
        }
        /// <summary>
        /// obtiene el primer valor del combobox (clave primaria)
        /// </summary>
        /// <param name="textoCombo"></param>
        /// <returns></returns>
        private string primerValorCombobox(string textoCombo)
        {
            return textoCombo.Split('|')[0].TrimEnd();
        }
        /// <summary>
        /// busqueda por clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbClientes_TextUpdate(object sender, EventArgs e)
        {
            cargarBoxCliente(TrabajarCliente.buscarCliente(cmbClientes.Text));
        }
        /// <summary>
        /// busqueda por marca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBusacar_Click(object sender, EventArgs e)
        {
            dataVenta.DataSource = TrabajarVenta.buscarVenta(cmbMarca.Text, primerValorCombobox(cmbClientes.Text), dtpDesde.Value, dtpHasta.Value);
            contar();
        }
        /// <summary>
        /// Muestra el formulario de alta de ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmAltaVenta>().FirstOrDefault();
            FrmAltaVenta frmAltaVenta = form ?? new FrmAltaVenta();
            AddFormInPanel(frmAltaVenta);
        }
        /// <summary>
        /// carga en el panel el formulario FrmMostrarVenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarVenta>().FirstOrDefault();
            FrmMostrarVenta frmVenta = form ?? new FrmMostrarVenta();
            frmVenta.restringirAcceso();
            AddFormInPanel(frmVenta);
        }
        /// <summary>
        /// Muestra una venta seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataVenta_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataVenta.CurrentRow != null)
            {
                FrmMostrarVenta mv = new FrmMostrarVenta();
                Form frmMostrar = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmMostrarVenta);
                if (frmMostrar != null)
                {
                    ((FrmMostrarVenta)frmMostrar).id.Text = dataVenta.CurrentRow.Cells["ID Venta"].Value.ToString();
                    ((FrmMostrarVenta)frmMostrar).dni.Text = dataVenta.CurrentRow.Cells["DNI"].Value.ToString();
                    ((FrmMostrarVenta)frmMostrar).apellido.Text = dataVenta.CurrentRow.Cells["Apellido"].Value.ToString();
                    ((FrmMostrarVenta)frmMostrar).nombre.Text = dataVenta.CurrentRow.Cells["Nombre"].Value.ToString();
                    ((FrmMostrarVenta)frmMostrar).telefono.Text = dataVenta.CurrentRow.Cells["Telefono"].Value.ToString();
                    ((FrmMostrarVenta)frmMostrar).matricula.Text = dataVenta.CurrentRow.Cells["Matricula"].Value.ToString();
                    ((FrmMostrarVenta)frmMostrar).marca.Text = dataVenta.CurrentRow.Cells["Marca"].Value.ToString();
                    ((FrmMostrarVenta)frmMostrar).linea.Text = dataVenta.CurrentRow.Cells["Linea"].Value.ToString();
                    ((FrmMostrarVenta)frmMostrar).modelo.Text = dataVenta.CurrentRow.Cells["Modelo"].Value.ToString();
                    ((FrmMostrarVenta)frmMostrar).color.Text = dataVenta.CurrentRow.Cells["Color"].Value.ToString();
                    ((FrmMostrarVenta)frmMostrar).tipo.Text = dataVenta.CurrentRow.Cells["Tipo de Vehiculo"].Value.ToString();
                    ((FrmMostrarVenta)frmMostrar).clase.Text = dataVenta.CurrentRow.Cells["Clase de Vehiculo"].Value.ToString();
                    ((FrmMostrarVenta)frmMostrar).aynv.Text = dataVenta.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();
                    ((FrmMostrarVenta)frmMostrar).fecha.Text = dataVenta.CurrentRow.Cells["Fecha de Venta"].Value.ToString();
                    ((FrmMostrarVenta)frmMostrar).forma.Text = dataVenta.CurrentRow.Cells["Forma de Pago"].Value.ToString();
                    ((FrmMostrarVenta)frmMostrar).precio.Text = dataVenta.CurrentRow.Cells["Precio Final"].Value.ToString() + " $";
                    ((FrmMostrarVenta)frmMostrar).estado.Text = dataVenta.CurrentRow.Cells["Estado de la Venta"].Value.ToString();
                    ((FrmMostrarVenta)frmMostrar).actualizarBotonAnular();
                }
            }
        }
        /// <summary>
        /// abre el formulario forma de pago
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFp_Click(object sender, EventArgs e)
        {
            FrmFormaPago frmFormaPago = new FrmFormaPago();
            frmFormaPago.Show();
        }

        private void Informacion_Enter(object sender, EventArgs e)
        {

        }
    }
}
