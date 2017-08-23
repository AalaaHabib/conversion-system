using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converting_numbers
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

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            lbbinary.Text = Convert.ToString(num, 2);
            lbdecimal.Text = num.ToString();
            lbhexa.Text = Convert.ToString(num, 16);
            lboctal.Text = Convert.ToString(num, 8);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
