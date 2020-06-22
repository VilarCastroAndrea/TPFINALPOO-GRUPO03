using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMostrarVehiculo : Form
    {
        public string marca;
        public string modelo;
        public string color;
        public string cantPuertas;
        public string tipoVehiculo;
        public string claseVehiculo;
        public bool gps;

        public Vehiculo vehiculoModificado;
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
            if (cmbModelo.Text != "" && cmbCantPuert.Text != "" && cmbColor.Text != "" && txtALinea.Text != "" && cmbMarca.Text != "" && txtAMatricula.Text != "" && cmbTipo.Text != "" && txtAPrecio.Text != "" && cmbClase.Text != "")
            {

                String msj = "Esta seguro que quiere modificar este Vehiculo " + this.txtAMatricula.Text + " " + cmbMarca.Text;
                DialogResult dialogResult = MessageBox.Show(msj, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            else
            {
                MessageBox.Show("Complete todos los campos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            DialogResult dialogResult = MessageBox.Show(msj, "Confirmar", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

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
                        ((FrmVehiculo)frmVehiculo).contar();
                    }
                    catch
                    {
                        MessageBox.Show("Vehiculo Eliminado");
                        TrabajarVehiculo.eliminarVehiculo(txtAMatricula.Text);
                        ((FrmVehiculo)frmVehiculo).dataVehiculo.DataSource = TrabajarVehiculo.listarVehiculo();
                        ((FrmVehiculo)frmVehiculo).contar();
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
        /// validacion sobre marca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (marca != cmbMarca.Text)
            {
                btnMVehiculo.Enabled = true;
            }
        }
        /// <summary>
        /// habilitacion de boton en caso de modificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtALinea_KeyDown(object sender, KeyEventArgs e)
        {
            btnMVehiculo.Enabled = true;
        }
        /// <summary>
        /// habilitacion de boton en caso de modificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelo != cmbModelo.Text)
            {
                btnMVehiculo.Enabled = true;
            }
        }
        /// <summary>
        /// habilitacion de boton en caso de modificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (color != cmbColor.Text)
            {
                btnMVehiculo.Enabled = true;
            }
        }
        /// <summary>
        /// habilitacion de boton en caso de modificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCantPuert_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cantPuertas != cmbCantPuert.Text)
            {
                btnMVehiculo.Enabled = true;
            }
        }
        /// <summary>
        /// habilitacion de boton en caso de modificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoVehiculo != cmbTipo.Text)
            {
                btnMVehiculo.Enabled = true;
            }
        }
        /// <summary>
        /// habilitacion de boton en caso de modificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (claseVehiculo != cmbClase.Text)
            {
                btnMVehiculo.Enabled = true;
            }
        }


        /// <summary>
        /// habilitacion de boton en caso de modificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sGps_CheckedChanged(object sender, EventArgs e)
        {
            if (gps != sGps.Checked)
            {
                btnMVehiculo.Enabled = true;
            }
        }

        /// <summary>
        /// habilitacion de boton en caso de modificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            btnMVehiculo.Enabled = true;
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
        /// valida solo numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCantPuert_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }
    }
}
