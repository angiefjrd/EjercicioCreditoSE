namespace EjercicioCreditoSE
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbIngresos = new System.Windows.Forms.Label();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.grpEmpleo = new System.Windows.Forms.GroupBox();
            this.rbPermanente = new System.Windows.Forms.RadioButton();
            this.rbTemporal = new System.Windows.Forms.RadioButton();
            this.grpHistorial = new System.Windows.Forms.GroupBox();
            this.rbSinAtrasos = new System.Windows.Forms.RadioButton();
            this.rbConAtrasos = new System.Windows.Forms.RadioButton();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.grpEmpleo.SuspendLayout();
            this.grpHistorial.SuspendLayout();
            this.grpResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(181, 28);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(134, 13);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Sistema Experto de Credito";
            this.lbTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbIngresos
            // 
            this.lbIngresos.AutoSize = true;
            this.lbIngresos.Location = new System.Drawing.Point(25, 65);
            this.lbIngresos.Name = "lbIngresos";
            this.lbIngresos.Size = new System.Drawing.Size(122, 13);
            this.lbIngresos.TabIndex = 1;
            this.lbIngresos.Text = "Ingresos Meensuales (L)";
            // 
            // txtIngresos
            // 
            this.txtIngresos.Location = new System.Drawing.Point(170, 65);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(100, 20);
            this.txtIngresos.TabIndex = 2;
            // 
            // grpEmpleo
            // 
            this.grpEmpleo.Controls.Add(this.rbTemporal);
            this.grpEmpleo.Controls.Add(this.rbPermanente);
            this.grpEmpleo.Location = new System.Drawing.Point(28, 104);
            this.grpEmpleo.Name = "grpEmpleo";
            this.grpEmpleo.Size = new System.Drawing.Size(200, 100);
            this.grpEmpleo.TabIndex = 3;
            this.grpEmpleo.TabStop = false;
            this.grpEmpleo.Text = "Tipo de Empleo";
            // 
            // rbPermanente
            // 
            this.rbPermanente.AutoSize = true;
            this.rbPermanente.Location = new System.Drawing.Point(16, 32);
            this.rbPermanente.Name = "rbPermanente";
            this.rbPermanente.Size = new System.Drawing.Size(82, 17);
            this.rbPermanente.TabIndex = 0;
            this.rbPermanente.TabStop = true;
            this.rbPermanente.Text = "Permanente";
            this.rbPermanente.UseVisualStyleBackColor = true;
            // 
            // rbTemporal
            // 
            this.rbTemporal.AutoSize = true;
            this.rbTemporal.Location = new System.Drawing.Point(16, 69);
            this.rbTemporal.Name = "rbTemporal";
            this.rbTemporal.Size = new System.Drawing.Size(69, 17);
            this.rbTemporal.TabIndex = 1;
            this.rbTemporal.TabStop = true;
            this.rbTemporal.Text = "Temporal";
            this.rbTemporal.UseVisualStyleBackColor = true;
            // 
            // grpHistorial
            // 
            this.grpHistorial.Controls.Add(this.rbConAtrasos);
            this.grpHistorial.Controls.Add(this.rbSinAtrasos);
            this.grpHistorial.Location = new System.Drawing.Point(270, 104);
            this.grpHistorial.Name = "grpHistorial";
            this.grpHistorial.Size = new System.Drawing.Size(200, 100);
            this.grpHistorial.TabIndex = 4;
            this.grpHistorial.TabStop = false;
            this.grpHistorial.Text = "Historial Crediticio";
            // 
            // rbSinAtrasos
            // 
            this.rbSinAtrasos.AutoSize = true;
            this.rbSinAtrasos.Location = new System.Drawing.Point(20, 32);
            this.rbSinAtrasos.Name = "rbSinAtrasos";
            this.rbSinAtrasos.Size = new System.Drawing.Size(77, 17);
            this.rbSinAtrasos.TabIndex = 1;
            this.rbSinAtrasos.TabStop = true;
            this.rbSinAtrasos.Text = "Sin atrasos";
            this.rbSinAtrasos.UseVisualStyleBackColor = true;
            this.rbSinAtrasos.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbConAtrasos
            // 
            this.rbConAtrasos.AutoSize = true;
            this.rbConAtrasos.Location = new System.Drawing.Point(20, 69);
            this.rbConAtrasos.Name = "rbConAtrasos";
            this.rbConAtrasos.Size = new System.Drawing.Size(116, 17);
            this.rbConAtrasos.TabIndex = 2;
            this.rbConAtrasos.TabStop = true;
            this.rbConAtrasos.Text = "Atrasos Frecuentes";
            this.rbConAtrasos.UseVisualStyleBackColor = true;
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(51, 265);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(141, 23);
            this.btnAnalizar.TabIndex = 5;
            this.btnAnalizar.Text = "Aalizar Solicitud";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(210, 265);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grpResultado
            // 
            this.grpResultado.Controls.Add(this.lblPlazo);
            this.grpResultado.Controls.Add(this.lblCredito);
            this.grpResultado.Controls.Add(this.lblCliente);
            this.grpResultado.Controls.Add(this.lblHistorial);
            this.grpResultado.Controls.Add(this.lblCapacidad);
            this.grpResultado.Location = new System.Drawing.Point(67, 318);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(248, 152);
            this.grpResultado.TabIndex = 7;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "resultado del Analisis";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(7, 20);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(101, 13);
            this.lblCapacidad.TabIndex = 0;
            this.lblCapacidad.Text = "Capacidad de Pago";
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(7, 47);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(90, 13);
            this.lblHistorial.TabIndex = 1;
            this.lblHistorial.Text = "Historial Crediticio";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(7, 73);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(78, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Tipo de Cliente";
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(7, 98);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(108, 13);
            this.lblCredito.TabIndex = 3;
            this.lblCredito.Text = "Credito recomendado";
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Location = new System.Drawing.Point(6, 123);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(103, 13);
            this.lblPlazo.TabIndex = 4;
            this.lblPlazo.Text = "Plazo recomemdado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 498);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.grpHistorial);
            this.Controls.Add(this.grpEmpleo);
            this.Controls.Add(this.txtIngresos);
            this.Controls.Add(this.lbIngresos);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema experto de Credito";
            this.grpEmpleo.ResumeLayout(false);
            this.grpEmpleo.PerformLayout();
            this.grpHistorial.ResumeLayout(false);
            this.grpHistorial.PerformLayout();
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbIngresos;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.GroupBox grpEmpleo;
        private System.Windows.Forms.RadioButton rbTemporal;
        private System.Windows.Forms.RadioButton rbPermanente;
        private System.Windows.Forms.GroupBox grpHistorial;
        private System.Windows.Forms.RadioButton rbSinAtrasos;
        private System.Windows.Forms.RadioButton rbConAtrasos;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Label lblCapacidad;
    }
}

