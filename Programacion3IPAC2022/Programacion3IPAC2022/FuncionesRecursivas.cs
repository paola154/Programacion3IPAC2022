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
    public partial class FuncionesRecursivas : Form
    {
        public FuncionesRecursivas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecorrerDeUnoEnUno(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
        }

        private void RecorrerDeUnoEnUno(int valorInicial, int valorFinal)
        {
            listBox1.Items.Add(valorInicial);

            if (valorInicial < valorFinal)
            {
                RecorrerDeUnoEnUno(valorInicial+1,valorFinal);
            }
        }
    }
}
