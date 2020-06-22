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

        /// <summary>
        /// Al cargar el formulario realiza la carga de roles disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            cargarRol();
        }

        /// <summary>
        /// Determina que el usuario alla llenado todos los campos y que no existan campos vacios
        /// </summary>
        /// <returns></returns>
        private bool camposVacios()
        {
            if (txtNombreApellidoUsuario.Text != "" && txtNombreUsuario.Text != "" && txtPass.Text != "")
                return true;

            return false;
        }

        /// <summary>
        /// agrega un usuario a la base de datos si cumple con las condiciones necesarias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (camposVacios())
            {
                Form frmUsuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmUsuario);
                DataTable userX = new DataTable();
                userX = TrabajarUsuario.buscarUsuarioPreciso(txtNombreUsuario.Text);
                if (userX.Rows.Count == 0)
                {
                    if (mensaje(cargarDatos()) == DialogResult.OK)
                    {
                        try
                        {
                            TrabajarUsuario.altaUsuario(cargarDatos());
                            ((FrmUsuario)frmUsuario).listarUsuario();
                            ((FrmUsuario)frmUsuario).contar();
                            limpiarCampos();
                        }
                        catch
                        {
                            MessageBox.Show("Complete correctamente los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }
                    else
                    {
                        MessageBox.Show("Se cancelo el alta del usuario", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario ya existente, ingrese otro nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombreUsuario.Text = "";
                    txtNombreUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga los datos de los campos a una variable del tipo usuario
        /// </summary>
        /// <returns></returns>
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
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nuevoUsu;
        }

        /// <summary>
        /// mensaje de confirmacion para el alta de cliente
        /// </summary>
        /// <param name="nuevoUsu"></param>
        /// <returns></returns>
        public DialogResult mensaje(Usuario nuevoUsu)
        {
            DialogResult result = MessageBox.Show("Los Datos ingresados son correctos? " + "\n" +
                                                         "Nombre de Usuario: " + nuevoUsu.Usu_NombreUsuario + "\n" +
                                                         "Contraseña: " + nuevoUsu.Usu_Contraseña + "\n" +
                                                         "Apellido y Nombre: " + nuevoUsu.Usu_ApellidoNombre + "\n" +
                                                         "Rol: " + nuevoUsu.Rol_Codigo,
                                                         "Agregar usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return result;
        }

        /// <summary>
        /// Carga la lista de roles
        /// </summary>
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

        /// <summary>
        /// validacion del campo apellido nombre usuario solo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombreApellidoUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }
    }
}