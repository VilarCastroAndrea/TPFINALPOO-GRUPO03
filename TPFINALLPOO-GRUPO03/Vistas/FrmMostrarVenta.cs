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

        private void btnAnular_Click(object sender, EventArgs e)
        {
            String msj = "Esta seguro que quiere ANULAR la venta";
            DialogResult dialogResult = MessageBox.Show(msj, "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form frmVenta = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmVehiculo);
                TrabajarVenta.modificarVenta(Convert.ToInt32(id.Text), "ANULADA");
                //FrmVenta)frmVenta).cargarVentas();
                MessageBox.Show("Venta ANULADA");
                Form frmVehiculo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmVehiculo);
                TrabajarVehiculo.bajaVehiculo(matricula.Text, true);
                ((FrmVehiculo)frmVehiculo).dataVehiculo.DataSource = TrabajarVehiculo.listarVehiculo();
                ((FrmVenta)frmVenta).cargarVentas();
            }
        }
    }
}
