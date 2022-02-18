using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion3IPAC2022
{
    public partial class FuncionesAsincronas : Form
    {
        public FuncionesAsincronas()
        {
            InitializeComponent();
        }

        private async void Hornearbutton_Click(object sender, EventArgs e)
        {
            // Horneapizza();
            await HornearPizzaAsync();
            label1.Text = "La pizza está lista";
        }

        private void Horneapizza()
        {
            Thread.Sleep(10000);
        }

        private Task HornearPizzaAsync()
        {
            return Task.Delay(10000);
        }

        private void otrasTareasbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realizando otras tareas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void Sumarbutton_Click(object sender, EventArgs e)
        {
            decimal valor1 = Convert.ToDecimal(textBox1.Text);
            decimal valor2 = Convert.ToDecimal(textBox2.Text);

            MessageBox.Show("La suma es: "+ await SumarAsync(valor1,valor2));
        }

        private decimal Sumar(decimal valor1, decimal valor2)
        {
            return valor1 + valor2;
        }

        private async Task<decimal> SumarAsync(decimal valor1, decimal valor2)
        {
            var resultado = await Task.Run(() =>
            {
                return valor1 + valor2;
            });
            return resultado;

            
        }
    }
}
