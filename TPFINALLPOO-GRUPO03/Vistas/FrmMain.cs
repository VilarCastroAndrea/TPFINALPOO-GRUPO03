using System;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmUsuario>().FirstOrDefault();
            FrmUsuario frmUsuario = form ?? new FrmUsuario();
            AddFormInPanel(frmUsuario);
            restringirAcceso();
        }

        /// <summary>
        /// Muestra fecha y hora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        /// <summary>
        /// Llamada a formulario
        /// </summary>
        /// <param name="fh"></param>
        private void AddFormInPanel(Form fh)
        {
            if (this.panelContenedorPrincipar.Controls.Count > 0)
                this.panelContenedorPrincipar.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorPrincipar.Controls.Add(fh);
            this.panelContenedorPrincipar.Tag = fh;
            fh.Show();
        }

        /// <summary>
        /// Validacion de tipo usuario
        /// </summary>
        public void restringirAcceso()
        {
            Form frmLogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmLogin);
            if (frmLogin != null)
            {
                if (((FrmLogin)frmLogin).user.Rol_Codigo == "Administrador")
                {
                    btnCliente.Visible = false;
                }
                else if (((FrmLogin)frmLogin).user.Rol_Codigo == "Vendedor")
                {
                    btnVehiculo.Visible = false;
                }
            }

        }

        /// <summary>
        /// Botones para mostrar formularios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmUsuario>().FirstOrDefault();
            FrmUsuario frmUsuario = form ?? new FrmUsuario();
            AddFormInPanel(frmUsuario);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmCliente>().FirstOrDefault();
            FrmCliente fcliente = form ?? new FrmCliente();
            AddFormInPanel(fcliente);
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmVehiculo>().FirstOrDefault();
            FrmVehiculo fvehiculo = form ?? new FrmVehiculo();
            AddFormInPanel(fvehiculo);
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmVenta>().FirstOrDefault();
            FrmVenta fventa = form ?? new FrmVenta();
            AddFormInPanel(fventa);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Desea salir?", "Atención", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Desea cerrar sesion?", "Atención", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {

            }
        }


    }
}
