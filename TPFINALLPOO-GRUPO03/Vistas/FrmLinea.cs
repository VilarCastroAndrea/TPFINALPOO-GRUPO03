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
    public partial class FrmLinea : Form
    {
        public FrmLinea()
        {
            InitializeComponent();
            cargarLineas();
            cargarComboMarca();
        }

        private void cargarLineas()
        {
            dgwLista.DataSource = TrabajarLinea.MostrarLineas();
        }
        public void cargarComboMarca()
        {
            cmbMarca.DisplayMember = "MAR_Codigo";
          
            cmbMarca.DataSource = TrabajarMarca.mostarMarcas();
        }


        private void btnAlta_Click(object sender, EventArgs e)
        {
            
            Linea linea = new Linea();
           
            if (txtNuevaLinea.Text != " ")
            {
                linea.Mar_Codigo = cmbMarca.Text;
                linea.Li_Descripcion = txtNuevaLinea.Text;
                TrabajarLinea.AgregarLineaV(linea);
                txtNuevaLinea.Text = "";
                dgwLista.DataSource = null;
                cargarLineas();
            }
            else
            {
                MessageBox.Show("complete todos los campos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {   
            String msj = "Esta seguro que quiere elimnar " + this.txtLinea.Text;
            int codigo = Convert.ToInt32(dgwLista.CurrentRow.Cells[0].Value);
            MessageBox.Show(msj, "Atencion");
            TrabajarLinea.EliminarLinea(codigo);

            cargarLineas();
            MessageBox.Show("Eliminado");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Linea linea = new Linea();
            linea.Li_Id = Convert.ToInt32(dgwLista.CurrentRow.Cells[0].Value);
            linea.Mar_Codigo =cmbMarca.Text;
            linea.Li_Descripcion= txtLinea.Text;
            TrabajarLinea.ModificarLinea(linea);
            MessageBox.Show("Linea Modificada");
            cargarLineas();
        }

        private void dgwLista_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwLista.CurrentRow != null)
            {
                txtLinea.Text = dgwLista.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
