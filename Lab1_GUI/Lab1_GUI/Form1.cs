﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ColourCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ColourCheckBox.Checked == true)
            {
                messageTextBox.ForeColor = Color.Red;
            }
            else
            {
                messageTextBox.ForeColor = Color.Black;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
