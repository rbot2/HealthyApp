using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthy_App
{
    public partial class Healthy_App_IMCCalculator : Form
    {
        public Healthy_App_IMCCalculator()
        {
            InitializeComponent();
        }
     
        private void CalculateIMC_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener peso y altura desde las cajas de texto
                double peso = Convert.ToDouble(textpeso.Text);
                double altura = Convert.ToDouble(textaltura.Text);

                // Calcular IMC
                double imc = peso / (altura * altura);

                // Mostrar el resultado en un MessageBox o en otra parte del formulario
                MessageBox.Show($"Tu IMC es: {imc:F2}", "Resultado del IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("La altura no puede ser cero. Por favor, ingresa un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}


