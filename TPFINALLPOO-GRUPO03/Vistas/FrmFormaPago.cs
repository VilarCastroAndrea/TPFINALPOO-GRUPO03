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
            FormaPago fp = new FormaPago();
            fp.Fp_ID = Convert.ToInt32(dgwLista.CurrentRow.Cells["ID"].Value);
            fp.Fp_Descripcion = txtDetalle.Text;
            fp.Fp_Disponible = checkDisponible.Checked;
            TrabajarFormaPago.modificacionFormaPago(fp);
            MessageBox.Show("Tipo de vehiculo Modificado");
            cargarFormaPago();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String msj = "Esta seguro que quiere elimnar " + this.txtDetalle.Text;
            int id = Convert.ToInt32(dgwLista.CurrentRow.Cells["ID"].Value);
            DialogResult dialogResult = MessageBox.Show(msj, "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    TrabajarFormaPago.bajaFormaPagoFisica(id);
                }
                catch
                {
                    TrabajarFormaPago.bajaFormaPago(id, false);
                }
                cargarFormaPago();
                MessageBox.Show("Eliminado");
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (txtNuevo.Text != " ")
            {
                TrabajarFormaPago.altaFormaPago(txtNuevo.Text, true);
                txtNuevo.Text = "";
                dgwLista.DataSource = null;
                cargarFormaPago();
            }
            else
            {
                MessageBox.Show("complete todos los campos");
            }
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
                checkDisponible.Checked = Convert.ToBoolean(dgwLista.CurrentRow.Cells["Disponible"].Value);
            }
        }
    }
}
