using ClasesBase;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmLogin : Form
    {

        private int intentos;
        public Usuario user = new Usuario();

        public FrmLogin()
        {
            InitializeComponent();
            ocultarCapcha();
        }

        /// <summary>
        /// Muestra el capcha despues del los intentos
        /// </summary>
        private void mostrarCapcha()
        {
            imgCapcha.Visible = true;
            txtResultadoCapcha.Visible = true;
            lblCapcha.Visible = true;
            lblCapcha.Text = generarCapcha();
        }

        /// <summary>
        /// Oculta los elemento del captcha
        /// </summary>
        private void ocultarCapcha()
        {
            imgCapcha.Visible = false;
            txtResultadoCapcha.Visible = false;
            lblCapcha.Visible = false;
            intentos = 0;
        }

        /// <summary>
        /// generador de palabra para el captcha
        /// </summary>
        /// <returns></returns>
        public String generarCapcha()
        {
            Random rdm = new Random();
            int opcion = rdm.Next(0, 5);
            String resultado = null;
            String[] capcha;
            capcha = new string[5];
            capcha[0] = "AuTmcK";
            capcha[1] = "bdpXAa";
            capcha[2] = "aniycp";
            capcha[3] = "MkpatW";
            capcha[4] = "ertyui";
            resultado = capcha[opcion];
            return resultado;
        }

        /// <summary>
        /// BtnIngresar valida campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (intentos < 5)
            {
                ingresar();
            }
            else
            {
                if (lblCapcha.Text == txtResultadoCapcha.Text)
                {
                    ingresar();
                }
                else
                {
                    MessageBox.Show("Capcha incorrecto");
                    lblCapcha.Text = generarCapcha();
                }
            }
        }

        /// <summary>
        /// Valida
        /// </summary>
        private void ingresar()
        {
            FrmMain formMain = new FrmMain();
            DataTable dataTable = new DataTable();
            dataTable = TrabajarUsuario.ingresoUsuario(txtUsuario.Text, txtContra.Text);
            if (dataTable.Rows.Count != 0)
            {
                guardarUser(dataTable);
                if ((user.Usu_NombreUsuario == txtUsuario.Text) && (user.Usu_Contraseña == txtContra.Text))
                {
                    this.Hide();
                    formMain.lblNom.Text = "BIENVENIDO: " + user.Usu_ApellidoNombre;
                    formMain.Show();
                }
            }
            else
            {
                intentos++;
                intentosMaximos();
                txtContra.Text = "";
                txtContra.Focus();
                MessageBox.Show("Datos incorrectos");
            }
        }

        /// <summary>
        /// control
        /// </summary>
        private void intentosMaximos()
        {
            if (intentos > 4)
            {
                mostrarCapcha();
            }
        }

        /// <summary>
        /// Guarda el usuario logueado
        /// </summary>
        /// <param name="dt"></param>
        private void guardarUser(DataTable dt)
        {
            user.Usu_NombreUsuario = dt.Rows[0]["Nombre de Usuario"].ToString();
            user.Usu_Contraseña = dt.Rows[0]["Contraseña"].ToString();
            user.Usu_ApellidoNombre = dt.Rows[0]["Apellido y Nombre"].ToString();
            user.Rol_Codigo = dt.Rows[0]["Rol"].ToString();
            user.Usu_ID = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
        }



        public void limpiarCampos()
        {
            txtUsuario.Text = "";
            txtContra.Text = "";
            txtResultadoCapcha.Text = "";
            ocultarCapcha();
            txtUsuario.Focus();
        }
    }
}
