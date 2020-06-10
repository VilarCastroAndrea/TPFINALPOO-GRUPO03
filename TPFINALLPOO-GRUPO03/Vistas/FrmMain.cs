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

        /// <summary>
        /// Eventos al cargar el formulario
        /// </summary>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmVenta>().FirstOrDefault();
            FrmVenta fventa = form ?? new FrmVenta();
            fventa.restringirAcceso();
            AddFormInPanel(fventa);
            restringirAcceso();
        }

        /// <summary>
        /// Llamada a formulario
        /// </summary>
        /// <param name="fh"></param>
        private void AddFormInPanel(Form fh)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
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
                    btnUsuario.Visible = false;
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
            frmUsuario.restringirAcceso();
            AddFormInPanel(frmUsuario);
        }
        /// <summary>
        /// Ingresa a formulario Cliente al hacer click en boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCliente_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmCliente>().FirstOrDefault();
            FrmCliente fcliente = form ?? new FrmCliente();
            fcliente.restringirAcceso();
            AddFormInPanel(fcliente);
        }
        /// <summary>
        /// Ingresa a formulario Vehiculo al hacer click en boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmVehiculo>().FirstOrDefault();
            FrmVehiculo fvehiculo = form ?? new FrmVehiculo();
            fvehiculo.restringirAcceso();
            AddFormInPanel(fvehiculo);
        }
        /// <summary>
        /// Ingresa a formulario Venta al hacer click en boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVenta_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmVenta>().FirstOrDefault();
            FrmVenta fventa = form ?? new FrmVenta();
            fventa.restringirAcceso();
            AddFormInPanel(fventa);
        }
        /// <summary>
        /// Salir del Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Desea salir?", "Atención", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Cerrar sesion 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Desea cerrar sesion?", "Atención", MessageBoxButtons.YesNo);

            Form frmLogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmLogin);
            ((FrmLogin)frmLogin).user = new ClasesBase.Usuario();
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
                ((FrmLogin)frmLogin).limpiarCampos();
                frmLogin.Show();
            }
        }
        /// <summary>
        /// Muestra La hora en el menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
