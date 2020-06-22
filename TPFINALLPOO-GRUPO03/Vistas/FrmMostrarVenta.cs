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
        /// anula la venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnular_Click(object sender, EventArgs e)
        {
            String msj = "Esta seguro que quiere ANULAR la venta";
            DialogResult dialogResult = MessageBox.Show(msj, "Anular venta?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
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
        /// <summary>
        /// Refrescar la Vista de vehiculos
        /// </summary>
        private void refrescarVistaVehiculo()
        {
            Form frmVehiculo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmVehiculo);
            if (frmVehiculo != null)
            {
                ((FrmVehiculo)frmVehiculo).cargarVehiculos();
            }
        }

        /// <summary>
        /// Actualiza el boton Anular
        /// </summary>
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

        public void anularBtn()
        {
            Form frmVenta = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmVenta);
            int total = ((FrmVenta)frmVenta).dataVenta.Rows.Count;
            Console.Write(total);
            if (total < 1)
            {
                btnAnular.Enabled = false;
            }
        }

        private void FrmMostrarVenta_Load(object sender, EventArgs e)
        {
            anularBtn();
        }
    }
}
