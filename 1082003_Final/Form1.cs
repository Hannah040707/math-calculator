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
    public partial class Form1 : Form
    {
        bool UseTransparency = false;
        bool TextTransparency = false;
        bool BackTransparency = true;
        string Filename;   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 一元二次方程式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string data = "一元二次方程式解：";
                string data1 = dlg.sol_term_1;
                string data2 = dlg.sol_term_2;
                lbxData.BeginUpdate();
                lbxData.Items.Add(data);
                lbxData.Items.Add(data1);
                lbxData.Items.Add(data2);
                lbxData.EndUpdate();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxData.Items.Clear();
        }

        private void MenuFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.Font = lbxData.Font;
            if (fontDlg.ShowDialog() == DialogResult.OK)
            {
                lbxData.Font = fontDlg.Font;
            }
        }

        private void MenuBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.FullOpen = true;
            colorDlg.Color = lbxData.BackColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                lbxData.BackColor = colorDlg.Color;
                if (this.UseTransparency && this.BackTransparency)
                    this.TransparencyKey = lbxData.BackColor; 
            }
        }

        private void MenuForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.FullOpen = true;
            colorDlg.Color = lbxData.ForeColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                lbxData.ForeColor = colorDlg.Color;
                if (this.UseTransparency && this.TextTransparency) 
                    this.TransparencyKey = lbxData.ForeColor;    
            }
        }

        private void MenuTransparent_Click(object sender, EventArgs e)
        {
            Form3 Dlg = new Form3(); 
            Dlg.UseTransparency = this.UseTransparency; 
            Dlg.TextTransparency = this.TextTransparency;
            Dlg.BackTransparency = this.BackTransparency;
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                if (Dlg.UseTransparency) 
                {
                    if (Dlg.TextTransparency) this.TransparencyKey = lbxData.ForeColor; 
                    if (Dlg.BackTransparency) this.TransparencyKey = lbxData.BackColor; 
                }
                else
                    this.TransparencyKey = Color.FromArgb(1, 1, 2, 3); 
                this.UseTransparency = Dlg.UseTransparency;
                this.TextTransparency = Dlg.TextTransparency; 
                this.BackTransparency = Dlg.BackTransparency;
            }

        }

        private void 到N的總和ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 dlg1 = new Form4();
            if (dlg1.ShowDialog() == DialogResult.OK)
            {
                string data = "1+2+...+N= " + dlg1.Sum1;
                lbxData.BeginUpdate();
                lbxData.Items.Add(data);
                lbxData.EndUpdate();
            }
        }

       // private void nToolStripMenuItem_Click(object sender, EventArgs e)
      //
    }
}
