using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmClaseVehiculo : Form
    {
        public FrmClaseVehiculo()
        {
            InitializeComponent();
        }

        private void FrmClaseVehiculo_Load(object sender, EventArgs e)
        {
            cargarClasesV();
        }

        private void btnMoficar_Click(object sender, EventArgs e)
        {
            TipoVehiculo tv = new TipoVehiculo();
            Form frmCliente = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmCliente);
            if (frmCliente != null)
            {
                // tv.Tv_ID = dgwLista.CurrentRow.Cells["ID"].Value.ToString();
                tv.Tv_Descripcion = txtDetalle.Text;
                tv.Tv_Disponible = checkDisponible.Checked;
                TrabajarClaseVehiculo.modificacionClase(tv);
                MessageBox.Show("Tipo de vehiculo Modificado");
                cargarClasesV();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

        }

        public void cargarClasesV()
        {
            dgwLista.DataSource = TrabajarClaseVehiculo.listarClaseVehiculo();
        }

        private void dgwLista_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwLista.CurrentRow != null)
            {
                txtDetalle.Text = dgwLista.CurrentRow.Cells["Descripcion"].Value.ToString();
                checkDisponible.Checked = dgwLista.CurrentRow.Cells["Disponible"].Selected;
            }
        }
    }
}
