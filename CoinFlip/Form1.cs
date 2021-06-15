using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlip
{
    public partial class Form1 : Form
    {

        Coin[] coins = new Coin[5];



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //display the labels
            Random r = new Random();
            label1.Text = "";
            for (int i = 0; i < coins.Length; i++)
            {
                label1.Text += coins[i].isHeads + ",";
                coins[i].flipCoin(r);
            }


            //set the pictures
            pictureBox1.Image = coins[0].isHeads ? Properties.Resources.black_wall : Properties.Resources.Snimak_ekrana_2021_04_18_180608;

            pictureBox2.Image = coins[1].isHeads ? Properties.Resources.black_wall : Properties.Resources.Snimak_ekrana_2021_04_18_180608;

            pictureBox3.Image = coins[2].isHeads ? Properties.Resources.black_wall : Properties.Resources.Snimak_ekrana_2021_04_18_180608;

            pictureBox4.Image = coins[3].isHeads ? Properties.Resources.black_wall : Properties.Resources.Snimak_ekrana_2021_04_18_180608;

            pictureBox5.Image = coins[4].isHeads ? Properties.Resources.black_wall : Properties.Resources.Snimak_ekrana_2021_04_18_180608;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < coins.Length; i++)
            {
                coins[i] = new Coin(false);
            }
            


        }
    }
}
