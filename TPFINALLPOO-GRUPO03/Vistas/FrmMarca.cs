using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
            cargarMarca();
        }

        private void btnMoficar_Click(object sender, EventArgs e)
        {
                   String cod= Convert.ToString(dgwMarca.CurrentRow.Cells[0].Value);
                Marca marca = new Marca();
                marca.Mar_Codigo = cod;
            marca.Mar_Descripcion = txtDetalle.Text;
            TrabajarMarca.modificarMarca(marca);
                MessageBox.Show("Marca Modificado");
                cargarMarca();
            

        }

        private void cargarMarca()
        {
            dgwMarca.DataSource = TrabajarMarca.mostarMarcas();
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String msj = "Esta seguro que quiere elimnar " + this.txtMarca.Text;

            try
            {
                String codigo = Convert.ToString(dgwMarca.CurrentRow.Cells[0].Value);
                MessageBox.Show(msj, "Atencion");
                TrabajarMarca.bajaMarca(codigo);

                cargarMarca();
                MessageBox.Show("Eliminado");

            }
            catch
            {
                MessageBox.Show("No se puede eliminar porque tiene una referencia a linea");
            }
           
            
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {

                MessageBox.Show("Debe completar la Marca");

               

            }
            else
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Debe completar la Descripcion");
                }
                else
                {

               
                marca.Mar_Codigo = txtCodigo.Text;
                marca.Mar_Descripcion = txtDescripcion.Text;
                TrabajarMarca.altaMarca(marca);
                txtCodigo.Text = "";
                txtDescripcion.Text = "";
                dgwMarca.DataSource = null;
                cargarMarca();
                }
            }
            
        }

        private void dgwMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgwMarca_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwMarca.CurrentRow != null)
            {
                txtMarca.Text = dgwMarca.CurrentRow.Cells[0].Value.ToString();
                txtDetalle.Text = dgwMarca.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frmAltaVehiculo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmAltaVehiculo);
            ((FrmAltaVehiculo)frmAltaVehiculo).cmbMarca.ResetText();
           ((FrmAltaVehiculo)frmAltaVehiculo).cargarMarcas();

            


        }
    }
    
}
