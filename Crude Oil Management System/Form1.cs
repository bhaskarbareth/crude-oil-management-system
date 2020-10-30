using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Crude_Oil_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname = "1", upass = "1", name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;
            label5.Hide();

            if (name.Equals(uname) && pass.Equals(upass))
            {
                //login
                label5.Hide();
                MessageBox.Show("Login Sucess");
            }
            else
            {
                label5.Show();
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}