using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datatry
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
       
        public Form1()
        {
            InitializeComponent();
            instance = this;
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();

            Form2.instance.lab1.Text = textBox2.Text;
            Form2.instance.lab2.Text = textBox3.Text;
            Form2.instance.lab3.Text = textBox4.Text;
            Form2.instance.lab4.Text = textBox1.Text;

        }
    }
}
