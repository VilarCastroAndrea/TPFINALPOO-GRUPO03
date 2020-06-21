using ClasesBase;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }
        /// <summary>
        /// restringe acceso segun el usuario
        /// </summary>
        public void restringirAcceso()
        {
            Form frmLogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmLogin);
            if (frmLogin != null)
            {
                if (((FrmLogin)frmLogin).user.Rol_Codigo == "Auditor")
                {
                    btnAgregar.Visible = false;
                    panelUsuario.Enabled = false;
                }
                else
                {
                    btnMostrarUsuario.Visible = true;
                    btnAgregar.Visible = true;
                    panelUsuario.Visible = true;
                    panelUsuario.Enabled = true;
                }
            }
        }
        /// <summary>
        /// eventos al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarUsuario>().FirstOrDefault();
            FrmMostrarUsuario frmMostrarUsuario = form ?? new FrmMostrarUsuario();
            AddFormInPanel(frmMostrarUsuario);
            listarUsuario();

        }

        /// <summary>
        /// Llama a sub formulario
        /// </summary>
        /// <param name="fh"></param>
        private void AddFormInPanel(Form fh)
        {
            if (this.panelUsuario.Controls.Count > 0)
                this.panelUsuario.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelUsuario.Controls.Add(fh);
            this.panelUsuario.Tag = fh;
            fh.Show();
        }

        /// <summary>
        /// Lista los usuario
        /// </summary>
        public void listarUsuario()
        {
            dgvListaUsuarios.DataSource = TrabajarUsuario.listarUsuario();
            dgvListaUsuarios.Refresh();
            contar();
        }

        /// <summary>
        /// toma los datos de la tabla y los carga para ser modificados mas adelante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListaUsuarios_CurrentCellChanged_1(object sender, EventArgs e)
        {
            if (dgvListaUsuarios.CurrentRow != null)
            {
                FrmMostrarUsuario mu = new FrmMostrarUsuario();
                Form frmMostrarUsuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmMostrarUsuario);
                if (frmMostrarUsuario != null)
                {
                    ((FrmMostrarUsuario)frmMostrarUsuario).txtId.Text = dgvListaUsuarios.CurrentRow.Cells["ID"].Value.ToString();
                    ((FrmMostrarUsuario)frmMostrarUsuario).txtNombreUsuario.Text = dgvListaUsuarios.CurrentRow.Cells["Nombre de Usuario"].Value.ToString();
                    ((FrmMostrarUsuario)frmMostrarUsuario).txtPass.Text = dgvListaUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                    ((FrmMostrarUsuario)frmMostrarUsuario).txtNombreApellidoUsuario.Text = dgvListaUsuarios.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();
                    ((FrmMostrarUsuario)frmMostrarUsuario).cmbRoles.Text = dgvListaUsuarios.CurrentRow.Cells["Rol"].Value.ToString();
                    ((FrmMostrarUsuario)frmMostrarUsuario).disponibilidadDeUsuario(Convert.ToBoolean(dgvListaUsuarios.CurrentRow.Cells["Disponible"].Value));
                    ((FrmMostrarUsuario)frmMostrarUsuario).rol = dgvListaUsuarios.CurrentRow.Cells["Rol"].Value.ToString();
                    ((FrmMostrarUsuario)frmMostrarUsuario).btnActualizarUsuario.Enabled = false;
                }
            }
        }


        /// <summary>
        /// carga en el panel el formulario frmMostrarUsuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarUsuario_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarUsuario>().FirstOrDefault();
            FrmMostrarUsuario frmMostrarUsuario = form ?? new FrmMostrarUsuario();
            AddFormInPanel(frmMostrarUsuario);
        }



        /// <summary>
        /// Formatea la contraseña
        /// </summary>
        /// <param name="contraseña"></param>
        /// <returns></returns>
        private string reemplazoContraseña(string contraseña)
        {
            string devolucion = "";
            foreach (char a in contraseña)
            {
                devolucion = devolucion + "*";
            }
            return devolucion;
        }

        /// <summary>
        /// Busca a un usuario por nombre de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarUsuario.Text != "")
            {
                dgvListaUsuarios.DataSource = TrabajarUsuario.buscarUsuario(txtBuscarUsuario.Text);
            }
            else
            {
                listarUsuario();
            }
        }

        /// <summary>
        /// carga en el panel el formulario frmAltaUsuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmAltaUsuario>().FirstOrDefault();
            FrmAltaUsuario frmAltaUsuario = form ?? new FrmAltaUsuario();
            AddFormInPanel(frmAltaUsuario);
        }

        /// <summary>
        /// realiza la busqueda de usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (txtBuscarUsuario.Text != "Buscar Usuario")
            {
                dgvListaUsuarios.DataSource = TrabajarUsuario.buscarUsuario(txtBuscarUsuario.Text);
            }
            else
            {
                listarUsuario();
            }
        }
        /// <summary>
        /// esconde la contraseña de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListaUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvListaUsuarios.Columns[e.ColumnIndex].Name == "Contraseña")
            {
                e.Value = "********";
            }
        }


        /// <summary>
        /// cuenta la cantidad de usuarios para mostrar en informacion
        /// </summary>

        public void contar()
        {
            int t = dgvListaUsuarios.Rows.Count;
            lblUsuarios.Text = Convert.ToString(t);

            int admin = 0;
            int vendedor = 0;
            int auditor = 0;

            foreach (DataGridViewRow fila in dgvListaUsuarios.Rows)
            {
                if (fila.Cells[5].Value.Equals("Administrador"))
                {
                    admin = admin + 1;
                }
                else
                {
                    if (fila.Cells[5].Value.Equals("Vendedor"))
                    {
                        vendedor = vendedor + 1;
                    }
                    else
                    {
                        auditor = auditor + 1;
                    }
                }
            }
            lblVendedores.Text = Convert.ToString(vendedor);
            lblAdministradores.Text = Convert.ToString(admin);
            lblAuditores.Text = Convert.ToString(auditor);
        }

        private void placeHolderUsuario_Enter(object sender, EventArgs e)
        {
            if (txtBuscarUsuario.Text == "Buscar Usuario")
            {
                txtBuscarUsuario.Text = "";
                txtBuscarUsuario.ForeColor = Color.Black;
            }
        }

        private void placeHolderUsuario_Leave(object sender, EventArgs e)
        {
            if (txtBuscarUsuario.Text == "")
            {
                txtBuscarUsuario.Text = "Buscar Usuario";
                txtBuscarUsuario.ForeColor = Color.Silver;
            }
        }
    }
}
