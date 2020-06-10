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
            
            
                Marca marca = new Marca();
                marca.Mar_Codigo = Convert.ToString(dgwMarca.CurrentRow.Cells[0].Value);
                marca.Mar_Descripcion = txtDetalleMarca.Text;
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
            String msj = "Esta seguro que quiere elimnar " + this.txtDetalleMarca.Text;
            String codigo = Convert.ToString(dgwMarca.CurrentRow.Cells[0].Value);
            MessageBox.Show(msj, "Atencion");
            TrabajarMarca.bajaMarca(codigo);
               
                cargarMarca();
                MessageBox.Show("Eliminado");
            
        }
    }
}
