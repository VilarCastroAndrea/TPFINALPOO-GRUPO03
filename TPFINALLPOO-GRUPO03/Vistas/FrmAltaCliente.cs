using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmAltaCliente : Form
    {
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        //Valida que todos los campos tengan contenido
        private bool camposCargados()
        {
            if(txtApellido.Text!=""&&txtDireccion.Text!=""&&txtDni.Text!=""&&txtNombre.Text!=""&&txtTelefono.Text!="")
            return true;

            return false;
        }

        //Realiza el alta de cliente, limpia los campos y muestra un cartel con el resultado
        private void btnACliente_Click(object sender, EventArgs e)
        {
            if (camposCargados())
            {
                Form frmCliente = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmCliente);

                try
                {
                    if (mensaje(cargarDatos()) == DialogResult.OK)
                    {
                        TrabajarCliente.altaCliente(cargarDatos());
                        ((FrmCliente)frmCliente).cargarCliente();
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Se cancelo el alta de Cliente", "Cancelado");
                    }
                }
                catch
                {
                    txtDni.Text = "";
                    txtDni.Focus();
                    MessageBox.Show("Cliente ya existente, ingrese otro nombre de usuario");
                }
            }
            else
            {
                MessageBox.Show("Campos incompletos");
            }
        }
        //carga los datos de los campos y los guarda en una variable cliente
        public Cliente cargarDatos()

        {
            Cliente aCliente = new Cliente();
            if (txtDni.Text.Length == 8) {

                if (validarCampos() != false)
                {
                    aCliente.Cli_DNI = txtDni.Text;
                    aCliente.Cli_Nombre = txtNombre.Text;
                    aCliente.Cli_Apellido = txtApellido.Text;
                    aCliente.Cli_Direccion = txtDireccion.Text;
                    aCliente.Cli_Telefono = txtTelefono.Text;
                    aCliente.Cli_Disponible = true;
                }
                else
                {
                    MessageBox.Show("Complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un DNI valido (8 digitos)");
            }


            return aCliente;
        }
        //muestra el mensaje de confirmacion
        public DialogResult mensaje(Cliente cliente)
        {
            DialogResult result = MessageBox.Show("Los Datos ingresados son correctos? " + "\n" +
                                                              "DNI: " + txtDni.Text + "\n" +
                                                              "Nombre: " + txtNombre.Text + "\n" +
                                                              "Apellido: " + txtApellido.Text + "\n" +
                                                              "Direccion: " + txtDireccion.Text + "\n" +
                                                              "Telefono: " + txtTelefono.Text,
                                                              "Agregar Cliente", MessageBoxButtons.OKCancel);
            return result;
        }
        //Valida que todos los campos esten completos
        public bool validarCampos()
        {
            bool respuesta = false;
            if (txtDni.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "")
            {
                respuesta = true;
            }
            return respuesta;
        }

        //limpia todos los campos
        public void limpiarCampos()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }


        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            Validar.soloNumeros(e);
            txtDni.MaxLength = 9 ;
        }

        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            Validar.soloLetra(e);
            errorProvider.SetError(txtNombre, "ingrese datos validos");
        }

        private void txtApellido_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            Validar.soloLetra(e);
            errorProvider.SetError(txtApellido, "ingrese datos validos");
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.SetError(txtTelefono, "ingrese solo numeros");
        }
    }
}
