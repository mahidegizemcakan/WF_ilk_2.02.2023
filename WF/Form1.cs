﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(textBox1.Text);

            this.BackColor = Color.Pink;
            groupBox1.BackColor = Color.Orange;
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.AliceBlue;
            textBox3.BackColor = Color.Yellow;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
