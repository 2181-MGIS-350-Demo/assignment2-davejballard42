﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        // Can I make this work?
        public Form1()
        {
            InitializeComponent();
            lblMessage.Text = "NULL";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Comments rule
            lblMessage.Text = "Hello world";
        }
    }
}
