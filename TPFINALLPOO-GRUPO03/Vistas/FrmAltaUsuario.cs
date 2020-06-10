using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmAltaUsuario : Form
    {
        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        //Al cargar el formulario realiza la carga de roles disponibles
        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            cargarRol();
        }

        //Determina que el usuario alla llenado todos los campos y que no existan campos vacios
        private bool camposVacios()
        {
            if (txtNombreApellidoUsuario.Text != "" && txtNombreUsuario.Text != "" && txtPass.Text != "")
                return true;

            return false;
        }

        //agrega un usuario a la base de datos si cumple con las condiciones necesarias
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (camposVacios())
            {
                Form frmUsuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmUsuario);
                DataTable userX = new DataTable();
                userX = TrabajarUsuario.buscarUsuario(txtNombreUsuario.Text);
                if (userX.Rows.Count == 0)
                {
                    if (mensaje(cargarDatos()) == DialogResult.OK)
                    {
                        try
                        {
                            TrabajarUsuario.altaUsuario(cargarDatos());
                            ((FrmUsuario)frmUsuario).listarUsuario();
                            limpiarCampos();
                        }
                        catch
                        {
                            MessageBox.Show("Complete correctamente los datos");
                        }



                    }
                    else
                    {
                        MessageBox.Show("Se cancelo el alta del usuario", "Cancelado");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario ya existente, ingrese otro nombre de usuario");
                    txtNombreUsuario.Text = "";
                    txtNombreUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        //carga los datos de los campos a una variable del tipo usuario
        public Usuario cargarDatos()
        {
            Usuario nuevoUsu = new Usuario();
            if (validarCampos() != false)
            {
                nuevoUsu.Usu_NombreUsuario = txtNombreUsuario.Text;
                nuevoUsu.Usu_Contraseña = txtPass.Text;
                nuevoUsu.Usu_ApellidoNombre = txtNombreApellidoUsuario.Text;
                nuevoUsu.Rol_Codigo = cmbRoles.Text;
                nuevoUsu.Usu_Disponible = true;
            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            return nuevoUsu;
        }

        //mensaje de confirmacion para el alta de cliente
        public DialogResult mensaje(Usuario nuevoUsu)
        {
            DialogResult result = MessageBox.Show("Los Datos ingresados son correctos? " + "\n" +
                                                         "Nombre de Usuario: " + nuevoUsu.Usu_NombreUsuario + "\n" +
                                                         "Contraseña: " + nuevoUsu.Usu_Contraseña + "\n" +
                                                         "Nombre y Apellido: " + nuevoUsu.Usu_ApellidoNombre + "\n" +
                                                         "Rol: " + nuevoUsu.Rol_Codigo,
                                                         "Agregar usuario", MessageBoxButtons.OKCancel);
            return result;
        }

        //Carga la lista de roles
        public void cargarRol()
        {
            cmbRoles.DisplayMember = "";
            cmbRoles.ValueMember = "rol_Descripcion";
            cmbRoles.DataSource = TrabajarUsuario.listaRoles();
        }

        /// <summary>
        /// Valida los campos
        /// </summary>
        public bool validarCampos()
        {
            Boolean resultado = false;
            if (txtNombreUsuario.Text != "" && txtPass.Text != "" && txtNombreApellidoUsuario.Text != "" && cmbRoles.Text != "")
            {
                resultado = true;
            }
            return resultado;
        }

        /// <summary>
        /// Limpia los campos
        /// </summary>
        public void limpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtPass.Text = "";
            txtNombreApellidoUsuario.Text = "";
            cmbRoles.Text = "";
        }

        //validacion del campo apellido nombre usuario solo letras
        private void txtNombreApellidoUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.SetError(txtNombreApellidoUsuario, "ingrese solo letras");
        }
    }
}