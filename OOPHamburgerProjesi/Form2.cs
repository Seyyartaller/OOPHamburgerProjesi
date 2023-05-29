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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Ekstra item in Ekstra.ekstralar)
            {
                flowLayoutPanel1.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag = item });
            }
            foreach (Menu item in Menu.MenuList)
            {
                comboBox1.Items.Add(item.MenuAdi);
            }
            Siparis.ToplamFiyat = 0;
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.MenuSiparisOlustur(comboBox1);
            siparis.EkstralarSiparisOlustur(flowLayoutPanel1);
            siparis.BoyutSec(groupBox1, radioButton1, radioButton2, radioButton3);
            siparis.AdetSec(numericUpDown1);

            siparis.SiparisListesiYazdir(numericUpDown1, listBox1);
            lblFiyat.Text = siparis._ToplamFiyat.ToString("C");
            SiparisTemizle();
        }



        public void SiparisTemizle()
        {
            foreach (Control item in this.Controls)
            {
                switch (item)
                {
                    case ComboBox:
                        comboBox1.SelectedIndex = -1;
                        break;
                    case GroupBox:
                        foreach (RadioButton rdb in groupBox1.Controls)
                        {
                            rdb.Checked = false;
                        }
                        break;
                    case FlowLayoutPanel:
                        foreach (CheckBox chk in flowLayoutPanel1.Controls)
                        {
                            chk.Checked = false;
                        }
                        break;
                    case NumericUpDown:
                        numericUpDown1.Value = 1;
                        break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(comboBox1.SelectedIndex != -1)
                pictureBox1.Image = Image.FromFile(@$"Menu Images/{comboBox1.SelectedItem.ToString()}.png");
            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Toplam Sipariş Tutarı: {lblFiyat.Text}\nSatın almayı tamamlamak ister misiniz?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            switch (result)
            {
                case DialogResult.Yes:
                    Siparis siparis = new Siparis();
                    Form5 form5 = new Form5();
                    form5.SiparisBilgileriOlustur();
                    foreach (string item in listBox1.Items) 
                    {
                        Siparis.TamamlananSiparisSayisi++;
                    }
                    break;
                case DialogResult.No:
                    MessageBox.Show("Sipariş İptal Edildi");
                    SiparisTemizle();
                    break;
            }
        }
    }
}
