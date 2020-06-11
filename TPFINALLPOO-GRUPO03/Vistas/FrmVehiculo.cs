using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmVehiculo : Form
    {
        public FrmVehiculo()
        {
            InitializeComponent();
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarVehiculo>().FirstOrDefault();
            FrmMostrarVehiculo frmLista = form ?? new FrmMostrarVehiculo();
            AddFormInPanel(frmLista);
            cargarVehiculos();
        }

        private void AddFormInPanel(Form fh)
        {
            if (this.panelVehiculo.Controls.Count > 0)
                this.panelVehiculo.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelVehiculo.Controls.Add(fh);
            this.panelVehiculo.Tag = fh;
            fh.Show();
        }

        public void cargarVehiculos()
        {
            dataVehiculo.DataSource = TrabajarVehiculo.listarVehiculo();
        }

        private void dataVehiculo_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.dataVehiculo.CurrentRow != null)
            {
                FrmMostrarVehiculo frmMosVehiculo = new FrmMostrarVehiculo();
                Form frmMostrarVehiculo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmMostrarVehiculo);
                if (frmMostrarVehiculo != null)
                {
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).txtAMatricula.Text = dataVehiculo.CurrentRow.Cells[0].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).cmbMarca.Text = dataVehiculo.CurrentRow.Cells[1].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).txtALinea.Text = dataVehiculo.CurrentRow.Cells[2].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).cmbModelo.Text = dataVehiculo.CurrentRow.Cells[3].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).cmbColor.Text = dataVehiculo.CurrentRow.Cells[4].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).cmbCantPuert.Text = dataVehiculo.CurrentRow.Cells[5].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).cmbTipo.Text = dataVehiculo.CurrentRow.Cells[6].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).cmbClase.Text = dataVehiculo.CurrentRow.Cells[7].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).txtAPrecio.Text = dataVehiculo.CurrentRow.Cells[9].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).determinarVistaGps(Convert.ToBoolean(dataVehiculo.CurrentRow.Cells[8].Value));
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).habilitarDesabilitarCampos(Convert.ToBoolean(dataVehiculo.CurrentRow.Cells[10].Value));
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarVehiculo>().FirstOrDefault();
            FrmMostrarVehiculo frmMostrar = form ?? new FrmMostrarVehiculo();
            AddFormInPanel(frmMostrar);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmAltaVehiculo>().FirstOrDefault();
            FrmAltaVehiculo frmAltaVehi = form ?? new FrmAltaVehiculo();
            AddFormInPanel(frmAltaVehi);
        }

        private void rbtnMarca_CheckedChanged(object sender, EventArgs e)
        {
            dataVehiculo.DataSource = TrabajarVehiculo.ordenarVporMarca();
        }

        private void rbtnLinea_CheckedChanged(object sender, EventArgs e)
        {
            dataVehiculo.DataSource = TrabajarVehiculo.ordenarVporLinea();
        }

        private void rbtnDisponible_CheckedChanged(object sender, EventArgs e)
        {
            dataVehiculo.DataSource = TrabajarVehiculo.listarVehiculoDisponible(true);
        }

        private void rbtnVendido_CheckedChanged(object sender, EventArgs e)
        {
            dataVehiculo.DataSource = TrabajarVehiculo.listarVehiculoDisponible(false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscarvehiculo = txtBuscarVehiculo.Text;
            if (txtBuscarVehiculo.Text != "")
            {
                dataVehiculo.DataSource = TrabajarVehiculo.buscarVehiculo(txtBuscarVehiculo.Text);
            }
            else
            {
                dataVehiculo.DataSource = TrabajarVehiculo.listarVehiculo();
                dataVehiculo.Refresh();
            }
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            FrmTipoVehiculo frmTipoVehiculo = new FrmTipoVehiculo();
            frmTipoVehiculo.Show();
        }

        private void btnClase_Click(object sender, EventArgs e)
        {
            FrmClaseVehiculo frmClaseVehiculo = new FrmClaseVehiculo();
            frmClaseVehiculo.Show();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            FrmMarca frmMarca = new FrmMarca();
            frmMarca.Show();
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            FrmLinea frmLinea = new FrmLinea();
            frmLinea.Show();
        }
    }
}
