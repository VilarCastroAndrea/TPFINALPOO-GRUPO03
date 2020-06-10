using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMostrarVenta : Form
    {
        public FrmMostrarVenta()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnular_Click(object sender, EventArgs e)
        {
            String msj = "Esta seguro que quiere ANULAR la venta";
            DialogResult dialogResult = MessageBox.Show(msj, "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form frmVenta = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmVenta);
                TrabajarVenta.modificarVenta(Convert.ToInt32(id.Text), "ANULADA");
                MessageBox.Show("Venta ANULADA");
                TrabajarVehiculo.bajaVehiculo(matricula.Text, true);
                refrescarVistaVehiculo();
                ((FrmVenta)frmVenta).cargarVentas();
            }
        }
        /// <summary>
        /// restringe el acceso segun el usuario
        /// </summary>
        public void restringirAcceso()
        {
            Form frmLogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmLogin);
            if (frmLogin != null)
            {
                if (((FrmLogin)frmLogin).user.Rol_Codigo == "Vendedor")
                {
                    btnAnular.Visible = false;
                }
                else
                {
                    btnAnular.Visible = true;
                }
            }
            }
        //Refrescar la Vista de vehiculos
        private void refrescarVistaVehiculo()
        {
            Form frmVehiculo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmVehiculo);
            if (frmVehiculo != null)
            {
                ((FrmVehiculo)frmVehiculo).cargarVehiculos();
            }
        }
        
        //Actualiza el boton Anular
        public void actualizarBotonAnular()
        {
            if (estado.Text == "ANULADA")
            {
                btnAnular.Enabled = false;
            }
            else
            {
                btnAnular.Enabled = true;
            }
        }
    }
}
