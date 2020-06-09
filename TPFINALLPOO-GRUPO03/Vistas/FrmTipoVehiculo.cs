using ClasesBase;
using System;
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
            TipoVehiculo tv = new TipoVehiculo();
            tv.Tv_ID = Convert.ToInt32(dgwLista.CurrentRow.Cells["ID"].Value);
            tv.Tv_Descripcion = txtDetalle.Text;
            tv.Tv_Disponible = checkDisponible.Checked;
            TrabajarTipoVehiculo.modificacionTipo(tv);
            MessageBox.Show("Tipo de vehiculo Modificado");
            cargarTipo();
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            String msj = "Esta seguro que quiere elimnar " + this.txtDetalle.Text;
            int id = Convert.ToInt32(dgwLista.CurrentRow.Cells["ID"].Value);
            DialogResult dialogResult = MessageBox.Show(msj, "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TrabajarTipoVehiculo.bajaTipo(id, false);
                cargarTipo();
                MessageBox.Show("Eliminado");
            }
        }

        private void btnAlta_Click(object sender, System.EventArgs e)
        {
            if (txtNuevo.Text != " ")
            {
                TrabajarTipoVehiculo.altaTipo(txtNuevo.Text, true);
                txtNuevo.Text = "";
                dgwLista.DataSource = null;
                cargarTipo();
            }
            else
            {
                MessageBox.Show("complete todos los campos");
            }
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
                checkDisponible.Checked = Convert.ToBoolean(dgwLista.CurrentRow.Cells["Disponible"].Value);
            }
        }
    }
}
