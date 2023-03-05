using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int contadorColectivos = 0;
        private int contadorTaxis = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            btBorrar.Enabled = false;
           
        }
       
        public void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("desea salir?"
                 , "SALIR"
                 , MessageBoxButtons.YesNo
                 , MessageBoxIcon.Question
                 , MessageBoxDefaultButton.Button2)
                 == DialogResult.Yes)
                Close();
        }

      

        private void button1_Click(object sender, EventArgs e)

        {
            if (numericUpDown1.Value > 0)
            {
                if (contadorColectivos < 5)
            {
                contadorColectivos++;
                listBox1.Items.Add(new Vehiculo { Nombre = $"Colectivo {listBox1.Items.Count + 1}", NumPasajeros = (int)numericUpDown1.Value, Tipo = "Colectivo" });

            }
            else
            {
                MessageBox.Show("solo puede agregar hasta 5 colectivos");
            }
                this.Focus();
                checkBox2.Checked = false;
                checkBondi.Checked = false;
                numericUpDown1.Value = 1;
            }
            else
            {
                MessageBox.Show("debe cargar al menos 1 pasajero");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value > 0) { 
            if (contadorTaxis < 5)
            {
                contadorTaxis++;
                int numPasajeros = (int)numericUpDown1.Value;
                listBox1.Items.Add(new Vehiculo { Nombre = $"Taxi {listBox1.Items.Count + 1}", NumPasajeros = (int)numericUpDown1.Value, Tipo = "Taxi" });
            }
            else
            {
                MessageBox.Show("solo puede agregar hasta 5 taxis");
            }
            this.Focus();
            checkBox2.Checked = false;
            checkBondi.Checked = false;
            numericUpDown1.Value = 1;
            }
            else
            {
                MessageBox.Show("debe cargar al menos 1 pasajero");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Vehiculo vehiculo = (Vehiculo)listBox1.SelectedItem;

                if (vehiculo.Tipo == "Colectivo")
                {
                    contadorColectivos--;
                }
                else if (vehiculo.Tipo == "Taxi")
                {
                    contadorTaxis--;
                }

                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btBorrar.Enabled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (checkBondi.Checked == true && checkBox2.Checked == false)
            {
                numericUpDown1.Maximum = 60;
                numericUpDown1.Minimum = 1;
            }
            else if (checkBondi.Checked == false && checkBox2.Checked == true) 
            {
                numericUpDown1.Maximum = 4;
                numericUpDown1.Minimum = 1;
            }
        }
    }
}
