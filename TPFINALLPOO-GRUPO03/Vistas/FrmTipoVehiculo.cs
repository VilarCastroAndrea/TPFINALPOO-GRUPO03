using ClasesBase;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmTipoVehiculo : Form
    {
        public FrmTipoVehiculo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// evento al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTipoVehiculo_Load(object sender, System.EventArgs e)
        {
            cargarTipo();
        }
        /// <summary>
        /// Modifica tipo de vechiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoficar_Click(object sender, System.EventArgs e)
        {
            String msj = "Esta seguro que quiere modificar este tipo de vehiculo " + txtDetalle.Text;
            DialogResult dialogResult = MessageBox.Show(msj, "Anular tipo de venta?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtDetalle.Text != "")
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
                    MessageBox.Show("Debe completar todos los campos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            actualizarComboTipo();
        }
        /// <summary>
        /// elimina un tipo de vehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            String msj = "Esta seguro que quiere elimnar " + this.txtDetalle.Text;
            int id = Convert.ToInt32(dgwLista.CurrentRow.Cells["ID"].Value);
            DialogResult dialogResult = MessageBox.Show(msj, "Confirmar", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
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
            actualizarComboTipo();
        }
        /// <summary>
        /// Agrega un tipo de vehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlta_Click(object sender, System.EventArgs e)
        {
            String msj = "Esta seguro que quiere Agregar este tipo de vehiculo " + txtNuevo.Text;
            DialogResult dialogResult = MessageBox.Show(msj, "Confirmar", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
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
                        MessageBox.Show("El Tipo de vehiculo ya existe","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            actualizarComboTipo();
        }

        /// <summary>
        /// actualiza el combobox del formulario mostrar vehiculo
        /// </summary>
        private void actualizarComboTipo()
        {
            FrmMostrarVehiculo frmMosVehiculo = new FrmMostrarVehiculo();
            Form frmMostrarVehiculo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmMostrarVehiculo);
            if (frmMostrarVehiculo != null)
            {
                ((FrmMostrarVehiculo)frmMostrarVehiculo).cargarTipo();
            }
        }
        /// <summary>
        /// carga a la tabla la lista de tipos de vehiculos
        /// </summary>
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
                btnMoficar.Enabled = false;
            }
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



        /// <summary>
        /// Valida solo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        /// <summary>
        /// valida solo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNuevo_KeyPress(object sender, KeyPressEventArgs e)
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
        /// cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
