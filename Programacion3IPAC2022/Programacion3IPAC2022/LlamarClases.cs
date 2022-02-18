using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesLibreria;

namespace Programacion3IPAC2022
{
    public partial class LlamarClases : Form
    {
        public LlamarClases()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coche coche = new Coche(10, "Toyota");  // instanciando un objeto de la clase coche 

            coche.Modelo = "22R";
            coche.Precio = 100000.00M;
            coche.Km = 150000;

            MessageBox.Show(coche.DevolverDatosCoche());
        }
    }
}
