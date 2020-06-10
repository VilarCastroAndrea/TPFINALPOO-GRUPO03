﻿using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmAltaVehiculo : Form
    {
        public FrmAltaVehiculo()
        {
            InitializeComponent();
        }
        //al cargar el formulario carga todos los tipos y las clases
        private void FrmAltaVehiculo_Load(object sender, EventArgs e)
        {
            cargarTipo();
            cargarClase();
        }
        //Determina si posee gps
        private bool poseeGPS()
        {
            if (sGps.Checked)
            {
                return true;
            }
            return false;
        }
        // Realiza el alta de vehiculo
        private void btnAltaVeh_Click(object sender, EventArgs e)
        {

            String opcionGPS = "No";
            if (cmbModelo.Text != "" && cmbCantPuert.Text != "" && cmbColor.Text != "" && txtALinea.Text != "" && cmbMarca.Text != "" && txtAMatricula.Text != "" && cmbTipo.Text != "" && txtAPrecio.Text != "" && cmbClase.Text != "")
            {
                int m = Convert.ToInt32(cmbModelo.Text);
                int p = Convert.ToInt32(cmbCantPuert.Text);
                Decimal precio = Convert.ToDecimal(txtAPrecio.Text);
                int tipo = Convert.ToInt32(cmbTipo.SelectedValue);
                int clase = Convert.ToInt32(cmbClase.SelectedValue);
                Vehiculo vehiculo = new Vehiculo(txtAMatricula.Text, cmbMarca.Text, txtALinea.Text, m, cmbColor.Text, p, poseeGPS(), tipo, clase, precio, true);
                if (poseeGPS())
                {
                    opcionGPS = "Si";
                }
                DialogResult result = MessageBox.Show("Los Datos ingresados son correctos? " + "\n" +
                                                       "Matricula: " + vehiculo.Veh_Matricula + "\n" +
                                                       "Marca: " + vehiculo.Veh_Marca + "\n" +
                                                       "Linea: " + vehiculo.Veh_Linea + "\n" +
                                                       "Modelo: " + vehiculo.Veh_Modelo + "\n" +
                                                       "Color: " + vehiculo.Veh_Color + "\n" +
                                                       "Puertas: " + vehiculo.Veh_Puertas + "\n" +
                                                       "GPS: " + opcionGPS + "\n" +
                                                       "Tipo de Vehiculo: " + vehiculo.Tv_ID + "\n" +
                                                       "Clase de Vehiculo: " + vehiculo.Cv_ID + "\n" +
                                                       "Precio: " + vehiculo.Veh_Precio, "Agregar Vehiculo", MessageBoxButtons.OKCancel);

                try
                {
                    if (result == DialogResult.OK)
                    {
                        TrabajarVehiculo.altaVehiculo(vehiculo);

                        txtAMatricula.Text = "";
                        cmbMarca.Text = "";
                        txtALinea.Text = "";
                        cmbModelo.Text = "";
                        cmbColor.Text = "";
                        cmbCantPuert.Text = "";
                        sGps.Checked = false;
                        nGps.Checked = false;
                        cmbTipo.Text = "";
                        cmbClase.Text = "";
                        txtAPrecio.Text = "";
                        Form frmListaVehiculo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmVehiculo);
                        if (frmListaVehiculo != null)
                        {
                            ((FrmVehiculo)frmListaVehiculo).dataVehiculo.DataSource = null;
                            ((FrmVehiculo)frmListaVehiculo).dataVehiculo.DataSource = TrabajarVehiculo.listarVehiculo();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Se cancelo el alta del Vehiculo", "Cancelado");
                        result = new DialogResult();
                    }
                }
                catch
                {
                    MessageBox.Show("Matricula Repetida");
                    txtAMatricula.Text = "";
                    txtAMatricula.Focus();
                }

            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        //carga los tipos de vehiculos
        public void cargarTipo()
        {
            cmbTipo.DisplayMember = "Descripcion";
            cmbTipo.ValueMember = "ID";
            cmbTipo.DataSource = TrabajarTipoVehiculo.listarTipoVehDisponible();
        }
        //carga las clases de vehiculo
        public void cargarClase()
        {
            cmbClase.DisplayMember = "Descripcion";
            cmbClase.ValueMember = "ID";
            cmbClase.DataSource = TrabajarClaseVehiculo.listarClaseVehDisponible();
        }



        //validacion matricula maxima de 7
        private void txtAMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtAMatricula.MaxLength = 7;
                   
         }

        //Valida el que el campo precio solo tenga numeros
        private void txtAPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.SetError(txtAPrecio, "ingrese solo numeros");
        }
    }
}
