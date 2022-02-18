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
    public partial class FuncionesTexto : Form
    {
        public FuncionesTexto()
        {
            InitializeComponent();
        }

        private void Procesarbutton_Click(object sender, EventArgs e)
        {
            string cadena = CadenatextBox.Text;

            LongitudtextBox.Text = cadena.Length.ToString();

            PrimerCaractertextBox.Text = cadena.Substring(0, 1);

            UltimoCaractertextBox.Text = cadena.Substring(cadena.Length -1, 1);

            RangotextBox.Text = cadena.Substring(5, 10);

            MayusculatextBox.Text = cadena.ToUpper();

            MinusculatextBox.Text = cadena.ToLower();

            ReemplazartextBox.Text = cadena.Replace("a", "b");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
