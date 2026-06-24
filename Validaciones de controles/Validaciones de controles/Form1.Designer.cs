
namespace Validaciones_de_controles
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
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblLugarSalida = new System.Windows.Forms.Label();
            this.lblLlegada = new System.Windows.Forms.Label();
            this.lblLugarLlegada = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.cmbLlegada = new System.Windows.Forms.ComboBox();
            this.cmbSalida = new System.Windows.Forms.ComboBox();
            this.dtpLlegada = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(39, 38);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Empresa";
            this.lblEmpresa.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(39, 76);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(82, 13);
            this.lblSalida.TabIndex = 1;
            this.lblSalida.Text = "Fecha de salida";
            // 
            // lblLugarSalida
            // 
            this.lblLugarSalida.AutoSize = true;
            this.lblLugarSalida.Location = new System.Drawing.Point(39, 115);
            this.lblLugarSalida.Name = "lblLugarSalida";
            this.lblLugarSalida.Size = new System.Drawing.Size(79, 13);
            this.lblLugarSalida.TabIndex = 2;
            this.lblLugarSalida.Text = "Lugar de salida";
            // 
            // lblLlegada
            // 
            this.lblLlegada.AutoSize = true;
            this.lblLlegada.Location = new System.Drawing.Point(493, 76);
            this.lblLlegada.Name = "lblLlegada";
            this.lblLlegada.Size = new System.Drawing.Size(89, 13);
            this.lblLlegada.TabIndex = 3;
            this.lblLlegada.Text = "Fecha de llegada";
            // 
            // lblLugarLlegada
            // 
            this.lblLugarLlegada.AutoSize = true;
            this.lblLugarLlegada.Location = new System.Drawing.Point(493, 115);
            this.lblLugarLlegada.Name = "lblLugarLlegada";
            this.lblLugarLlegada.Size = new System.Drawing.Size(86, 13);
            this.lblLugarLlegada.TabIndex = 4;
            this.lblLugarLlegada.Text = "Lugar de llegada";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(493, 153);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(493, 206);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(93, 13);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo electrónico";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Items.AddRange(new object[] {
            "Aspasia",
            "Asturelec",
            "Inadeco",
            "Trabanco"});
            this.cmbEmpresa.Location = new System.Drawing.Point(42, 54);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpresa.TabIndex = 7;
            // 
            // cmbLlegada
            // 
            this.cmbLlegada.FormattingEnabled = true;
            this.cmbLlegada.Items.AddRange(new object[] {
            "Londres",
            "París",
            "Roma"});
            this.cmbLlegada.Location = new System.Drawing.Point(496, 131);
            this.cmbLlegada.Name = "cmbLlegada";
            this.cmbLlegada.Size = new System.Drawing.Size(121, 21);
            this.cmbLlegada.TabIndex = 8;
            // 
            // cmbSalida
            // 
            this.cmbSalida.FormattingEnabled = true;
            this.cmbSalida.Items.AddRange(new object[] {
            "Londres",
            "París",
            "Roma"});
            this.cmbSalida.Location = new System.Drawing.Point(42, 131);
            this.cmbSalida.Name = "cmbSalida";
            this.cmbSalida.Size = new System.Drawing.Size(121, 21);
            this.cmbSalida.TabIndex = 9;
            // 
            // dtpLlegada
            // 
            this.dtpLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLlegada.Location = new System.Drawing.Point(496, 92);
            this.dtpLlegada.Name = "dtpLlegada";
            this.dtpLlegada.Size = new System.Drawing.Size(121, 20);
            this.dtpLlegada.TabIndex = 10;
            // 
            // dtpSalida
            // 
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalida.Location = new System.Drawing.Point(42, 92);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(121, 20);
            this.dtpSalida.TabIndex = 11;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(6, 28);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(73, 17);
            this.rb1.TabIndex = 12;
            this.rb1.TabStop = true;
            this.rb1.Text = "1 Persona";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb4);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Location = new System.Drawing.Point(42, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 134);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad de personas:";
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(6, 51);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(78, 17);
            this.rb2.TabIndex = 13;
            this.rb2.TabStop = true;
            this.rb2.Text = "2 Personas";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(6, 74);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(78, 17);
            this.rb3.TabIndex = 14;
            this.rb3.TabStop = true;
            this.rb3.Text = "3 Personas";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(6, 97);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(78, 17);
            this.rb4.TabIndex = 15;
            this.rb4.TabStop = true;
            this.rb4.Text = "4 Personas";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(496, 169);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(496, 222);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(250, 20);
            this.txtCorreo.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(42, 348);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(253, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(496, 348);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(266, 23);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.dtpLlegada);
            this.Controls.Add(this.cmbSalida);
            this.Controls.Add(this.cmbLlegada);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblLugarLlegada);
            this.Controls.Add(this.lblLlegada);
            this.Controls.Add(this.lblLugarSalida);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblEmpresa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblLugarSalida;
        private System.Windows.Forms.Label lblLlegada;
        private System.Windows.Forms.Label lblLugarLlegada;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.ComboBox cmbLlegada;
        private System.Windows.Forms.ComboBox cmbSalida;
        private System.Windows.Forms.DateTimePicker dtpLlegada;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}

