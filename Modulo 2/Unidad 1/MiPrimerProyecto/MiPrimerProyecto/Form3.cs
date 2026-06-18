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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string Usuario, Contraseña; //Variables de texto
            Usuario = txtUsuario.Text.Trim();
            Contraseña = txtContraseña.Text.TrimEnd();
            if (Usuario == "ofimega" && Contraseña == "danone")
            { MessageBox.Show("Bienvenido al sistema"); }
            else
            { MessageBox.Show("Acceso denegado"); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) ==
                System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
}
}

