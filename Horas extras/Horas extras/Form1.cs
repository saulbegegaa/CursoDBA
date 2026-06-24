using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horas_extras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int horas = int.Parse(txtHoras.Text);
            double salarioHora = Convert.ToDouble(txtSalario.Text);

            double salario;
            int horasExtra = 0;

            if (horas <= 40)
            {
                salario = horas * salarioHora;

                MessageBox.Show(
                    "Horas trabajadas: " + horas +
                    "\nSalario por hora: " + salarioHora +
                    "\nSalario: " + salario,
                    "Empleado sin horas extra");
            }
            else
            {
                horasExtra = horas - 40;

                salario = (40 * salarioHora) + (horasExtra * salarioHora * 1.5);

                MessageBox.Show(
                    "Horas trabajadas: " + horas +
                    "\nSalario por hora: " + salarioHora +
                    "\nHoras extra: " + horasExtra +
                    "\nSalario: " + salario,
                    "Empleado con horas extra");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
