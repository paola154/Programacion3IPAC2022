using System;
using System.Windows.Forms;

namespace BilkisPerdomo
{
    public partial class Formulario3 : Form
    {
        public Formulario3()
        {
            InitializeComponent();
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            MostrarNumeros(1, 100);
        }

        // Muestra la lista del 1 - 100, hice uso de recursividad 
        private void MostrarNumeros(int N1,int N2)
        {
            listBox1.Items.Add(N1);

            if (N1 < N2)
            {
                MostrarNumeros(N1 + 1, N2);
            }
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            int Numero = Convert.ToInt32(NumerotextBox.Text);
            int multiplostres;
            int multiploscinco;
            int multiplos;

            if (Numero % 3 == 0)
            {
                multiplostres = multiplosTres(Numero);
                listBox2.Items.Add(" Mi nombre es Paola ");
            }
            else if (Numero % 5 == 0)
            {
                multiploscinco = multiplosCinco(Numero);
                listBox2.Items.Add(+Numero+ " Mi apellido es Perdomo ");
            }
            else 
            {
                multiplos = Multiplos(Numero);
                listBox2.Items.Add(+Numero+ " Mi Nombre es Paola Perdomo ");
            }
        }

        private int multiplosTres(int Numero)
        {
            int i = 0;
            listBox1.Items.Add("Multiplos de: " + Numero);
            for (i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    listBox2.Items.Add(i);
                }
            }
            listBox1.Items.Add("");
            return Numero;
        }

        private int multiplosCinco(int Numero)
        {
            int i = 0;
            listBox1.Items.Add("Multiplos de cinco");
            for (i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    listBox2.Items.Add(i);
                }
            }
            listBox1.Items.Add("");
            return Numero;
        }

        private int Multiplos(int Numero)
        {
            int i = 0;
            listBox1.Items.Add("Multiplos de: " + Numero);
            for (i = 1; i <= 100; i++)
            {
                if (Numero % 3 == 0 && Numero % 5 == 0)
                {
                    listBox2.Items.Add(i);
                }
            }
            listBox1.Items.Add("");
            return Numero;
        }

    }
}
