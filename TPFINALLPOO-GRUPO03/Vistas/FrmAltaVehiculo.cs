using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmAltaVehiculo : Form
    {
        public FrmAltaVehiculo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// al cargar el formulario carga todos los tipos y las clases
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaVehiculo_Load(object sender, EventArgs e)
        {
            cargarTipo();
            cargarClase();
        }
        /// <summary>
        /// Determina si posee gps
        /// </summary>
        /// <returns></returns>
        private bool poseeGPS()
        {
            if (sGps.Checked)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        ///  Realiza el alta de vehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaVeh_Click(object sender, EventArgs e)
        {

            String opcionGPS = "No";
            if (cmbModelo.Text != "" && cmbCantPuert.Text != "" && cmbColor.Text != "" && txtALinea.Text != "" && cmbMarca.Text != "" && txtAMatricula.Text != "" && cmbTipo.Text != "" && txtAPrecio.Text != "" && cmbClase.Text != "")
            {
                int m = Convert.ToInt32(cmbModelo.Text);
                int p = Convert.ToInt32(cmbCantPuert.Text);
                Decimal precio = Convert.ToDecimal(txtAPrecio.Text);
                int tipo = Convert.ToInt32(cmbTipo.SelectedValue);
                int clase = Convert.ToInt32(cmbClase.SelectedValue);
                Vehiculo vehiculo = new Vehiculo(txtAMatricula.Text, cmbMarca.Text, txtALinea.Text, m, cmbColor.Text, p, poseeGPS(), tipo, clase, precio, true);
                if (poseeGPS())
                {
                    opcionGPS = "Si";
                }
                DialogResult result = MessageBox.Show("Los Datos ingresados son correctos? " + "\n" +
                                                       "Matricula: " + vehiculo.Veh_Matricula + "\n" +
                                                       "Marca: " + vehiculo.Veh_Marca + "\n" +
                                                       "Linea: " + vehiculo.Veh_Linea + "\n" +
                                                       "Modelo: " + vehiculo.Veh_Modelo + "\n" +
                                                       "Color: " + vehiculo.Veh_Color + "\n" +
                                                       "Puertas: " + vehiculo.Veh_Puertas + "\n" +
                                                       "GPS: " + opcionGPS + "\n" +
                                                       "Tipo de Vehiculo: " + this.cmbTipo.Text + "\n" +
                                                       "Clase de Vehiculo: " + this.cmbClase.Text + "\n" +
                                                       "Precio: " + vehiculo.Veh_Precio, "Agregar Vehiculo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

                try
                {
                    if (result == DialogResult.OK)
                    {
                        TrabajarVehiculo.altaVehiculo(vehiculo);

                        txtAMatricula.Text = "";
                        cmbMarca.Text = "";
                        txtALinea.Text = "";
                        cmbModelo.Text = "";
                        cmbColor.Text = "";
                        cmbCantPuert.Text = "";
                        sGps.Checked = false;
                        nGps.Checked = false;
                        cmbTipo.Text = "";
                        cmbClase.Text = "";
                        txtAPrecio.Text = "";
                        Form frmListaVehiculo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmVehiculo);
                        if (frmListaVehiculo != null)
                        {
                            ((FrmVehiculo)frmListaVehiculo).dataVehiculo.DataSource = null;
                            ((FrmVehiculo)frmListaVehiculo).dataVehiculo.DataSource = TrabajarVehiculo.listarVehiculo();
                            ((FrmVehiculo)frmListaVehiculo).contar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Se cancelo el alta del Vehiculo", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        result = new DialogResult();
                    }
                }
                catch
                {
                    MessageBox.Show("Ya existe un vehiculo con la matricula ingresada", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAMatricula.Text = "";
                    txtAMatricula.Focus();
                }

            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// carga los tipos de vehiculos
        /// </summary>
        public void cargarTipo()
        {
            cmbTipo.DisplayMember = "Descripcion";
            cmbTipo.ValueMember = "ID";
            cmbTipo.DataSource = TrabajarTipoVehiculo.listarTipoVehDisponible();
        }
        /// <summary>
        /// carga las clases de vehiculo
        /// </summary>
        public void cargarClase()
        {
            cmbClase.DisplayMember = "Descripcion";
            cmbClase.ValueMember = "ID";
            cmbClase.DataSource = TrabajarClaseVehiculo.listarClaseVehDisponible();
        }



        /// <summary>
        /// validacion matricula maxima de 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtAMatricula.MaxLength = 7;

        }

        /// <summary>
        /// Valida el que el campo precio solo tenga numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        /// <summary>
        /// refresca el combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTipo_DropDown(object sender, EventArgs e)
        {
            cargarTipo();
        }
        /// <summary>
        /// refresca el combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbClase_DropDown(object sender, EventArgs e)
        {
            cargarClase();
        }
        /// <summary>
        /// valida solo numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }
        /// <summary>
        /// valida solo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }
        /// <summary>
        /// valida solo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCantPuert_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }
    }
}
