using ClasesBase;
using System;
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
            ClaseVehiculo cv = new ClaseVehiculo();
            cv.Cv_ID = Convert.ToInt32(dgwLista.CurrentRow.Cells["ID"].Value);
            cv.Cv_Descripcion = txtDetalle.Text;
            cv.Cv_Disponible = checkDisponible.Checked;
            TrabajarClaseVehiculo.modificacionClase(cv);
            MessageBox.Show("Tipo de vehiculo Modificado");
            cargarClasesV();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String msj = "Esta seguro que quiere elimnar " + this.txtDetalle.Text;
            int id = Convert.ToInt32(dgwLista.CurrentRow.Cells["ID"].Value);
            DialogResult dialogResult = MessageBox.Show(msj, "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TrabajarClaseVehiculo.bajaClase(id, false);
                cargarClasesV();
                MessageBox.Show("Eliminado");
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (txtNuevo.Text != " ")
            {
                TrabajarClaseVehiculo.altaClase(txtNuevo.Text, true);
                txtNuevo.Text = "";
                dgwLista.DataSource = null;
                cargarClasesV();
            }
            else
            {
                MessageBox.Show("complete todos los campos");
            }
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
                checkDisponible.Checked = Convert.ToBoolean(dgwLista.CurrentRow.Cells["Disponible"].Value);
            }
        }
    }
}
