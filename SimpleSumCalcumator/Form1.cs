using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSumCalcumator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int num1 = Convert.ToInt32(txtn1.Text);
           int num2 = Convert.ToInt32(txtn2.Text);
            txtn3.Text = (num1+num2).ToString();
        }
    }
}
