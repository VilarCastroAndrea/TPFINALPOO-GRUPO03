using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmAltaCliente : Form
    {
        private Cliente cliente;
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Valida que todos los campos tengan contenido
        /// </summary>
        /// <returns></returns>
        private bool camposCargados()
        {
            if (txtApellido.Text != "" && txtDireccion.Text != "" && txtDni.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "")
                return true;

            return false;
        }

        /// <summary>
        /// Realiza el alta de cliente, limpia los campos y muestra un cartel con el resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnACliente_Click(object sender, EventArgs e)
        {
            if (camposCargados())
            {
                Form frmCliente = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmCliente);

                try
                {

                    if (cargarDatos())
                    {
                        if (mensaje(cliente) == DialogResult.OK)
                        {
                            TrabajarCliente.altaCliente(cliente);
                            ((FrmCliente)frmCliente).cargarCliente();
                            ((FrmCliente)frmCliente).contar();
                            limpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Se cancelo el alta de Cliente", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
                catch
                {
                    txtDni.Text = "";
                    txtDni.Focus();
                    MessageBox.Show("Ya existe un cliente con el dni ingresado","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// carga los datos de los campos y los guarda en una variable cliente
        /// </summary>
        /// <returns></returns>
        public bool cargarDatos()

        {
            cliente = new Cliente();
            if (txtDni.Text.Length == 8 || txtDni.Text.Length == 7)
            {

                if (validarCampos() != false)
                {
                    cliente.Cli_DNI = txtDni.Text;
                    cliente.Cli_Nombre = txtNombre.Text;
                    cliente.Cli_Apellido = txtApellido.Text;
                    cliente.Cli_Direccion = txtDireccion.Text;
                    cliente.Cli_Telefono = txtTelefono.Text;
                    cliente.Cli_Disponible = true;
                    return true;
                }
                else
                {
                    MessageBox.Show("Complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un DNI valido (7/8 digitos)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;

        }
        /// <summary>
        /// muestra el mensaje de confirmacion
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public DialogResult mensaje(Cliente cliente)
        {
            DialogResult result = MessageBox.Show("Los Datos ingresados son correctos? " + "\n" +
                                                              "DNI: " + txtDni.Text + "\n" +
                                                              "Nombre: " + txtNombre.Text + "\n" +
                                                              "Apellido: " + txtApellido.Text + "\n" +
                                                              "Direccion: " + txtDireccion.Text + "\n" +
                                                              "Telefono: " + txtTelefono.Text,
                                                              "Agregar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return result;
        }
        /// <summary>
        /// Valida que todos los campos esten completos
        /// </summary>
        /// <returns></returns>
        public bool validarCampos()
        {
            bool respuesta = false;
            if (txtDni.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "")
            {
                respuesta = true;
            }
            return respuesta;
        }

        /// <summary>
        /// limpia todos los campos
        /// </summary>
        public void limpiarCampos()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }


        /// <summary>
        /// validacion solo numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validar.soloNumeros(e);
            txtDni.MaxLength = 8;
        }
        /// <summary>
        /// validacion solo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }
        /// <summary>
        /// validacion sono letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApellido_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }
        /// <summary>
        /// validacion solo numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);

        }
    }
}
