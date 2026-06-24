using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerVehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbAutobus.CheckedChanged -= rbAutobus_CheckedChanged;
            rbTractor.CheckedChanged -= rbTractor_CheckedChanged;

            rbAutobus.Checked = false;
            rbTractor.Checked = false;
            radioButton1.Checked = true;

            rbAutobus.CheckedChanged += rbAutobus_CheckedChanged;
            rbTractor.CheckedChanged += rbTractor_CheckedChanged;

            txtPlacas.Enabled = false;
            txtPrecio.Enabled = false;
            txtKmRenta.Enabled = false;
            txtKmDevolver.Enabled = false;
            dtpRenta.Enabled = false;
            dtpDevolucion.Enabled = false;
        }

        private void rbAutobus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutobus.Checked)
            {
                txtPlacas.Enabled = true;
                txtPrecio.Enabled = true;

                txtKmRenta.Enabled = true;
                txtKmDevolver.Enabled = true;

                dtpRenta.Enabled = false;
                dtpDevolucion.Enabled = false;
            }
        }

        private void rbTractor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTractor.Checked)
            {
                txtPlacas.Enabled = true;
                txtPrecio.Enabled = true;

                txtKmRenta.Enabled = false;
                txtKmDevolver.Enabled = false;

                dtpRenta.Enabled = true;
                dtpDevolucion.Enabled = true;
            }
        }

        private void btnRentar_Click(object sender, EventArgs e)
        {
            string placas = txtPlacas.Text;
            double precio = Convert.ToDouble(txtPrecio.Text);

            if (rbAutobus.Checked)
            {
                int kmRenta = Convert.ToInt32(txtKmRenta.Text);
                int kmDevolver = Convert.ToInt32(txtKmDevolver.Text);

                int kmRecorridos = kmDevolver - kmRenta;
                double importe = kmRecorridos * precio;

                MessageBox.Show(
                    "Placas: " + placas + "\n" +
                    "Km al rentar: " + kmRenta + "\n" +
                    "Km al devolver: " + kmDevolver + "\n" +
                    "Kilómetros recorridos: " + kmRecorridos + "\n" +
                    "Precio por km: " + precio.ToString("C") + "\n" +
                    "Importe a pagar: " + importe.ToString("C"),
                    "RENTA DE AUTOBÚS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (rbTractor.Checked)
            {
                int dias = (dtpDevolucion.Value.Date - dtpRenta.Value.Date).Days;

                double importe = dias * precio;

                MessageBox.Show(
                    "Placas: " + placas + "\n" +
                    "Fecha de renta: " + dtpRenta.Value.ToShortDateString() + "\n" +
                    "Fecha de devolución: " + dtpDevolucion.Value.ToShortDateString() + "\n" +
                    "Días rentados: " + dias + "\n" +
                    "Precio por día: " + precio.ToString("C") + "\n" +
                    "Importe a pagar: " + importe.ToString("C"),
                    "RENTA DE TRACTOR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione un vehículo.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
