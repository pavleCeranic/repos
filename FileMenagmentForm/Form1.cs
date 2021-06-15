using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMenagmentForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_addToList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Name: " + txt_firstName.Text + ", Last Name: " + txt_lastName.Text + ", Email: " + txt_email.Text);
        }

        private void btn_loadFile_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\pavle\OneDrive\Desktop\test.txt";

            //string[] lines = File.ReadAllLines(filePath);

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            foreach(string line in lines)
            {
                listBox1.Items.Add(line);
            }
        }

        private void btn_saveFile_Click(object sender, EventArgs e)
        {
            string filePath = listBox1.Text;

            //string[] lines = File.ReadAllLines(filePath);

            List<string> lines = new List<string>();
            List<Person> people = new List<Person>();

            lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Person p = new Person(items[0], items[1], items[2]);
                people.Add(p);
            }
            List<string> outContents = new List<string>();
            foreach (Person p in people)
            {
                string outFile = @"C:\Users\pavle\OneDrive\Desktop\outFile.txt";
                File.WriteAllLines(outFile, outContents);
                outContents.Add(p.ToString());
            }

            

        }
    }
}
