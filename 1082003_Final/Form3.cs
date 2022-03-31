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
    public partial class Form3 : Form
    {
        public bool UseTransparency
        {
            set { cbxUseTransparency.Checked = value; }
            get { return cbxUseTransparency.Checked; }
        }

        public bool TextTransparency
        {
            set { rbtTextTransparency.Checked = value; }
            get { return rbtTextTransparency.Checked; }
        }

        public bool BackTransparency
        {
            set { rbtBackTransparency.Checked = value; }
            get { return rbtBackTransparency.Checked; }
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            gbxTransparency.Enabled = cbxUseTransparency.Checked;
        }

        private void cbxUseTransparency_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxUseTransparency_Click(object sender, EventArgs e)
        {
            gbxTransparency.Enabled = cbxUseTransparency.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
