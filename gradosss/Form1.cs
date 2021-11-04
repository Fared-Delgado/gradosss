using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gradosss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Celsius celsiusConv = new Celsius();
        Kelvin kelvinConv = new Kelvin();
        fahrenheit fahreConv = new fahrenheit();
        double celsius = 0;
        double kelvin = 0;
        double fahrenheit = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            textBox3.Clear();
            textBox4.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""  )
            {
                MessageBox.Show("Debe agregar una temperatura");
                textBox1.Focus();
               return;
            }

                if (textBox1.Text != "")
            {

                celsius = double.Parse(textBox1.Text);
                kelvin = kelvinConv.CelsiusKelvin(celsius);
                textBox2.Text = kelvin.ToString();
            }
            else
            {
                kelvin = double.Parse(textBox2.Text);
                celsius = celsiusConv.KelvinCelsius(kelvin);
                textBox1.Text = celsius.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Debe agregar una temperatura");
                textBox3.Focus();
                return;
            }
            if (textBox3.Text != "")
            {

                celsius = double.Parse(textBox3.Text);
                fahrenheit = fahreConv.CelsiusFahre(celsius);
                textBox4.Text = fahrenheit.ToString();
            }
            else
            {

                fahrenheit = double.Parse(textBox4.Text);
                celsius = celsiusConv.FahrenCelsius(fahrenheit);
                textBox3.Text = celsius.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Debe agregar una temperatura");
                textBox5.Focus();
                return;
            }
            if (textBox5.Text != "")
            {

                fahrenheit = double.Parse(textBox5.Text);
                kelvin = kelvinConv.FahrenKelvin(fahrenheit);
                textBox6.Text = kelvin.ToString();
            }
            else
            {

                kelvin = double.Parse(textBox6.Text);
                fahrenheit = fahreConv.KelvinFahre(kelvin);
                textBox5.Text = fahrenheit.ToString();
            }
             
                }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
        }
 