using System;

namespace Healthy_App
{
    partial class Healthy_App_IMCCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Peso = new System.Windows.Forms.Label();
            this.Altura = new System.Windows.Forms.Label();
            this.textpeso = new System.Windows.Forms.TextBox();
            this.textaltura = new System.Windows.Forms.TextBox();
            this.CalculateIMC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Peso
            // 
            this.Peso.AutoSize = true;
            this.Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peso.Location = new System.Drawing.Point(64, 610);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(189, 20);
            this.Peso.TabIndex = 0;
            this.Peso.Text = "Ingrese su peso en Kg";
            // 
            // Altura
            // 
            this.Altura.AutoSize = true;
            this.Altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Altura.Location = new System.Drawing.Point(408, 612);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(230, 20);
            this.Altura.TabIndex = 1;
            this.Altura.Text = "Ingrese su altura en metros";
            // 
            // textpeso
            // 
            this.textpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpeso.Location = new System.Drawing.Point(271, 609);
            this.textpeso.Name = "textpeso";
            this.textpeso.Size = new System.Drawing.Size(100, 26);
            this.textpeso.TabIndex = 2;
            // 
            // textaltura
            // 
            this.textaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textaltura.Location = new System.Drawing.Point(644, 610);
            this.textaltura.Name = "textaltura";
            this.textaltura.Size = new System.Drawing.Size(100, 26);
            this.textaltura.TabIndex = 3;
            // 
            // CalculateIMC
            // 
            this.CalculateIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateIMC.Location = new System.Drawing.Point(783, 598);
            this.CalculateIMC.Name = "CalculateIMC";
            this.CalculateIMC.Size = new System.Drawing.Size(151, 37);
            this.CalculateIMC.TabIndex = 4;
            this.CalculateIMC.Text = "Calcular IMC";
            this.CalculateIMC.UseVisualStyleBackColor = true;
            this.CalculateIMC.Click += new System.EventHandler(this.CalculateIMC_Click);
            // 
            // Healthy_App_IMCCalculator
            // 
            this.BackgroundImage = global::Healthy_App.Properties.Resources.IMC_chart;
            this.ClientSize = new System.Drawing.Size(988, 659);
            this.Controls.Add(this.CalculateIMC);
            this.Controls.Add(this.textaltura);
            this.Controls.Add(this.textpeso);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.Peso);
            this.Name = "Healthy_App_IMCCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button CalcularIMC;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label Peso;
        private System.Windows.Forms.Label Altura;
        private System.Windows.Forms.TextBox textpeso;
        private System.Windows.Forms.TextBox textaltura;
        private System.Windows.Forms.Button CalculateIMC;
    }
}