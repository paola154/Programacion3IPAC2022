using System;
using System.Windows.Forms;

namespace BilkisPerdomo
{
    public partial class Formulario1 : Form
    {
        // variable globales 
        float saldoInicial = 300000;
        double Interes;
        
        public Formulario1()
        {
            InitializeComponent();
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {
            // agrego el valor de 300,000 al control para que se muestre como lectura. No permita modificar 
            SaldoInicialtextBox.Text = saldoInicial.ToString("N"); 
        }


        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            // Hace llamado a la funcion calculo de interes 
            Calculo_Intereses(Interes);
           
        }


        // Funcio que calcula los intereses de cada mes. 
        private void Calculo_Intereses(double interes)
        {
            string[] Mes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };


            for (int i = 0; i < 12; i++)
            {
                interes = saldoInicial * 0.025 * (i+1);
                // Muetsra los datos en el listBox
                MostrarValoreslistBox.Items.Add("En el mes: " + Mes[i] + " Gana un total de: " + interes.ToString("N"));

            }
            
        }
    }
}
