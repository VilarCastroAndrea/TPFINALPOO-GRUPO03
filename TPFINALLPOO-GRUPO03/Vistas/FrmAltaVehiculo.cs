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

        private void FrmAltaVehiculo_Load(object sender, EventArgs e)
        {
            cargarTipo();
            cargarClase();
        }

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
                Vehiculo vehiculo = new Vehiculo(txtAMatricula.Text, cmbMarca.Text, txtALinea.Text, m, cmbColor.Text, p, checkGps.Checked, tipo, clase, precio, true);
                if (vehiculo.Veh_GPS == true)
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
                                                       "Tipo de Vehiculo: " + vehiculo.Tv_ID + "\n" +
                                                       "Clase de Vehiculo: " + vehiculo.Cv_ID + "\n" +
                                                       "Precio: " + vehiculo.Veh_Precio, "Agregar Vehiculo", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    TrabajarVehiculo.altaVehiculo(vehiculo);

                    txtAMatricula.Text = "";
                    cmbMarca.Text = "";
                    txtALinea.Text = "";
                    cmbModelo.Text = "";
                    cmbColor.Text = "";
                    cmbCantPuert.Text = "";
                    checkGps.Checked = false;
                    cmbTipo.Text = "";
                    cmbClase.Text = "";
                    txtAPrecio.Text = "";
                    Form frmListaVehiculo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmVehiculo);
                    if (frmListaVehiculo != null)
                    {
                        ((FrmVehiculo)frmListaVehiculo).dataVehiculo.DataSource = null;
                        ((FrmVehiculo)frmListaVehiculo).dataVehiculo.DataSource = TrabajarVehiculo.listarVehiculo();
                    }
                }
                else
                {
                    MessageBox.Show("Se cancelo el alta del cliente", "Cancelado");
                    result = new DialogResult();
                }
            }
            else
            {
                MessageBox.Show("complete todos los campos");
            }
        }

        public void cargarTipo()
        {
            cmbTipo.DisplayMember = "Descripcion";
            cmbTipo.ValueMember = "ID";
            cmbTipo.DataSource = TrabajarVehiculo.listarTipoVehiculo();
        }

        public void cargarClase()
        {
            cmbClase.DisplayMember = "Descripcion";
            cmbClase.ValueMember = "ID";
            cmbClase.DataSource = TrabajarVehiculo.listarClaseVehiculo();
        }

    }
}
