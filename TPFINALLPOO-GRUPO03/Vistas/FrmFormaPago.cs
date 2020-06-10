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
        //al cargar el formulario carga todas las formas de pago
        private void FrmFormaPago_Load(object sender, EventArgs e)
        {
            cargarFormaPago();
        }

        //elimina una forma de pago, si esta no esta siendo utilizada realiza una baja fisica caso contrario una baja lgica
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

        //Realiza el alta de Forma de pago con sus respectivas verificaciones
        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (txtNuevo.Text != "")
            {
                if (this.validarFormaPago(txtNuevo.Text))
                {
                    TrabajarFormaPago.altaFormaPago(txtNuevo.Text, true);
                    txtNuevo.Text = "";
                    dgwLista.DataSource = null;
                    cargarFormaPago();
                }
                else
                {
                    MessageBox.Show("La Forma de pago ya existe");
                }
            }
            else
            {
                MessageBox.Show("complete todos los campos");
            }
        }
        //carga las formas de pago
        private void cargarFormaPago()
        {
            dgwLista.DataSource = TrabajarFormaPago.listarFormaPago();
        }


        //cuando se selecciona un elemento de la tabla esta se ve reflejada en los campos del lado derecho para su posible modificacion
        private void dgwLista_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwLista.CurrentRow != null)
            {
                txtDetalle.Text = dgwLista.CurrentRow.Cells["Descripcion"].Value.ToString();
                checkDisponible.Checked = Convert.ToBoolean(dgwLista.CurrentRow.Cells["Disponible"].Value);
            }
        }




        /// <summary>
        /// valida para agregar un nuevo tipo de vehiculo
        /// </summary>
        /// <param name="tipo"></param>
        private bool validarFormaPago(string descripcion)
        {
            string detalle;
            foreach (DataGridViewRow fila in dgwLista.Rows)
            {
                detalle = Convert.ToString(fila.Cells["Descripcion"].Value);
                if (detalle.Equals(descripcion))
                {
                    return false;
                }
            }
            return true;
        }
        //modifica una forma de pago
        private void btnMoficar_Click_1(object sender, EventArgs e)
        {
            if (txtDetalle.Text != "")
            {
                if (this.validarFormaPago(txtDetalle.Text))
                {
                    FormaPago fp = new FormaPago();
                    fp.Fp_ID = Convert.ToInt32(dgwLista.CurrentRow.Cells["ID"].Value);
                    fp.Fp_Descripcion = txtDetalle.Text;
                    fp.Fp_Disponible = checkDisponible.Checked;
                    TrabajarFormaPago.modificacionFormaPago(fp);
                    MessageBox.Show("Forma de Pago Modificado");
                    cargarFormaPago();
                }
                else
                {
                    MessageBox.Show("Forma de pago ya existe");
                }
            }
            else
            {
                MessageBox.Show("El campo debe ser distinto de vacio");
            }
        }

        //validaciones
        private void txtNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.SetError(txtNuevo, "ingrese solo letras");
        }

        private void txtDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.SetError(txtDetalle, "ingrese solo letras");
        }
    }
}
