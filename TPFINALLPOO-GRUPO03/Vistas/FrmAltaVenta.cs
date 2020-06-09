using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmAltaVenta : Form
    {
        public FrmAltaVenta()
        {
            InitializeComponent();
        }

        private void FrmAltaVenta_Load(object sender, EventArgs e)
        {
            cargarBoxCliente(TrabajarCliente.ListaClienteD(true));
            cargarBoxVehiculo(TrabajarVehiculo.listarVehiculoDisponible(true));
            Form frmLogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmLogin);
            if (frmLogin != null)
            {
                txtDatosVendedor.Text = "Nombre y apellido: " + ((FrmLogin)frmLogin).user.Usu_ApellidoNombre + " ID: " + ((FrmLogin)frmLogin).user.Usu_NombreUsuario;
            }
            cargarForma();
        }

        private void cargarBoxVehiculo(DataTable tablaVehiculo)
        {
            cmbVehiculos.Items.Clear();
            cmbVehiculos.SelectionStart = cmbVehiculos.Text.Length;
            for (int i = 0; i < tablaVehiculo.Rows.Count; i++)
            {
                cmbVehiculos.Items.Add(tablaVehiculo.Rows[i]["Matricula"].ToString() + " | " +
                    tablaVehiculo.Rows[i]["Marca"].ToString() + " | " + tablaVehiculo.Rows[i]["Linea"].ToString()
                    + " | " + tablaVehiculo.Rows[i]["Modelo"].ToString() + " | " + tablaVehiculo.Rows[i]["Color"].ToString()
                    + " | " + tablaVehiculo.Rows[i]["Puertas"].ToString() + " | " + tablaVehiculo.Rows[i]["Tipo"].ToString()
                    + " | " + tablaVehiculo.Rows[i]["Clase"].ToString() + " | " + tablaVehiculo.Rows[i]["Precio"].ToString());
            }
        }

        private void cargarBoxCliente(DataTable tablaCliente)
        {
            cmbClientesDNI.Items.Clear();
            cmbClientesDNI.SelectionStart = cmbClientesDNI.Text.Length;
            for (int i = 0; i < tablaCliente.Rows.Count; i++)
            {
                cmbClientesDNI.Items.Add(tablaCliente.Rows[i]["DNI"].ToString() + " | " +
                    tablaCliente.Rows[i]["Nombre"].ToString() + " | " + tablaCliente.Rows[i]["Apellido"].ToString());
            }
        }

        private void cmbClientesDNI_DropDown(object sender, EventArgs e)
        {
            cargarBoxCliente(TrabajarCliente.ListaClienteD(true));
        }

        private void cmbClientesDNI_TextUpdate(object sender, EventArgs e)
        {
            cargarBoxCliente(TrabajarCliente.buscarClienteDisponible(cmbClientesDNI.Text));
        }

        private void cmbVehiculos_DropDown(object sender, EventArgs e)
        {
            cargarBoxVehiculo(TrabajarVehiculo.listarVehiculoDisponible(true));
        }

        private void cmbVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] cadena = cmbVehiculos.Text.Split('|');
            txtPrecio.Text = cadena[8];
            txtPrecio.Text = txtPrecio.Text.TrimStart();
        }

        private void cmbVehiculos_TextUpdate(object sender, EventArgs e)
        {
            cargarBoxVehiculo(TrabajarVehiculo.buscarVehiculo(cmbVehiculos.Text));
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int forma = Convert.ToInt32(cmbMedioDePago.SelectedValue);
            if (validarCampos())
            {
                Venta nuevaVenta = new Venta();
                nuevaVenta.Cli_DNI = primerValorCombobox(cmbClientesDNI.Text);
                nuevaVenta.Veh_Matricula = primerValorCombobox(cmbVehiculos.Text);
                nuevaVenta.Vta_Fecha = dtpFecha.Value;
                Form frmLogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmLogin);
                if (frmLogin != null)
                {
                    nuevaVenta.Usu_ID = ((FrmLogin)frmLogin).user.Usu_ID;
                    nuevaVenta.Fp_ID = forma;
                    nuevaVenta.Vta_PrecioFinal = Convert.ToDecimal(txtPrecio.Text);
                    TrabajarVenta.altaVenta(nuevaVenta);
                    limpiarCampos();
                    Form frmVenta = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmVenta);
                    ((FrmVenta)frmVenta).cargarVentas();
                    TrabajarVehiculo.bajaVehiculo(nuevaVenta.Veh_Matricula, false);

                }
            }
            else
            {
                MessageBox.Show("alerta");
            }
        }

        public void cargarForma()
        {
            cmbMedioDePago.DisplayMember = "Descripcion";
            cmbMedioDePago.ValueMember = "ID";
            cmbMedioDePago.DataSource = TrabajarFormaPago.listarFormaPagoDisponible();
        }


        private bool validarCampos()
        {
            if (cmbClientesDNI.Text != "" && cmbClientesDNI.Text.Split('|').Length == 3)
            {
                if (cmbVehiculos.Text != "" && cmbVehiculos.Text.Split('|').Length == 9)
                {
                    if (cmbMedioDePago.Text != "" || cmbMedioDePago.Text == "Tarjeta De Credito" ||
                        cmbMedioDePago.Text == "Efectivo" || cmbMedioDePago.Text == "Credito Personal")
                    {
                        if (txtPrecio.Text != "")
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private string primerValorCombobox(string textoCombo)
        {
            return textoCombo.Split('|')[0].TrimEnd();
        }

        private void limpiarCampos()
        {
            cmbClientesDNI.Text = "";
            cmbVehiculos.Text = "";
            dtpFecha.Value = DateTime.Now;
            cmbMedioDePago.Text = "";
            txtPrecio.Text = "";
        }
    }
}
