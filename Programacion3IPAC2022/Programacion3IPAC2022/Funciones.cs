using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion3IPAC2022
{
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
        }

        private void Sumarbutton_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Numero1textBox.Text);
            int num2 = Convert.ToInt32(Numero2textBox.Text);

            

            ResultadotextBox.Text = sumar(num1, num2).ToString();
           

        }

        private int sumar(int num1, int num2)
        {
            int resultado= num1 + num2;

            return resultado;
        }

        private void Mostrarmensaje()
        {
            MessageBox.Show("Este es un mensaje");
        }

        private void MostrarMensajebutton_Click(object sender, EventArgs e)
        {
            Mostrarmensaje();
        }
    }
}
