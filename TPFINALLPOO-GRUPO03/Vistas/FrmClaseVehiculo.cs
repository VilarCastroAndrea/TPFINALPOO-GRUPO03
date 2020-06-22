using ClasesBase;
using System;
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
        /// <summary>
        /// carga las clases de vehiculos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmClaseVehiculo_Load(object sender, EventArgs e)
        {
            cargarClasesV();
        }
        /// <summary>
        /// modifica la clase seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoficar_Click(object sender, EventArgs e)
        {
            String msj = "Esta seguro que quiere modificar esta clase de vehiculo " + this.txtDetalle.Text;
            DialogResult dialogResult = MessageBox.Show(msj, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (txtDetalle.Text != "")
                {

                    ClaseVehiculo cv = new ClaseVehiculo();
                    cv.Cv_ID = Convert.ToInt32(dgwLista.CurrentRow.Cells["ID"].Value);
                    cv.Cv_Descripcion = txtDetalle.Text;
                    cv.Cv_Disponible = checkDisponible.Checked;
                    TrabajarClaseVehiculo.modificacionClase(cv);
                    MessageBox.Show("Clase de vehiculo Modificado");
                    cargarClasesV();

                }
                else
                {
                    MessageBox.Show("Complete todos los campos");
                }
            }
            actualizarComboClase();
        }
        /// <summary>
        /// Elimina fisicamente la clase si no esta relacionada caso contrario realiza eliminacion logica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            String msj = "Esta seguro que quiere elimnar esta clase de vehiculo? " + this.txtDetalle.Text;
            int id = Convert.ToInt32(dgwLista.CurrentRow.Cells["ID"].Value);
            DialogResult dialogResult = MessageBox.Show(msj, "Confirmar", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    TrabajarClaseVehiculo.bajaClaseFisica(id);
                }
                catch
                {
                    TrabajarClaseVehiculo.bajaClase(id, false);
                }
                cargarClasesV();
                MessageBox.Show("Eliminado");
            }
            actualizarComboClase();
        }
        /// <summary>
        /// realiza la alta de una nueva clase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlta_Click(object sender, EventArgs e)
        {
            String msj = "Esta seguro que quiere agregar esta clase de vehiculo? " + this.txtNuevo.Text;
            DialogResult dialogResult = MessageBox.Show(msj, "Confirmar", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (txtNuevo.Text != "")
                {
                    if (validarClaseVehiculo(txtNuevo.Text))
                    {
                        TrabajarClaseVehiculo.altaClase(txtNuevo.Text, true);
                        txtNuevo.Text = "";
                        dgwLista.DataSource = null;
                        cargarClasesV();
                    }
                    else
                    {
                        MessageBox.Show("Clase vehiculo ya exsite", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            actualizarComboClase();
        }

        /// <summary>
        /// actualiza el combo clase del formulario mostrar vehiculo
        /// </summary>
        private void actualizarComboClase()
        {
            FrmMostrarVehiculo frmMosVehiculo = new FrmMostrarVehiculo();
            Form frmMostrarVehiculo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmMostrarVehiculo);
            if (frmMostrarVehiculo != null)
            {
                ((FrmMostrarVehiculo)frmMostrarVehiculo).cargarClase();
            }
        }
        /// <summary>
        /// carga las clases de vehiculo
        /// </summary>
        public void cargarClasesV()
        {
            dgwLista.DataSource = TrabajarClaseVehiculo.listarClaseVehiculo();
        }

        /// <summary>
        /// al seleccionar elementos del datagrid este se pasa a los campos a la derecha
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
        private bool validarClaseVehiculo(string descripcion)
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
        /// validacion solo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
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
        /// habilita el boton modificar al escribir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkDisponible_CheckedChanged(object sender, EventArgs e)
        {
            btnMoficar.Enabled = true;
        }
        /// <summary>
        /// habilita el boton modificar al cambiar el estado del check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            btnMoficar.Enabled = true;
        }


        /// <summary>
        /// cierra este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
