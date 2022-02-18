using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {   
            // Variable numero
            int num = Convert.ToInt32(numerotextBox.Text);

            // Llamado a la función que calcula si el numero ingresado es par o impar
            calcularParImpar(num);

            // Condicional donde hace el llamado a la función que calcula si el numero es primo.
            if (calcularPrimo(num))
            {
                MessageBox.Show("Es un número primo");
            }
            else
            {
                MessageBox.Show("No es un número primo");
            }
        }

        // Función que calcula si el numero es par o impar
        private int calcularParImpar(int num)
        {
            if ((num % 2) == 0)
            {
                MessageBox.Show("Es un número Par");
            }
            else
            {
                MessageBox.Show("Es un número Impar");
            }
            return num;
        }

        // Función que calcula si el numero es primo usando un FOR 
        private bool calcularPrimo(int num)
        {
            for(int i=2;i<num;i++)
            {
                if ((num%i)==0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
