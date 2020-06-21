using ClasesBase;
using System;
using System.Data;
using System.Drawing;
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
        /// <summary>
        /// acciones que se realizan al cargar el formulario vehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarVehiculo>().FirstOrDefault();
            FrmMostrarVehiculo frmLista = form ?? new FrmMostrarVehiculo();
            AddFormInPanel(frmLista);
            cargarVehiculos();

        }
        /// <summary>
        /// restringir acceso segun usuario
        /// </summary>
        public void restringirAcceso()
        {
            Form frmLogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmLogin);
            if (frmLogin != null)
            {
                if (((FrmLogin)frmLogin).user.Rol_Codigo == "Auditor")
                {
                    btnAlta.Visible = false;
                    panelVehiculo.Enabled = false;
                    btnTipo.Visible = false;
                    btnClase.Visible = false;
                }
                else
                {
                    btnAlta.Visible = true;
                    panelVehiculo.Enabled = true;
                    btnTipo.Visible = true;
                    btnClase.Visible = true;
                }
            }
        }
        /// <summary>
        /// Agrega formulario al panel
        /// </summary>
        /// <param name="fh"></param>
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
        /// <summary>
        /// carga la tabla con la lista de vehiculos
        /// </summary>
        public void cargarVehiculos()
        {
            dataVehiculo.DataSource = TrabajarVehiculo.listarVehiculo();
            contar();

        }


        /// <summary>
        /// carga los datos del data grid vehiculo al formulario frmMostrarVehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).btnMVehiculo.Enabled = false;
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).marca = dataVehiculo.CurrentRow.Cells[1].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).modelo = dataVehiculo.CurrentRow.Cells[3].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).color = dataVehiculo.CurrentRow.Cells[4].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).cantPuertas = dataVehiculo.CurrentRow.Cells[5].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).tipoVehiculo = dataVehiculo.CurrentRow.Cells[6].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).claseVehiculo = dataVehiculo.CurrentRow.Cells[7].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).gps = Convert.ToBoolean(dataVehiculo.CurrentRow.Cells[8].Value);
                }
            }
        }


        /// <summary>
        /// carga en el panel el formulario frmMostrarVehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarVehiculo>().FirstOrDefault();
            FrmMostrarVehiculo frmMostrar = form ?? new FrmMostrarVehiculo();
            AddFormInPanel(frmMostrar);
        }
        /// <summary>
        ///  carga en el panel el formulario frmMostrarVehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlta_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmAltaVehiculo>().FirstOrDefault();
            FrmAltaVehiculo frmAltaVehi = form ?? new FrmAltaVehiculo();
            AddFormInPanel(frmAltaVehi);


        }
        /// <summary>
        /// ordena vehiculos por marca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnMarca_CheckedChanged(object sender, EventArgs e)
        {
            dataVehiculo.DataSource = TrabajarVehiculo.ordenarVporMarca();
        }
        /// <summary>
        /// ordena vehiculos por linea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnLinea_CheckedChanged(object sender, EventArgs e)
        {
            dataVehiculo.DataSource = TrabajarVehiculo.ordenarVporLinea();
        }
        /// <summary>
        /// muestra los vehiculos disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnDisponible_CheckedChanged(object sender, EventArgs e)
        {
            dataVehiculo.DataSource = TrabajarVehiculo.listarVehiculoDisponible(true);

        }
        /// <summary>
        /// muestra los vehiculos NO disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnVendido_CheckedChanged(object sender, EventArgs e)
        {
            dataVehiculo.DataSource = TrabajarVehiculo.listarVehiculoDisponible(false);

        }
        /// <summary>
        /// busqueda de vehiculos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscarvehiculo = txtBuscarVehiculo.Text;
            if (txtBuscarVehiculo.Text != "Buscar Vehiculo")
            {
                dataVehiculo.DataSource = TrabajarVehiculo.buscarVehiculo(txtBuscarVehiculo.Text);
            }
            else
            {
                cargarVehiculos();

            }
        }
        /// <summary>
        /// abre el formulario tipo vehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTipo_Click(object sender, EventArgs e)
        {
            FrmTipoVehiculo frmTipoVehiculo = new FrmTipoVehiculo();
            frmTipoVehiculo.Show();
        }
        /// <summary>
        /// abre el formulario clase vehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClase_Click(object sender, EventArgs e)
        {
            FrmClaseVehiculo frmClaseVehiculo = new FrmClaseVehiculo();
            frmClaseVehiculo.Show();
        }


        /// <summary>
        /// cuenta vehiculos: vendidos.disponibles,total
        /// </summary>
        public void contar()
        {
            dataVehiculo.Refresh();
            int t = dataVehiculo.Rows.Count;
            lblcantVehiculo.Text = Convert.ToString(t);

            int disponible = 0;
            int vendido = 0;

            foreach (DataGridViewRow fila in dataVehiculo.Rows)
            {
                if (fila.Cells[10].Value.Equals(true))
                {
                    disponible = disponible + 1;
                }
                else
                {
                    vendido = vendido + 1;
                }
            }
            lblVehDiponibles.Text = Convert.ToString(disponible);
            lblVehiculosVendi.Text = Convert.ToString(vendido);

        }
        /// <summary>
        /// PLACE HOLDER DE BUSCAR USUARIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void placeHolderVehiculo(object sender, EventArgs e)
        {
            if (txtBuscarVehiculo.Text == "Buscar Vehiculo")
            {
                txtBuscarVehiculo.Text = "";
                txtBuscarVehiculo.ForeColor = Color.Black;
            }
        }

        private void placeHolderVehiculo_Leave(object sender, EventArgs e)
        {
            if (txtBuscarVehiculo.Text == "")
            {
                txtBuscarVehiculo.Text = "Buscar Vehiculo";
                txtBuscarVehiculo.ForeColor = Color.Silver;
            }
        }
    }
}
