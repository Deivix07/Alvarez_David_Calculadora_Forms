namespace Alvarez_David_Matematicas
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Crea controles de la interfaz de usuario
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Label lblResultado;

        private System.Windows.Forms.Label lblnum1;

        // Limpia los recursos utilizados
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {   
            this.components = new System.ComponentModel.Container();
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Text = "Calculadora Básica";

            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum1.Location = new System.Drawing.Point(50, 10);
            this.lblnum1.Size = new System.Drawing.Size(300, 30);
            this.lblnum1.Text = "Ingresa el primer número";

            // Caja de texto para el primer número
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum1.Location = new System.Drawing.Point(50, 30);
            this.txtNum1.Size = new System.Drawing.Size(100, 20);

            // Caja de texto para el segundo número
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum2.Location = new System.Drawing.Point(200, 30);
            this.txtNum2.Size = new System.Drawing.Size(100, 20);

            // Botón para la suma
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnSuma.Text = "+";
            this.btnSuma.Location = new System.Drawing.Point(50, 70);
            this.btnSuma.Size = new System.Drawing.Size(40, 30);
            this.btnSuma.Click += new System.EventHandler(this.btnOperacion_Click);

            // Botón para la resta
            this.btnResta = new System.Windows.Forms.Button();
            this.btnResta.Text = "-";
            this.btnResta.Location = new System.Drawing.Point(100, 70);
            this.btnResta.Size = new System.Drawing.Size(40, 30);
            this.btnResta.Click += new System.EventHandler(this.btnOperacion_Click);

            // Botón para la multiplicación
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.Location = new System.Drawing.Point(150, 70);
            this.btnMultiplicacion.Size = new System.Drawing.Size(40, 30);
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnOperacion_Click);

            // Botón para la división
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnDivision.Text = "/";
            this.btnDivision.Location = new System.Drawing.Point(200, 70);
            this.btnDivision.Size = new System.Drawing.Size(40, 30);
            this.btnDivision.Click += new System.EventHandler(this.btnOperacion_Click);

            // Botón para el módulo
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnModulo.Text = "%";
            this.btnModulo.Location = new System.Drawing.Point(250, 70);
            this.btnModulo.Size = new System.Drawing.Size(40, 30);
            this.btnModulo.Click += new System.EventHandler(this.btnOperacion_Click);

            // Etiqueta para mostrar el resultado
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResultado.Location = new System.Drawing.Point(50, 120);
            this.lblResultado.Size = new System.Drawing.Size(300, 30);
            this.lblResultado.Text = "Resultado: ";

            // Agregar controles al formulario
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnModulo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblnum1);
        }
    }
}
