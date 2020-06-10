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
        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            cargarRol();
        }
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
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

        private void txtNombreApellidoUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }
    }
}
