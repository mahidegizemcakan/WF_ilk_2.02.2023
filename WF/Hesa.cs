using System;
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
    public partial class Hesa : Form
    {
        public Hesa()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Topladık");
            decimal sayi1 = Convert.ToDecimal(textBox1.Text);
            decimal sayi2 = Convert.ToDecimal(textBox2.Text);
            decimal toplam = sayi1+sayi2;
            textBox3.Text = toplam.ToString();


               
        }

        private void Hesa_Load(object sender, EventArgs e)
        {

        }

        private void Hesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkardık");
            decimal sayi3 = Convert.ToDecimal(textBox4.Text);
            decimal sayi4 = Convert.ToDecimal(textBox5.Text);
            decimal Cıkar = sayi3 - sayi4;
            textBox6.Text = Cıkar.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çarptık..");
            decimal sayi3 = Convert.ToDecimal(textBox7.Text);
            decimal sayi4 = Convert.ToDecimal(textBox8.Text);
            decimal Carp = sayi3 * sayi4;
            textBox9.Text = Carp.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Böldükkk");
            decimal sayi3 = Convert.ToDecimal(textBox10.Text);
            decimal sayi4 = Convert.ToDecimal(textBox11.Text);
            decimal Bolme = sayi3 / sayi4;
            textBox12.Text = Bolme.ToString();
        }
    }
}
