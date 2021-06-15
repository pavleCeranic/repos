using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_kelvin_Click(object sender, EventArgs e)
        {
            float k = 0;

            try
            {
                k = float.Parse(txt_kelvin.Text);
            }
            catch
            {
                MessageBox.Show("Try only numbers!");

            }
            

            float c = k - 273;
            float f = 9 / 5f * (k - 273) + 32;
            
            txt_celsius.Text = c.ToString() ;
            txt_farenheit.Text = f.ToString();
            



        }

        private void btn_celsius_Click(object sender, EventArgs e)
        {
            float c = 0;
            try
            {
                c = float.Parse(txt_celsius.Text);
            }
            catch
            {
                MessageBox.Show("Try only number!");
            }

            float k = c + 273;
            float f = c * 9/5f +32;

            txt_kelvin.Text = k.ToString();
            txt_farenheit.Text = f.ToString();
        }

        private void btn_farenheit_Click(object sender, EventArgs e)
        {
            float f = 0;
            try
            {
                f = float.Parse(txt_farenheit.Text);
            }
            catch
            {
                MessageBox.Show("Try only number!");
            }

            float c = 5 / 9f * (f - 32);
            float k = 5 / 9f * (f + 459);

            txt_kelvin.Text = k.ToString();
            txt_celsius.Text = c.ToString();
        }
    }
}
