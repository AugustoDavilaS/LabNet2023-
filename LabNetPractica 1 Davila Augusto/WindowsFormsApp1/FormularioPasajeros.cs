using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormularioPasajeros : Form
    {
        public FormularioPasajeros(string Vehiculo)
        {
            InitializeComponent();
            label1.Text = $"¿Cuántos pasajeros desea cargar al {Vehiculo}?";
           
        }

        private void FormularioPasajeros_Load(object sender, EventArgs e)
        {
            if (label1.Text.Contains("Colectivo"))
            {
                numericUpDown1.Maximum = 60;
                numericUpDown1.Minimum = 1;
            }
            if (label1.Text.Contains("Taxi"))
            {
                numericUpDown1.Maximum = 4;
                numericUpDown1.Minimum = 1;
            }
        }
    }
}
