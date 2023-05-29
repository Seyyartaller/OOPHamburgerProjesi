using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPHamburgerProjesi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Ekstra.ekstralar.Add(new Ekstra { EkstraAdi = textBox1.Text, Fiyat = double.Parse(textBox2.Text) });
                MessageBox.Show("Ekstra Malzeme başarıyla eklendi.");
            }
            else MessageBox.Show("Ekstra Malzeme ismi veya fiyatı boş olamaz.");
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            if(!double.TryParse(textBox2.Text,out double result))
            {
                if (text.Length == 0) textBox2.Clear();
                else textBox2.Text = text.Substring(0, text.Length - 1);
                textBox2.SelectionStart = textBox2.Text.Length;
            }
        }
    }
}
