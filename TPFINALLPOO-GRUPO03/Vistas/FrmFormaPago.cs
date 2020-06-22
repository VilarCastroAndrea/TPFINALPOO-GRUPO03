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
        /// <summary>
        /// al cargar el formulario carga todas las formas de pago
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFormaPago_Load(object sender, EventArgs e)
        {
            cargarFormaPago();
        }

        /// <summary>
        /// elimina una forma de pago, si esta no esta siendo utilizada realiza una baja fisica caso contrario una baja logica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Realiza el alta de Forma de pago con sus respectivas verificaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    MessageBox.Show("La Forma de pago ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// carga las formas de pago
        /// </summary>
        private void cargarFormaPago()
        {
            dgwLista.DataSource = TrabajarFormaPago.listarFormaPago();
        }


        /// <summary>
        /// cuando se selecciona un elemento de la tabla esta se ve reflejada en los campos del lado derecho para su posible modificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwLista_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwLista.CurrentRow != null)
            {
                txtDetalle.Text = dgwLista.CurrentRow.Cells["Descripcion"].Value.ToString();
                checkDisponible.Checked = Convert.ToBoolean(dgwLista.CurrentRow.Cells["Disponible"].Value);
                btnMoficar.Enabled = false;
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
        /// <summary>
        /// modifica una forma de pago
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoficar_Click_1(object sender, EventArgs e)
        {
            String msj = "Esta seguro que quiere modificar esta forma de pago " + this.txtDetalle.Text;
            DialogResult dialogResult = MessageBox.Show(msj, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (txtDetalle.Text != "")
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
                    MessageBox.Show("El campo no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        /// <summary>
        /// validacion solo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }
        /// <summary>
        /// validacion solo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        /// <summary>
        /// habilita el boton modificar al escribir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            btnMoficar.Enabled = true;
        }
        /// <summary>
        /// habilita el boton modificar al cambiar el estado del check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkDisponible_CheckedChanged(object sender, EventArgs e)
        {
            btnMoficar.Enabled = true;
        }


        /// <summary>
        /// sale del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
