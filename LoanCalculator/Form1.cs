using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculator
{
    public partial class Form1 : Form
    {

        decimal starting_balance = 0.00m;
        int number_of_months = 0;
        decimal interest_rate = 0.005m; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //assign new values to the variables
            if (decimal.TryParse(txt_startingBalance.Text, out starting_balance))
            {
                if (int.TryParse(txt_numberOfMonths.Text, out number_of_months))
                {
                    if (decimal.TryParse(txt_interestRate.Text, out interest_rate))
                    {
                        //success

                        //calculate the loan

                        int counter = 0;
                        while (counter < number_of_months)
                        {
                            starting_balance = starting_balance + starting_balance * interest_rate;
                            listBox1.Items.Add("At Month " + counter + " the loan is " + starting_balance.ToString("c"));
                            counter = counter + 1;
                        }

                        //done with the while loop
                        txt_endingBalance.Text = starting_balance.ToString("c");
                    }
                }
            }           
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_endingBalance.Text = "";
            txt_interestRate.Text = "";
            txt_startingBalance.Text = "";
            txt_numberOfMonths.Text = "";
            listBox1.Items.Clear();
        }
    }
}
