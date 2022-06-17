using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace online_system
{
    public partial class Form3 : Form
    {
        
        public static Form2 f2 = new Form2();
        public static Form4 f4 = new Form4();

        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            radioButton3.BackColor = Color.Transparent;
            radioButton4.BackColor = Color.Transparent;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            f2.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f4.Show();
            this.Hide();
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
