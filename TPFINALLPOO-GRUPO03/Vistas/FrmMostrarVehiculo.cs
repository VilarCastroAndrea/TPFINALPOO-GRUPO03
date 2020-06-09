using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMostrarVehiculo : Form
    {
        public FrmMostrarVehiculo()
        {
            InitializeComponent();
        }

        private void FrmMostrarVehiculo_Load(object sender, EventArgs e)
        {
            cargarTipo();
            cargarClase();
        }
        public void determinarVistaGps(bool gps)
        {
            if (gps)
            {
                sGps.Checked = true;
            }
            else
            {
                nGps.Checked = true;
            }
        }


        private bool poseeGPS()
        {
            if (sGps.Checked)
            {
                return true;
            }
            return false;
        }
        private void btnMVehiculo_Click(object sender, System.EventArgs e)
        {
            Vehiculo v = new Vehiculo();
            Form frmVehiculo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmVehiculo);
            if (frmVehiculo != null)
            {
                v.Veh_Matricula = txtAMatricula.Text;
                v.Veh_Marca = cmbMarca.Text;
                v.Veh_Linea = txtALinea.Text;
                v.Veh_Modelo = Convert.ToInt32(cmbModelo.Text);
                v.Veh_Color = cmbColor.Text;
                v.Veh_Puertas = Convert.ToInt32(cmbCantPuert.Text);
                v.Tv_ID = Convert.ToInt32(cmbTipo.SelectedValue);
                v.Cv_ID = Convert.ToInt32(cmbClase.SelectedValue);
                v.Veh_GPS = poseeGPS();
                v.Veh_Precio = Convert.ToDecimal(txtAPrecio.Text);
                v.Veh_Disponible = true;
                TrabajarVehiculo.modificarVehiculo(v);

                MessageBox.Show("Vehiculo Modificado");
                ((FrmVehiculo)frmVehiculo).dataVehiculo.DataSource = TrabajarVehiculo.listarVehiculo();
            }
        }

        private void btnEVehiculo_Click(object sender, System.EventArgs e)
        {
            Form frmVehiculo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmVehiculo);
            if (frmVehiculo != null)
            {

                    try
                    {
                        TrabajarVehiculo.eliminarVehiculo(txtAMatricula.Text);
                        MessageBox.Show("Vehiculo Eliminado");
                        ((FrmVehiculo)frmVehiculo).dataVehiculo.DataSource = TrabajarVehiculo.listarVehiculo();
                    }
                    catch
                    {
                        MessageBox.Show("Vehiculo Vendido");
                    }

            }
        }

        public void limpiarCampos()
        {
            txtAMatricula.Text = "";
            cmbMarca.Text = "";
            txtALinea.Text = "";
        }

        public void cargarTipo()
        {
            cmbTipo.DisplayMember = "Descripcion";
            cmbTipo.ValueMember = "ID";
            cmbTipo.DataSource = TrabajarTipoVehiculo.listarTipoVehDisponible();
        }

        public void cargarClase()
        {
            cmbClase.DisplayMember = "Descripcion";
            cmbClase.ValueMember = "ID";
            cmbClase.DataSource = TrabajarClaseVehiculo.listarClaseVehDisponible();
        }

        private void txtALinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        private void txtAPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }
    }
}
