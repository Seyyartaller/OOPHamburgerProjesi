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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Menu.MenuList.Add(new Menu { MenuAdi = textBox1.Text, MenuFiyati = double.Parse(textBox2.Text) });
                MessageBox.Show("Menü başarıyla eklendi");
            }
            else MessageBox.Show("Menü ismi veya fiyatı boş olamaz.");
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            if (!double.TryParse(textBox2.Text, out double result))
            {
                if (text.Length == 0) textBox2.Clear();
                else textBox2.Text = text.Substring(0, text.Length - 1);
                textBox2.SelectionStart = textBox2.Text.Length;
            }
        }
    }
}
