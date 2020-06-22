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

        /// <summary>
        /// al cargar el formulario carga automaticamente los box 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaVenta_Load(object sender, EventArgs e)
        {
            dtpFecha.MinDate = new DateTime(2010, 1, 1);
            dtpFecha.MaxDate = DateTime.Now;
            cargarBoxCliente(TrabajarCliente.ListaClienteD(true));
            cargarBoxVehiculo(TrabajarVehiculo.listarVehiculoDisponible(true));
            Form frmLogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmLogin);
            if (frmLogin != null)
            {
                txtDatosVendedor.Text = "Nombre y apellido: " + ((FrmLogin)frmLogin).user.Usu_ApellidoNombre + " ID: " + ((FrmLogin)frmLogin).user.Usu_NombreUsuario;
            }
            cargarForma();
        }
        /// <summary>
        /// carga los combobox vehiculo
        /// </summary>
        /// <param name="tablaVehiculo"></param>
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
        /// <summary>
        /// carga el combobox de cliente
        /// </summary>
        /// <param name="tablaCliente"></param>
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
        /// <summary>
        /// Registra la venta en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            try
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
                        if (nuevaVenta.Vta_PrecioFinal > 0)
                        {
                            if (mensaje(nuevaVenta) == DialogResult.OK)
                            {
                                TrabajarVenta.altaVenta(nuevaVenta);
                                limpiarCampos();
                                Form frmVenta = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmVenta);
                                ((FrmVenta)frmVenta).cargarVentas();
                                TrabajarVehiculo.bajaVehiculo(nuevaVenta.Veh_Matricula, false);
                            }
                            else
                            {
                                MessageBox.Show("Venta cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show("No puede Ingresar un Precio menor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Campos Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Espere unos momentos mientras se esta cargando la base de datos e intentelo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// carga el combo medio de pago
        /// </summary>
        public void cargarForma()
        {
            cmbMedioDePago.DisplayMember = "Descripcion";
            cmbMedioDePago.ValueMember = "ID";
            cmbMedioDePago.DataSource = TrabajarFormaPago.listarFormaPagoDisponible();
        }
        /// <summary>
        /// valida los campos
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Mensjae de confirmacion
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public DialogResult mensaje(Venta nueva)
        {
            DialogResult result = MessageBox.Show("Los Datos ingresados son correctos? " + "\n" +
                                                              "Cliente: " + cmbClientesDNI.Text + "\n" +
                                                              "Vehiculo: " + cmbVehiculos.Text + "\n" +
                                                              "Precio Final: " + txtPrecio.Text + "\n" +
                                                              "Forma de pago: " + cmbMedioDePago.Text + "\n",
                                                              "Desea registrar venta", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            return result;
        }
        /// <summary>
        /// retorna el primer valor del combobox
        /// </summary>
        /// <param name="textoCombo"></param>
        /// <returns></returns>
        private string primerValorCombobox(string textoCombo)
        {
            return textoCombo.Split('|')[0].TrimEnd();
        }
        /// <summary>
        /// limpia todos los campos del formulario
        /// </summary>
        private void limpiarCampos()
        {
            cmbClientesDNI.Text = "";
            cmbVehiculos.Text = "";
            dtpFecha.MinDate = new DateTime(2010, 1, 1);
            dtpFecha.MaxDate = DateTime.Now;
            cmbMedioDePago.Text = "";
            txtPrecio.Text = "";
        }
        /// <summary>
        /// carga la lista de clientes disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbClientesDNI_DropDown(object sender, EventArgs e)
        {
            cargarBoxCliente(TrabajarCliente.ListaClienteD(true));
        }
        /// <summary>
        /// busca los clientes mientras el usuario escribe en el combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbClientesDNI_TextUpdate(object sender, EventArgs e)
        {
            cargarBoxCliente(TrabajarCliente.buscarClienteDisponible(cmbClientesDNI.Text));
        }
        /// <summary>
        /// carga los vehiculos disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVehiculos_DropDown(object sender, EventArgs e)
        {
            cargarBoxVehiculo(TrabajarVehiculo.listarVehiculoDisponible(true));
        }
        /// <summary>
        /// pone un precio por defecto en el campo precio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] cadena = cmbVehiculos.Text.Split('|');
            txtPrecio.Text = cadena[8];
            txtPrecio.Text = txtPrecio.Text.TrimStart();
        }
        /// <summary>
        /// mientras que se escribe los datos del vehiculo se carga automaticamente el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVehiculos_TextUpdate(object sender, EventArgs e)
        {
            cargarBoxVehiculo(TrabajarVehiculo.buscarVehiculo(cmbVehiculos.Text));
        }
        /// <summary>
        /// validacion precio solo numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }
        /// <summary>
        /// refresca el combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMedioDePago_DropDown(object sender, EventArgs e)
        {
            cargarForma();
        }
    }
}
