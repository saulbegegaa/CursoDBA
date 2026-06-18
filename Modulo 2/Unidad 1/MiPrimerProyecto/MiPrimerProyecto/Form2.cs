using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerProyecto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                // PASO 1: Verificar si están vacíos
                if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
                {
                    MessageBox.Show("Error: Los cuadros de texto no pueden estar vacíos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // PASO 2: Verificar si son números válidos
                if (!double.TryParse(txtNumero1.Text, out double num1) || !double.TryParse(txtNumero2.Text, out double num2))
                {
                    MessageBox.Show("Error: Solo se permiten números.", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // PASO 3: Realizar la operación 
                double resultado = num1 + num2;
                txtResultado.Text = resultado.ToString();

         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
            txtNumero1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // PASO 1: Verificar si están vacíos
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Error: Los cuadros de texto no pueden estar vacíos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // PASO 2: Verificar si son números válidos
            if (!double.TryParse(txtNumero1.Text, out double num1) || !double.TryParse(txtNumero2.Text, out double num2))
            {
                MessageBox.Show("Error: Solo se permiten números.", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // PASO 3: Realizar la operación 
            double resultado = num1 - num2;
            txtResultado.Text = resultado.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // PASO 1: Verificar si están vacíos
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Error: Los cuadros de texto no pueden estar vacíos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // PASO 2: Verificar si son números válidos
            if (!double.TryParse(txtNumero1.Text, out double num1) || !double.TryParse(txtNumero2.Text, out double num2))
            {
                MessageBox.Show("Error: Solo se permiten números.", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // PASO 3: Realizar la operación 
            double resultado = num1 * num2;
            txtResultado.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // PASO 1: Verificar si están vacíos
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Error: Los cuadros de texto no pueden estar vacíos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // PASO 2: Verificar si son números válidos
            if (!double.TryParse(txtNumero1.Text, out double num1) || !double.TryParse(txtNumero2.Text, out double num2))
            {
                MessageBox.Show("Error: Solo se permiten números.", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (num2 == 0)
            {
                MessageBox.Show("Error: No se puede dividir entre cero.", "División Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // PASO 3: Realizar la operación 
            double resultado = num1 / num2;
            txtResultado.Text = resultado.ToString();
         
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
