using ClasesBase;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmTipoVehiculo : Form
    {
        public FrmTipoVehiculo()
        {
            InitializeComponent();
        }

        private void FrmTipoVehiculo_Load(object sender, System.EventArgs e)
        {
            cargarTipo();
        }

        private void btnMoficar_Click(object sender, System.EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, System.EventArgs e)
        {

        }

        private void cargarTipo()
        {
            dgwLista.DataSource = TrabajarTipoVehiculo.listarTipoVehiculo();
        }

        private void dgwLista_CurrentCellChanged(object sender, System.EventArgs e)
        {
            if (dgwLista.CurrentRow != null)
            {
                txtDetalle.Text = dgwLista.CurrentRow.Cells["Descripcion"].Value.ToString();
                checkDisponible.Checked = dgwLista.CurrentRow.Cells["Disponible"].Selected;
            }
        }
    }
}
