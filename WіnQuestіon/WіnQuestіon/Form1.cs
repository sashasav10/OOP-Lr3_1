using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WіnQuestіon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btnyes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mи й не сумнівалися, що Ви так думаєте!");
        }

        private void Btnno_MouseMove(object sender, MouseEventArgs e)
        {
            btnno.Top -= e.Y;
            btnno.Left += e.X;
            if (btnno.Top < -10 || btnno.Top > 100) btnno.Top = 60;
            if (btnno.Left < -80 || btnno.Left > 250) btnno.Left = 120;
        }

        private void ss(object sender, EventArgs e)
        {

        }
    }
}
