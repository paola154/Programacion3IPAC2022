using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            DateTime fecha = FechadateTimePicker.Value;
            DateTime Ingreso = AñodateTimePicker.Value;  

            int ventas = Convert.ToInt32(VentastextBox.Text);
            int sueldo = Convert.ToInt32(SueldotextBox.Text);

            EdadtextBox.Text = DevolverEdad(fecha).ToString();
            AñosLabtextBox.Text = Devolveraños(Ingreso).ToString();

            int edad = Convert.ToInt32(EdadtextBox.Text);
            int AñosLab = Convert.ToInt32(AñosLabtextBox.Text);

            
            if ((ventas > 10000) && (edad > 30) && (AñosLab > 10))
            {
                int salarioNuevo = Convert.ToInt32(sueldo + (sueldo * 0.05));
                salariotextBox.Text = salarioNuevo.ToString();
                
            }
            else
            {
                MessageBox.Show("Sus datos no aplican para un aumento de sueldo");
            }

           

        }

        private int DevolverEdad(DateTime _fechaNacimiento)
        {
            DateTime fechaNacimiento = _fechaNacimiento;
            DateTime fechaActual = DateTime.Now;

            int edad = 0;

            if (fechaNacimiento > fechaActual)
            {
                MessageBox.Show("La fecha de nacimiento es mayor a la fecha actual");
                return 0;
            }
            {
                edad = fechaActual.Year - fechaNacimiento.Year;
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }
            }

            return edad;
        }

        private int Devolveraños(DateTime _fechaIngreso)
        {
            DateTime fechaIngreso = _fechaIngreso;
            DateTime fechaActual = DateTime.Now;

            int años = 0;

            if (fechaIngreso > fechaActual)
            {
                MessageBox.Show("La fecha de ingreso es mayor a la fecha actual");
                return 0;
            }
            {
                años = fechaActual.Year - fechaIngreso.Year;
                if (fechaIngreso.Month > fechaActual.Month)
                {
                    --años;
                }
            }

            return años;
        }
    }
}
