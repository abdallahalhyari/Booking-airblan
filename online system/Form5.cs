﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace online_system
{
    public partial class Form5 : Form
    {


        public static Form4 f4 = new Form4();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(900, 500);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            f4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f4.Show();
            this.Hide();
        }
    }
}
