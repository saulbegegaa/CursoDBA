
namespace AlquilerVehiculos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpTipoVehiculo = new System.Windows.Forms.GroupBox();
            this.rbAutobus = new System.Windows.Forms.RadioButton();
            this.rbTractor = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtKmRenta = new System.Windows.Forms.TextBox();
            this.txtKmDevolver = new System.Windows.Forms.TextBox();
            this.lblPlacas = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblKmRenta = new System.Windows.Forms.Label();
            this.lblKmDevolver = new System.Windows.Forms.Label();
            this.lblFechaRenta = new System.Windows.Forms.Label();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.dtpRenta = new System.Windows.Forms.DateTimePicker();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.btnRentar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpTipoVehiculo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTipoVehiculo
            // 
            this.grpTipoVehiculo.Controls.Add(this.panel1);
            this.grpTipoVehiculo.Controls.Add(this.radioButton1);
            this.grpTipoVehiculo.Controls.Add(this.rbAutobus);
            this.grpTipoVehiculo.Controls.Add(this.rbTractor);
            this.grpTipoVehiculo.Location = new System.Drawing.Point(66, 48);
            this.grpTipoVehiculo.Name = "grpTipoVehiculo";
            this.grpTipoVehiculo.Size = new System.Drawing.Size(200, 100);
            this.grpTipoVehiculo.TabIndex = 0;
            this.grpTipoVehiculo.TabStop = false;
            this.grpTipoVehiculo.Text = "Tipo de vehículo";
            // 
            // rbAutobus
            // 
            this.rbAutobus.AutoSize = true;
            this.rbAutobus.Location = new System.Drawing.Point(6, 30);
            this.rbAutobus.Name = "rbAutobus";
            this.rbAutobus.Size = new System.Drawing.Size(64, 17);
            this.rbAutobus.TabIndex = 1;
            this.rbAutobus.TabStop = true;
            this.rbAutobus.Text = "Autobus";
            this.rbAutobus.UseVisualStyleBackColor = true;
            this.rbAutobus.CheckedChanged += new System.EventHandler(this.rbAutobus_CheckedChanged);
            // 
            // rbTractor
            // 
            this.rbTractor.AutoSize = true;
            this.rbTractor.Location = new System.Drawing.Point(6, 66);
            this.rbTractor.Name = "rbTractor";
            this.rbTractor.Size = new System.Drawing.Size(59, 17);
            this.rbTractor.TabIndex = 2;
            this.rbTractor.TabStop = true;
            this.rbTractor.Text = "Tractor";
            this.rbTractor.UseVisualStyleBackColor = true;
            this.rbTractor.CheckedChanged += new System.EventHandler(this.rbTractor_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDevolucion);
            this.groupBox1.Controls.Add(this.dtpRenta);
            this.groupBox1.Controls.Add(this.lblFechaDevolucion);
            this.groupBox1.Controls.Add(this.txtKmDevolver);
            this.groupBox1.Controls.Add(this.lblFechaRenta);
            this.groupBox1.Controls.Add(this.lblKmDevolver);
            this.groupBox1.Controls.Add(this.txtKmRenta);
            this.groupBox1.Controls.Add(this.lblKmRenta);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.txtPlacas);
            this.groupBox1.Controls.Add(this.lblPlacas);
            this.groupBox1.Location = new System.Drawing.Point(28, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 170);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del vehículo";
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(128, 32);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(100, 20);
            this.txtPlacas.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(128, 58);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 1;
            // 
            // txtKmRenta
            // 
            this.txtKmRenta.Location = new System.Drawing.Point(128, 84);
            this.txtKmRenta.Name = "txtKmRenta";
            this.txtKmRenta.Size = new System.Drawing.Size(100, 20);
            this.txtKmRenta.TabIndex = 2;
            // 
            // txtKmDevolver
            // 
            this.txtKmDevolver.Location = new System.Drawing.Point(128, 110);
            this.txtKmDevolver.Name = "txtKmDevolver";
            this.txtKmDevolver.Size = new System.Drawing.Size(100, 20);
            this.txtKmDevolver.TabIndex = 3;
            // 
            // lblPlacas
            // 
            this.lblPlacas.AutoSize = true;
            this.lblPlacas.Location = new System.Drawing.Point(35, 35);
            this.lblPlacas.Name = "lblPlacas";
            this.lblPlacas.Size = new System.Drawing.Size(39, 13);
            this.lblPlacas.TabIndex = 4;
            this.lblPlacas.Text = "Placas";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(35, 61);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(69, 13);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio Renta";
            // 
            // lblKmRenta
            // 
            this.lblKmRenta.AutoSize = true;
            this.lblKmRenta.Location = new System.Drawing.Point(35, 87);
            this.lblKmRenta.Name = "lblKmRenta";
            this.lblKmRenta.Size = new System.Drawing.Size(68, 13);
            this.lblKmRenta.TabIndex = 6;
            this.lblKmRenta.Text = "Kms al rentar";
            // 
            // lblKmDevolver
            // 
            this.lblKmDevolver.AutoSize = true;
            this.lblKmDevolver.Location = new System.Drawing.Point(35, 113);
            this.lblKmDevolver.Name = "lblKmDevolver";
            this.lblKmDevolver.Size = new System.Drawing.Size(82, 13);
            this.lblKmDevolver.TabIndex = 7;
            this.lblKmDevolver.Text = "Kms al devolver";
            // 
            // lblFechaRenta
            // 
            this.lblFechaRenta.AutoSize = true;
            this.lblFechaRenta.Location = new System.Drawing.Point(352, 32);
            this.lblFechaRenta.Name = "lblFechaRenta";
            this.lblFechaRenta.Size = new System.Drawing.Size(79, 13);
            this.lblFechaRenta.TabIndex = 8;
            this.lblFechaRenta.Text = "Fecha de renta";
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(352, 91);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(107, 13);
            this.lblFechaDevolucion.TabIndex = 9;
            this.lblFechaDevolucion.Text = "Fecha de devolución";
            // 
            // dtpRenta
            // 
            this.dtpRenta.Location = new System.Drawing.Point(355, 54);
            this.dtpRenta.Name = "dtpRenta";
            this.dtpRenta.Size = new System.Drawing.Size(200, 20);
            this.dtpRenta.TabIndex = 10;
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.Location = new System.Drawing.Point(355, 110);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(200, 20);
            this.dtpDevolucion.TabIndex = 11;
            // 
            // btnRentar
            // 
            this.btnRentar.Location = new System.Drawing.Point(388, 59);
            this.btnRentar.Name = "btnRentar";
            this.btnRentar.Size = new System.Drawing.Size(75, 23);
            this.btnRentar.TabIndex = 12;
            this.btnRentar.Text = "Rentar";
            this.btnRentar.UseVisualStyleBackColor = true;
            this.btnRentar.Click += new System.EventHandler(this.btnRentar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(388, 125);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(90, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(90, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 43);
            this.panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRentar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpTipoVehiculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpTipoVehiculo.ResumeLayout(false);
            this.grpTipoVehiculo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTipoVehiculo;
        private System.Windows.Forms.RadioButton rbAutobus;
        private System.Windows.Forms.RadioButton rbTractor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.DateTimePicker dtpRenta;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.TextBox txtKmDevolver;
        private System.Windows.Forms.Label lblFechaRenta;
        private System.Windows.Forms.Label lblKmDevolver;
        private System.Windows.Forms.TextBox txtKmRenta;
        private System.Windows.Forms.Label lblKmRenta;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.Label lblPlacas;
        private System.Windows.Forms.Button btnRentar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

