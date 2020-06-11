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
        }


        private void btnAlta_Click(object sender, EventArgs e)
        {
            Linea linea = new Linea();
            if (txtNuevaLinea.Text != " ")
            {
                TrabajarLinea.AgregarLineaV(linea);
                txtNuevaLinea.Text = "";
                dgwLista.DataSource = null;
                cargarTi();
            }
            else
            {
                MessageBox.Show("complete todos los campos");
            }
        }
    }
}
