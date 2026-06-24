using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validaciones_de_controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbEmpresa.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una empresa");
                return;
            }

            if (cmbSalida.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un lugar de salida");
                return;
            }

            if (cmbLlegada.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un lugar de llegada");
                return;
            }

            if (!rb1.Checked && !rb2.Checked && !rb3.Checked && !rb4.Checked)
            {
                MessageBox.Show("Seleccione la cantidad de personas");
                return;
            }

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Introduzca su nombre");
                txtNombre.Focus();
                return;
            }

            if (txtCorreo.Text.Trim() == "")
            {
                MessageBox.Show("Introduzca su correo electrónico");
                txtCorreo.Focus();
                return;
            }

            string personas = "";

            if (rb1.Checked) personas = "1 persona";
            if (rb2.Checked) personas = "2 personas";
            if (rb3.Checked) personas = "3 personas";
            if (rb4.Checked) personas = "4 personas";

            string mensaje =
                "Estimado " + txtNombre.Text + "\n" +
                "Reserva realizada para el día " + dtpSalida.Value.ToString("dd/MM/yyyy") + "\n" +
                cmbLlegada.Text + "\n" +
                "Para " + personas;

            MessageBox.Show(mensaje);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
