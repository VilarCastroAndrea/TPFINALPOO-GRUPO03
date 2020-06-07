using ClasesBase;
using System;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmFormaPago : Form
    {
        public FrmFormaPago()
        {
            InitializeComponent();
        }

        private void FrmFormaPago_Load(object sender, EventArgs e)
        {
            cargarFormaPago();
        }

        private void btnMoficar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

        }

        private void cargarFormaPago()
        {
            dgwLista.DataSource = TrabajarFormaPago.listarFormaPago();
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
