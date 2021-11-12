namespace WindowsLiderEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTiempoTotal = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbestadocalculo = new System.Windows.Forms.ProgressBar();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblreg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 31);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTiempoTotal
            // 
            this.lblTiempoTotal.AutoSize = true;
            this.lblTiempoTotal.Location = new System.Drawing.Point(225, 36);
            this.lblTiempoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempoTotal.Name = "lblTiempoTotal";
            this.lblTiempoTotal.Size = new System.Drawing.Size(0, 17);
            this.lblTiempoTotal.TabIndex = 1;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(126, 36);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(91, 17);
            this.lblTiempo.TabIndex = 2;
            this.lblTiempo.Text = "Tiempo Total";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 229);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pbestadocalculo
            // 
            this.pbestadocalculo.Location = new System.Drawing.Point(16, 75);
            this.pbestadocalculo.Name = "pbestadocalculo";
            this.pbestadocalculo.Size = new System.Drawing.Size(622, 23);
            this.pbestadocalculo.TabIndex = 4;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(252, 37);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(96, 17);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "En Total son: ";
            // 
            // lblreg
            // 
            this.lblreg.AutoSize = true;
            this.lblreg.Location = new System.Drawing.Point(13, 101);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(108, 17);
            this.lblreg.TabIndex = 6;
            this.lblreg.Text = "Transaccion N: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 395);
            this.Controls.Add(this.lblreg);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.pbestadocalculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblTiempoTotal);
            this.Controls.Add(this.btnCalcular);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Prueba Lider";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTiempoTotal;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbestadocalculo;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblreg;
    }
}

