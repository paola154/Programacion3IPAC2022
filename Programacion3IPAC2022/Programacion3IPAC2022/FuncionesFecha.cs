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
    public partial class FuncionesFecha : Form
    {
        public FuncionesFecha()
        {
            InitializeComponent();
        }

        private void Procesarbutton_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker.Value;

            DiatextBox.Text = fecha.Day.ToString();

            MestextBox.Text = fecha.Month.ToString();

            añotextBox.Text = fecha.Year.ToString();

            DiaLetrastextBox.Text = fecha.ToString("dddd");

            MesLetrastextBox.Text = fecha.ToString("MMMM");

            SumadiastextBox.Text = fecha.AddDays(25).ToShortDateString();

            EdadtextBox.Text = DevolverEdad(fecha).ToString();

        }

        private int DevolverEdad(DateTime _FechaNacimiento)
        {
            DateTime fechaNacimiento = _FechaNacimiento;
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
    }
}
