using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1082003_Final
{
    public partial class Form2 : Form
    {
        public string sol_term_1, sol_term_2;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            double det;
            double sol_term1, sol_term2;
            bool IsComplex;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);

            det = b * b - 4 * a * c;
            if (det < 0)
            {
                IsComplex = true;
                det = -det;
            }
            else IsComplex = false;

            sol_term1 = -b / (2 * a);
            sol_term2 = Math.Sqrt(det) / (2 * a);

            if (IsComplex)
            {
                sol_term_1 = "解一：" + sol_term1.ToString() + "+" + sol_term2.ToString() + "i";
                sol_term_2 = "解二：" + sol_term1.ToString() + "-" + sol_term2.ToString() + "i";
            }
            else
            {
                sol_term_1 = "解一：" + (sol_term1 + sol_term2).ToString();
                sol_term_2 = "解二：" + (sol_term1 - sol_term2).ToString();
            }
            this.DialogResult = DialogResult.OK;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
