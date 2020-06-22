using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMostrarUsuario : Form
    {
        public string rol;
        public FrmMostrarUsuario()
        {
            InitializeComponent();
            cargarRol();//Se llama al metodo cargar roles
        }
        /// <summary>
        /// Cambia de estado a disponible
        /// </summary>
        /// <param name="disponible"></param>
        public void disponibilidadDeUsuario(bool disponible)
        {
            txtNombreApellidoUsuario.Enabled = disponible;
            txtNombreUsuario.Enabled = disponible;
            txtPass.Enabled = disponible;
            cmbRoles.Enabled = disponible;
            btnEliminarUsuario.Enabled = disponible;
        }

        private void FrmMostrarUsuario_Load(object sender, EventArgs e)
        {
            Form frmUsuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmUsuario);
        }

        /// <summary>
        /// Devuelve una lista de los roles
        /// </summary>
        public void cargarRol()
        {
            cmbRoles.DisplayMember = "";
            cmbRoles.ValueMember = "rol_Descripcion";
            cmbRoles.DataSource = TrabajarUsuario.listaRoles();
        }
        /// <summary>
        /// Elimina un usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {

            String msj = "Esta seguro que quiere elimnar el Usuario " + this.txtNombreUsuario.Text + "?";
            int id = Convert.ToInt32(this.txtId.Text);
            DialogResult dialogResult = MessageBox.Show(msj, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                if (rol == "Administrador")
                {
                    eliminarAdministrador();
                }
                else
                {
                    try
                    {
                        TrabajarUsuario.bajaUsuarioFisica(id);

                    }
                    catch
                    {
                        TrabajarUsuario.bajaUsuario(id, false);
                    }
                    finally
                    {
                        Form frmUsuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmUsuario);
                        ((FrmUsuario)frmUsuario).listarUsuario();
                        ((FrmUsuario)frmUsuario).contar();
                        MessageBox.Show("Usuario Eliminado");
                    }
                }
            }
        }

        /// <summary>
        /// Elimina un administrador
        /// </summary>
        private void eliminarAdministrador()
        {


            int id = Convert.ToInt32(this.txtId.Text);
            DataTable dataTable = new DataTable();
            dataTable = TrabajarUsuario.buscarAdministradores();
            if (dataTable.Rows.Count != 1)
            {
                try
                {
                    TrabajarUsuario.bajaUsuarioFisica(id);

                }
                catch
                {
                    TrabajarUsuario.bajaUsuario(id, false);
                }
                finally
                {
                    Form frmUsuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmUsuario);
                    ((FrmUsuario)frmUsuario).listarUsuario();
                    ((FrmUsuario)frmUsuario).contar();
                    MessageBox.Show("Usuario Eliminado!");
                }
            }
            else
            {
                MessageBox.Show("Tiene que haber un minimo de un (1) Usuario tipo administrador","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
        /// <summary>
        /// Actualiza un usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            String msj = "Esta seguro que quiere modificar este Usuario " + this.txtNombreUsuario.Text + "?";
            DialogResult dialogResult = MessageBox.Show(msj, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Form frmUsuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmUsuario);
                Usuario usuario = new Usuario();
                usuario.Usu_ID = Convert.ToInt32(this.txtId.Text);
                usuario.Usu_NombreUsuario = txtNombreUsuario.Text;
                usuario.Usu_Contraseña = txtPass.Text;
                usuario.Usu_ApellidoNombre = txtNombreApellidoUsuario.Text;
                usuario.Rol_Codigo = cmbRoles.Text;
                TrabajarUsuario.modificarUsuario(usuario);
                ((FrmUsuario)frmUsuario).listarUsuario();
                ((FrmUsuario)frmUsuario).contar();
                MessageBox.Show("Usuario Modificado!");
            }
        }

        /// <summary>
        /// Validaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            btnActualizarUsuario.Enabled = true;
        }

        private void txtNombreApellidoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            btnActualizarUsuario.Enabled = true;
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rol != cmbRoles.Text)
            {
                btnActualizarUsuario.Enabled = true;
            }
        }

        private void txtNombreApellidoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }
    }
}
