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
            if (txtDetalle.Text != "")
            {
                if (this.validarTipoVehiculo(txtDetalle.Text))
                {
                    TipoVehiculo tv = new TipoVehiculo();
                    tv.Tv_ID = Convert.ToInt32(dgwLista.CurrentRow.Cells["ID"].Value);
                    tv.Tv_Descripcion = txtDetalle.Text;
                    tv.Tv_Disponible = checkDisponible.Checked;
                    TrabajarTipoVehiculo.modificacionTipo(tv);
                    MessageBox.Show("Tipo de vehiculo Modificado");
                    cargarTipo();
                }
                else
                {
                    MessageBox.Show("Tipo de vehiculo ya existe");
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            String msj = "Esta seguro que quiere elimnar " + this.txtDetalle.Text;
            int id = Convert.ToInt32(dgwLista.CurrentRow.Cells["ID"].Value);
            DialogResult dialogResult = MessageBox.Show(msj, "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    TrabajarTipoVehiculo.bajaTipoFisica(id);
                }
                catch
                {
                    TrabajarTipoVehiculo.bajaTipo(id, false);
                }
                cargarTipo();
                MessageBox.Show("Eliminado");
            }
        }

        private void btnAlta_Click(object sender, System.EventArgs e)
        {
            if (txtNuevo.Text != "")
            {
                if (this.validarTipoVehiculo(txtNuevo.Text))
                {
                    TrabajarTipoVehiculo.altaTipo(txtNuevo.Text, true);
                    txtNuevo.Text = "";
                    dgwLista.DataSource = null;
                    cargarTipo();
                }
                else
                {
                    MessageBox.Show("El Tipo ya existe");
                }
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

        private void txtDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        private void txtNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }


        /// <summary>
        /// valida para agregar un nuevo tipo de vehiculo
        /// </summary>
        /// <param name="tipo"></param>
        private bool validarTipoVehiculo(string tipo)
        {
            string detalle;
            foreach (DataGridViewRow fila in dgwLista.Rows)
            {
                detalle = Convert.ToString(fila.Cells["Descripcion"].Value);
                if (detalle.Equals(tipo))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
