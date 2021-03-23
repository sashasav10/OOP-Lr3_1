using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WіnContaіner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void But_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)this.but.Text = "Fіrst";
            else if(radioButton2.Checked == true)this.but.Text = "Second";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SetFlowBreak(button6, true);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Button aButton = new Button();
            tableLayoutPanel1.Controls.Add(aButton, 1, 1);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if(splitContainer1.FixedPanel == FixedPanel.Panel1)
                splitContainer1.FixedPanel = FixedPanel.None;
            else
                splitContainer1.FixedPanel = FixedPanel.Panel1;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            splitContainer1.IsSplitterFixed= !(splitContainer1.IsSplitterFixed);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !(splitContainer1.Panel1Collapsed);
        }
    }
}
