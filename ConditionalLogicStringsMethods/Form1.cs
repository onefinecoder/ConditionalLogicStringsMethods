﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConditionalLogicStringsMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            //textBox1.text has the text we want to find
            //contains is a method that looks for something inside a string
            //if the big string contains the little string, then take an action
            //like displaying a simple message
            if (textBox2.Text.Contains(textBox1.Text))
            {
                label2.Text = $"{textBox1.Text} has been found";
            }
            else
            {
                label2.Text = $"{textBox1.Text} has not been found";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
