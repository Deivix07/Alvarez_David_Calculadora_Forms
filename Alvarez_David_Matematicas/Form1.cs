using System;
using System.Windows.Forms;

namespace Alvarez_David_Matematicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Método que se llama al hacer clic en un botón de operación (suma, resta, etc.)
        private void btnOperacion_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0;

            // Validar que los cuadros de texto no estén vacíos antes de intentar convertirlos
            if (double.TryParse(txtNum1.Text, out num1) && double.TryParse(txtNum2.Text, out num2))
            {
                double resultado = 0;

                Button btn = sender as Button;
                string operacion = btn.Text;

                switch (operacion)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            resultado = num1 / num2;
                        else
                            MessageBox.Show("No se puede dividir entre cero.");
                        break;
                    case "%":
                        resultado = num1 % num2;
                        break;
                }

                lblResultado.Text = "Resultado: " + resultado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos en ambos campos.");
            }
        }
    }
}