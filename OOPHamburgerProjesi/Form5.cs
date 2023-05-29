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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Siparis.ButunSiparisler;
            SiparisBilgileriOlustur();
        }

        public void SiparisBilgileriOlustur()
        {
            Siparis siparis = new Siparis();
            double EkstraToplam = 0;
            foreach (double item in Siparis.EkstraToplamFiyat)
            {
                EkstraToplam += item;
            }

            label2.Text = Math.Round(Siparis.FinalFiyat * 0.2 , 2).ToString("C");
            label2.ForeColor = Color.Red;

            label3.Text = Siparis.ButunSiparisler.Count.ToString();
            label3.ForeColor = Color.Red;

            label4.Text = Math.Round(EkstraToplam, 2).ToString();
            label4.ForeColor = Color.Red;

            label5.Text = Siparis.TamamlananSiparisSayisi.ToString();
            label5.ForeColor = Color.Red;
        }
    }
}
