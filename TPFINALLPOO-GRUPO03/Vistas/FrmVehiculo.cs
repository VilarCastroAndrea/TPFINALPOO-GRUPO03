﻿using ClasesBase;
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
        //acciones que se realizan al cargar el formulario vehiculo
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
        //carga la tabla con la lista de vehiculos
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
        //muestra el formulario de alta vehiculo
        private void btnAlta_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmAltaVehiculo>().FirstOrDefault();
            FrmAltaVehiculo frmAltaVehi = form ?? new FrmAltaVehiculo();
            AddFormInPanel(frmAltaVehi);
        }
        //ordena vehiculos por marca
        private void rbtnMarca_CheckedChanged(object sender, EventArgs e)
        {
            dataVehiculo.DataSource = TrabajarVehiculo.ordenarVporMarca();
        }
        //ordena vehiculos por linea
        private void rbtnLinea_CheckedChanged(object sender, EventArgs e)
        {
            dataVehiculo.DataSource = TrabajarVehiculo.ordenarVporLinea();
        }
        //muestra los vehiculos disponibles
        private void rbtnDisponible_CheckedChanged(object sender, EventArgs e)
        {
            dataVehiculo.DataSource = TrabajarVehiculo.listarVehiculoDisponible(true);
        }
        ///muestra los vehiculos NO disponibles
        private void rbtnVendido_CheckedChanged(object sender, EventArgs e)
        {
            dataVehiculo.DataSource = TrabajarVehiculo.listarVehiculoDisponible(false);
        }
        //busqueda de vehiculos
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
    }
}
