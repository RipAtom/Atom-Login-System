using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atom___Official_Release_v1._1._4
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text2 = Pass1.Text;

            string value = User1.Text + ":" + text2;
            string value2 = User1.Text + ":" + text2;
            string PASS = Pass1.Text;

            if (User1.Text == "" && PASS == "")
            {
                MessageBox.Show("Please fill out your valid credentials in order to proceed.");
                this.Close();
            }
            if (PASS == "")
            {
                MessageBox.Show("Please input your desired password for this application.");
                this.Close();
            }

            if (User1.Text == "")
            {
                MessageBox.Show("Please input your desired usernamre for this application.");
                this.Close();
            }
            else
            {
            }

            WebClient webClient = new WebClient();

            bool flag3 = webClient.DownloadString("https://pastebin.com/raw/Fpm9MpRQ").Contains(value);
            if (flag3)
            {
                this.Hide();
                MessageBox.Show($"Thank you for using the Official Atom Services, developed by Atom#1337.");
                Form2 penis = new Form2();
                penis.ShowDialog();
                this.Close();
            }
            else
            {

                MessageBox.Show("You've entered invalid credentials, please enter validated information!");

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
