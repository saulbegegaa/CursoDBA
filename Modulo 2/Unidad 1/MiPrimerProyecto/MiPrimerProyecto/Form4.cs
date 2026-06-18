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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonCheck_Click(object sender, EventArgs e)
        {
            // 1. Convertimos el texto actual de intentos a un número entero
            int intentos = int.Parse(txtResult.Text);

            // 2. Comprobamos si ya alcanzó el límite antes de hacer nada
            if (intentos >= 4)
            {
                MessageBox.Show("Has agotado tus 4 intentos. ¡Juego terminado!", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene el código aquí y no evalúa el crucigrama
            }

            // 3. Sumamos el intento actual y actualizamos la caja de texto
            intentos++;
            txtResult.Text = intentos.ToString();

            t1.BackColor = (t1.Text.ToUpper() == "L") ? Color.LightGreen : Color.Tomato;
            t2.BackColor = (t2.Text.ToUpper() == "O") ? Color.LightGreen : Color.Tomato;
            t3.BackColor = (t3.Text.ToUpper() == "R") ? Color.LightGreen : Color.Tomato;
            t4.BackColor = (t4.Text.ToUpper() == "O") ? Color.LightGreen : Color.Tomato;
            t5.BackColor = (t5.Text.ToUpper() == "S") ? Color.LightGreen : Color.Tomato;
            t6.BackColor = (t6.Text.ToUpper() == "R") ? Color.LightGreen : Color.Tomato;
            t7.BackColor = (t7.Text.ToUpper() == "O") ? Color.LightGreen : Color.Tomato;
            t8.BackColor = (t8.Text.ToUpper() == "R") ? Color.LightGreen : Color.Tomato;
            t9.BackColor = (t9.Text.ToUpper() == "A") ? Color.LightGreen : Color.Tomato;
            t10.BackColor = (t10.Text.ToUpper() == "T") ? Color.LightGreen : Color.Tomato;
            t11.BackColor = (t11.Text.ToUpper() == "N") ? Color.LightGreen : Color.Tomato;

            if ((t1.Text.ToUpper() == "L") && (t2.Text.ToUpper() == "O") && 
                (t3.Text.ToUpper() == "R") && (t4.Text.ToUpper() == "O") && 
                (t5.Text.ToUpper() == "S") && (t6.Text.ToUpper() == "R") && 
                (t7.Text.ToUpper() == "O") && (t8.Text.ToUpper() == "R") && 
                (t9.Text.ToUpper() == "A") && (t10.Text.ToUpper() == "T") && 
                (t11.Text.ToUpper() == "N"))
                { 
                MessageBox.Show("🎉 ¡ENHORABUENA! 🎉\n\nHas conseguido descubrir el misterio... 🏆🕵️‍♂️", "✨ ¡Victoria! ✨", MessageBoxButtons.OK, MessageBoxIcon.Information); 


                }
            else
            {
                // Esto se ejecuta SOLO si alguna letra está mal
                MessageBox.Show("Has fallado. ¡Inténtalo de nuevo!", "Intento Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // 3. SI ADEMÁS ya llegó al límite de 4, avisamos del fin del juego y bloqueamos el botón
                if (intentos >= 4)
                {
                    MessageBox.Show("Has agotado tus 4 intentos. ¡Juego terminado!", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    botonCheck.Enabled = false; // Desactiva el botón para que no puedan seguir intentando
                }
            }

        }

        private void t9_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("¿Desea salir?","Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) ==
                System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
