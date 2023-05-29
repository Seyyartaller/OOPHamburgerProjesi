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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SMISiparisOlustur_Click(object sender, EventArgs e)
        {
            ChildForm(new Form2());
        }

        public void ChildForm(Form childform)
        {
            this.Width = childform.Width + 40;
            this.Height = childform.Height + 85;
            bool durum = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == childform.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                childform.MdiParent = this;
                childform.Dock = DockStyle.Fill;
                childform.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SMIEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form4());
        }

        private void SMIMenuEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form3());
        }

        private void SMISiparisBilgileri_Click(object sender, EventArgs e)
        {
            ChildForm(new Form5());
        }
    }
}
