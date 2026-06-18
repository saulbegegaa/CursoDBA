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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea eliminar producto?",
                "Eliminación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        dgvLista.Rows.Remove(dgvLista.CurrentRow);
                    }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cod = cmbProducto.SelectedIndex;

            if (cod == 0)
            {
                lblCodigo.Text = "0011";
                lblNombre.Text = "Polo RALF LAUREN";
                lblPrecio.Text = "150";
            }

            if (cod == 1)
            {
                lblCodigo.Text = "0022";
                lblNombre.Text = "Gorra DOLCE GABANA";
                lblPrecio.Text = "120";
            }

            if (cod == 2)
            {
                lblCodigo.Text = "0033";
                lblNombre.Text = "Camisa Milano";
                lblPrecio.Text = "140";
            }
        }

        private void CalcularTotalFactura()
        {
            float sumaTotal = 0;

            foreach (DataGridViewRow fila in dgvLista.Rows)
            {
                if (fila.Cells[4].Value != null)
                {
                    float totalFila = 0;
                    if (float.TryParse(fila.Cells[4].Value.ToString(), out totalFila))
                    {
                        sumaTotal += totalFila;
                    }
                }
            }

            lblTotal.Text = sumaTotal.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow rejilla = new DataGridViewRow();
            rejilla.CreateCells(dgvLista);

            rejilla.Cells[0].Value = lblCodigo.Text;
            rejilla.Cells[1].Value = lblNombre.Text;
            rejilla.Cells[2].Value = lblPrecio.Text;
            rejilla.Cells[3].Value = txtCantidad.Text;
            rejilla.Cells[4].Value = (float.Parse(lblPrecio.Text) * (string.IsNullOrEmpty(txtCantidad.Text) ? 1f : float.Parse(txtCantidad.Text))).ToString();

            dgvLista.Rows.Add(rejilla);

            // Actualiza el total acumulado de la factura
            CalcularTotalFactura();

            lblCodigo.Text = lblNombre.Text = lblPrecio.Text = txtCantidad.Text = "";
        }
    }
    }

