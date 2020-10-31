using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerdanClient_Zulfa_Fathian_Yahya_20180140076
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
            double hasilTambah = obj.Tambah(a, b);
            tambah.Text = "Hasil Penambahan : " + hasilTambah.ToString();
            double hasilKurang = obj.Kurang(a, b);
            kurang.Text = "Hasil Pengurangan : " + hasilKurang.ToString();
            double hasilKali = obj.Kali(a, b);
            kali.Text = "Hasil Perkalian : " + hasilKali.ToString();
            double hasilBagi = obj.Bagi(a, b);
            bagi.Text = "Hasil Pembagian : " + hasilBagi.ToString();
        }
    }
}
