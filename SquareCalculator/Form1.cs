using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                decimal i = decimal.Parse(txt_startAt.Text);
                decimal b = decimal.Parse(txt_endAt.Text);

                for (i = i; i < b; i++)
                {
                    listBox1.Items.Add(i * i + " is the squared value of " + i);
                }
            }
            catch
            {
                MessageBox.Show("Try only numbers!");
            }
            
            
        }
    }
}
