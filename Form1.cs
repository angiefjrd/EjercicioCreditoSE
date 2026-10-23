using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioCreditoSE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtIngresos.Text, out decimal ingresos)
    || ingresos < 0)
            {
                MessageBox.Show("Ingrese una cantidad valida de ingresos.");
                txtIngresos.Focus();
                return;
            }

            if (!rbPermanente.Checked && !rbTemporal.Checked)
            {
                MessageBox.Show("Seleccione el tipo de empleo.");
                return;
            }

            if (!rbSinAtrasos.Checked && !rbConAtrasos.Checked)
            {
                MessageBox.Show("Seleccione el historial crediticio.");
                return;
            }

            string capacidad;

            if (ingresos > 50000 && rbPermanente.Checked)
            {
                capacidad = "Alta";
            }
            else if (ingresos >= 25000 &&
                     ingresos <= 50000 &&
                     rbPermanente.Checked)
            {
                capacidad = "Media";
            }
            else
            {
                capacidad = "Baja";
            }

            string historial;

            if (rbSinAtrasos.Checked)
            {
                historial = "Bueno";
            }
            else
            {
                historial = "Riesgoso";
            }

            string cliente;

            if (capacidad == "Alta" && historial == "Bueno")
            {
                cliente = "Preferencial";
            }
            else if (capacidad == "Media" && historial == "Bueno")
            {
                cliente = "Regular";
            }
            else
            {
                cliente = "De riesgo";
            }

            string credito;
            string plazo;

            if (cliente == "Preferencial")
            {
                credito = "Hipotecario";
                plazo = "Largo";
            }
            else if (cliente == "Regular")
            {
                credito = "Vehicular";
                plazo = "Medio";
            }
            else
            {
                credito = "Prestamo personal";
                plazo = "Corto";
            }

            lblCapacidad.Text = "Capacidad de pago: " + capacidad;
            lblHistorial.Text = "Historial crediticio: " + historial;
            lblCliente.Text = "Tipo de cliente: " + cliente;
            lblCredito.Text = "Credito recomendado: " + credito;
            lblPlazo.Text = "Plazo recomendado: " + plazo;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIngresos.Clear();

            rbPermanente.Checked = false;
            rbTemporal.Checked = false;

            rbSinAtrasos.Checked = false;
            rbConAtrasos.Checked = false;

            lblCapacidad.Text = "Capacidad de pago:";
            lblHistorial.Text = "Historial crediticio:";
            lblCliente.Text = "Tipo de cliente:";
            lblCredito.Text = "Credito recomendado:";
            lblPlazo.Text = "Plazo recomendado:";

            txtIngresos.Focus();
        }
    }
}
