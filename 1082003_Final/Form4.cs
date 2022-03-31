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
    public partial class Form4 : Form
    {
        public string Sum1;
        public Form4()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int N;

            N = int.Parse(textBox1.Text);

            int Sum = 0;
            for (int i = 1; i <= N; i++)
            {
                Sum += i;
            }
            Sum1 = Sum.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
