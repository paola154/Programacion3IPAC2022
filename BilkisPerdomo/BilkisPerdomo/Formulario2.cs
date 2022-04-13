using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilkisPerdomo
{
    public partial class Formulario2 : Form
    {
        public Formulario2()
        {
            InitializeComponent();
        }

        private async void Calcularbutton_Click(object sender, EventArgs e)
        {

            // Variables a utilizar 
            double descuento;
            double venta;
            double TotalPagar;

            // Los datos que ingresará el usuario 
            double cantidad = Convert.ToDouble(CantidadtextBox.Text);
            double precio = Convert.ToDouble(PreciotextBox.Text);

            // El calculo de la venta del producto, obtenemos el subtotal
            venta = cantidad * precio;
            SubtotaltextBox.Text = venta.ToString("N");

            // Aplicamos el descuento del 15% 
            descuento = await descuentoAsync(venta);
            DescuentotextBox.Text = descuento.ToString("N");

            // El total a pagar por el cliente sera el subtotal menos el descuento.
            TotalPagar = venta - descuento;
            TotalPagartextBox.Text = TotalPagar.ToString("N");
            
        }

        // Funcion asincrona del calculo del descuento 
        private async Task<double> descuentoAsync(double venta)
        {
            var resultado = await Task.Run(() =>
            {
                return venta * 0.15;
            });
            return resultado;
        }

    }
}
