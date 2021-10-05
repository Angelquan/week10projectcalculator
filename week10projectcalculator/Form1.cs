using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week10projectcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtNum2.Text);


            double addtotal = (num1 + num2);

            lblTotal.Text = Convert.ToString(addtotal);

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtNum2.Text);


            double addtotal = (num1 - num2);

            lblTotal.Text = Convert.ToString(addtotal);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtNum2.Text);


            double addtotal = (num1*num2);

            lblTotal.Text = Convert.ToString(addtotal);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtNum2.Text);


            double addtotal = (num1/num2);

            lblTotal.Text = Convert.ToString(addtotal);
        }
    }
}
