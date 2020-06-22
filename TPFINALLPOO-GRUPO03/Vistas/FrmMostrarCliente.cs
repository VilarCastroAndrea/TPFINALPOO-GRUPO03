using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMostrarCliente : Form
    {
        public FrmMostrarCliente()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Determina si el cliente esta disponible
        /// </summary>
        /// <param name="disponible"></param>
        public void disponibilidadDelCliente(bool disponible)
        {
            btnECliente.Enabled = disponible;
            btnMCliente.Enabled = disponible;
            txtNombre.Enabled = disponible;
            txtTelefono.Enabled = disponible;
            txtApellido.Enabled = disponible;
            txtDireccion.Enabled = disponible;
        }
        /// <summary>
        /// Modifica un cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMCliente_Click(object sender, EventArgs e)
        {
            String msj = "Esta seguro que quiere modificar este Cliente " + this.txtDni.Text;
            DialogResult dialogResult = MessageBox.Show(msj, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Cliente c = new Cliente();
                Form frmCliente = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmCliente);
                if (frmCliente != null)
                {
                    c.Cli_DNI = txtDni.Text;
                    c.Cli_Nombre = txtNombre.Text;
                    c.Cli_Apellido = txtApellido.Text;
                    c.Cli_Direccion = txtDireccion.Text;
                    c.Cli_Telefono = txtTelefono.Text;
                    TrabajarCliente.modificarCliente(c);
                    MessageBox.Show("Cliente Modificado");
                    ((FrmCliente)frmCliente).cargarCliente();
                }
            }


        }
        /// <summary>
        /// Elimina un cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnECliente_Click(object sender, EventArgs e)
        {
            Form frmCliente = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmCliente);
            String msj = "Esta seguro que quiere Elimnar este Cliente" + this.txtDni.Text;
            int id = Convert.ToInt32(txtDni.Text);
            DialogResult dialogResult = MessageBox.Show(msj, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (frmCliente != null)
                {
                    try
                    {
                        TrabajarCliente.bajaClienteFisica(txtDni.Text);
                        MessageBox.Show("Cliente Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch
                    {
                        TrabajarCliente.bajaCliente(txtDni.Text, false);
                        MessageBox.Show("Cliente Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
                        
                    }
                    finally
                    {
                        ((FrmCliente)frmCliente).cargarCliente();
                        ((FrmCliente)frmCliente).contar();
                    }

                }
            }
        }
        /// <summary>
        /// Validaciones en text Box Para datos validos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            btnMCliente.Enabled = true;
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            btnMCliente.Enabled = true;
        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            btnMCliente.Enabled = true;
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            btnMCliente.Enabled = true;
        }
    }
}
