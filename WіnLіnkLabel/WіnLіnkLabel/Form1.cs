﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WіnLіnkLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult aResult;
            Form2 aForm = new Form2();
            aResult = aForm.ShowDialog();
            if(aResult == System.Windows.Forms.DialogResult.OK){
                MessageBox.Show("Your name іs " + aForm.textBox1.Text + " "
                + aForm.textBox2.Text);
                MessageBox.Show("Your address іs " + aForm.textBox3.Text);
                MessageBox.Show("Your phone number іs " +
                aForm.maskedTextBox1.Text);
            }
            linkLabel1.LinkVisited = true;
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
            linkLabel2.LinkVisited = true;
        }
    }
}
