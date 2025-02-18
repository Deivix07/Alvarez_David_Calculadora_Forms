using System;
using System.Windows.Forms;

namespace Alvarez_David_Matematicas
{
    static class Program
    {
        [STAThread]  // Es necesario para aplicaciones de Windows Forms
        static void Main()
        {
            Application.EnableVisualStyles();  // Habilita los estilos visuales de Windows.
            Application.SetCompatibleTextRenderingDefault(false);  // Define si usar GDI+ o WinForms.
            Application.Run(new Form1());  // Inicia el formulario principal (Form1).
        }
    }
}