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
        //carga las clases de vehiculos
        private void FrmClaseVehiculo_Load(object sender, EventArgs e)
        {
            cargarClasesV();
        }
        //modifica la clase seleccionada
        private void btnMoficar_Click(object sender, EventArgs e)
        {
            if (txtDetalle.Text != "")
            {
                if (this.validarClaseVehiculo(txtDetalle.Text))
                {
                    ClaseVehiculo cv = new ClaseVehiculo();
                    cv.Cv_ID = Convert.ToInt32(dgwLista.CurrentRow.Cells["ID"].Value);
                    cv.Cv_Descripcion = txtDetalle.Text;
                    cv.Cv_Disponible = checkDisponible.Checked;
                    TrabajarClaseVehiculo.modificacionClase(cv);
                    MessageBox.Show("Clase vehiculo Modificado");
                    cargarClasesV();
                }
                else
                {
                    MessageBox.Show("Clase vehiculo ya exsite");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
        }
        //Elimina fisicamente la clase si no esta relacionada caso contrario realiza eliminacion logica
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String msj = "Esta seguro que quiere elimnar " + this.txtDetalle.Text;
            int id = Convert.ToInt32(dgwLista.CurrentRow.Cells["ID"].Value);
            DialogResult dialogResult = MessageBox.Show(msj, "Some Title", MessageBoxButtons.YesNo);
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
        }
        //realiza la alta de una nueva clase
        private void btnAlta_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Clase vehiculo ya exsite");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
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

        private void txtDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.SetError(txtDetalle, "ingrese solo letras");
        }

        private void txtNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.SetError(txtNuevo, "ingrese solo letras");
        }
    }
}