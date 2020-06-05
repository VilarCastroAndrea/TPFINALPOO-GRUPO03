using ClasesBase;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmLogin : Form
    {
        FrmMain formMain = new FrmMain();
        private int intentos;
        public Usuario user = new Usuario();

        public FrmLogin()
        {
            InitializeComponent();
            intentos = 0;
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
            DataTable dataTable = new DataTable();
            dataTable = ConectionLog.ingresar(txtUsuario.Text, txtContra.Text);
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
            user.Usu_NombreUsuario = dt.Rows[0]["USU_NombreUsuario"].ToString();
            user.Usu_Contraseña = dt.Rows[0]["USU_Password"].ToString();
            user.Usu_ApellidoNombre = dt.Rows[0]["USU_ApellidoNombre"].ToString();
            user.Rol_Codigo = dt.Rows[0]["ROL_Codigo"].ToString();
            user.Usu_ID = Convert.ToInt32(dt.Rows[0]["USU_ID"].ToString());
        }
    }
}
