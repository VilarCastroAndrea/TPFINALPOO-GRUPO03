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
        /// <summary>
        /// carga los tipos y clases de vehiculos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMostrarVehiculo_Load(object sender, EventArgs e)
        {
            cargarTipo();
            cargarClase();
        }

        /// <summary>
        /// determina la ubicacion del check al traerlo de un formulario anterior
        /// </summary>
        /// <param name="gps"></param>
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

        /// <summary>
        /// Habilita o Deshabilita los campos
        /// </summary>
        /// <param name="disponible"></param>
        public void habilitarDesabilitarCampos(bool disponible)
        {
            cmbMarca.Enabled = disponible;
            txtALinea.Enabled = disponible;
            cmbModelo.Enabled = disponible;
            cmbColor.Enabled = disponible;
            cmbCantPuert.Enabled = disponible;
            cmbTipo.Enabled = disponible;
            cmbClase.Enabled = disponible;
            txtAPrecio.Enabled = disponible;
            btnMVehiculo.Enabled = disponible;
            btnEVehiculo.Enabled = disponible;
            sGps.Enabled = disponible;
            nGps.Enabled = disponible;
        }




        /// <summary>
        /// determina si fue seleccionado el check de posee o no un gps
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
        /// MODIFICA EL VEHICULO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMVehiculo_Click(object sender, System.EventArgs e)
        {
            String msj = "Esta seguro que quiere modificar este Vehiculo " + this.txtAMatricula.Text + " " + cmbMarca.Text;
            DialogResult dialogResult = MessageBox.Show(msj, "Confirmar", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
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
        }


        /// <summary>
        /// Elimina el vehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEVehiculo_Click(object sender, System.EventArgs e)
        {
            String msj = "Esta seguro que quiere Eliminar este Vehiculo " + this.txtAMatricula.Text + " " + cmbMarca.Text;
            DialogResult dialogResult = MessageBox.Show(msj, "Confirmar", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
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
        }
        /// <summary>
        /// carga tipos de vehiculo en el comboBox
        /// </summary>
        public void cargarTipo()
        {
            cmbTipo.DisplayMember = "Descripcion";
            cmbTipo.ValueMember = "ID";
            cmbTipo.DataSource = TrabajarTipoVehiculo.listarTipoVehDisponible();
        }
        /// <summary>
        /// carga clase de vehiculos en el comboBox
        /// </summary>
        public void cargarClase()
        {
            cmbClase.DisplayMember = "Descripcion";
            cmbClase.ValueMember = "ID";
            cmbClase.DataSource = TrabajarClaseVehiculo.listarClaseVehDisponible();
        }
        /// <summary>
        /// Validacion solo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtALinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);

        }
        /// <summary>
        /// validacion solo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }
        /// <summary>
        /// refresca el combobox tipo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTipo_DropDown(object sender, EventArgs e)
        {
            cargarTipo();
        }
        /// <summary>
        /// refresca el combobox clase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbClase_DropDown(object sender, EventArgs e)
        {
            cargarClase();
        }
    }
}
