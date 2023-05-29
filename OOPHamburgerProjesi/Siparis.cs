using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPHamburgerProjesi
{
    public class Siparis
    {
        public static double ToplamFiyat { get; set; }
        public double _ToplamFiyat
        {
            get { return ToplamFiyat; }
            set { ToplamFiyat = value; }
        }
        public static double FinalFiyat { get; set; }

        public static int TamamlananSiparisSayisi { get; set; }

        public double ikincilToplamFiyat { get; set; }

        public List<Ekstra> SeciliEkstralar = new List<Ekstra>();

        public List<Menu> SeciliMenu = new List<Menu>();

        public static List<string> ButunSiparisler = new List<string>();

        public static List<double> EkstraToplamFiyat = new List<double>();

        RadioButton radioButton = new RadioButton();

        string SeciliMenuAdi, ToplamMenuListesi;

        bool MenuSecili = true, BoyutSecili = true;

        public double EkstralarSiparisOlustur(FlowLayoutPanel panel)
        {

            foreach (CheckBox checkBox in panel.Controls)
            {
                if (checkBox.Checked)
                {
                    SeciliEkstralar.Add((Ekstra)(checkBox.Tag));
                }
            }

            foreach (Ekstra ekstra in SeciliEkstralar)
            {
                ikincilToplamFiyat += ekstra.Fiyat;
                EkstraToplamFiyat.Add(ekstra.Fiyat);
            }
            return ikincilToplamFiyat;
        }

        public void MenuSiparisOlustur(ComboBox comboBox)
        {
            foreach (Menu item in Menu.MenuList)
            {
                try
                {
                    if (item.MenuAdi == comboBox.SelectedItem.ToString())
                    {
                        ikincilToplamFiyat += item.MenuFiyati;
                        SeciliMenuAdi = item.MenuAdi;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen bir menü seçiniz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    MenuSecili = false;
                    break;
                }
                
            }
        }

        public RadioButton BoyutSec(GroupBox groupBox, RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3)
        {
            foreach (RadioButton item in groupBox.Controls)
            {
                if (radioButton1.Checked)
                {
                    ikincilToplamFiyat += (double)Boyut.Küçük;
                    radioButton = radioButton1;
                }
                else if (radioButton2.Checked)
                {
                    ikincilToplamFiyat += (double)Boyut.Orta;
                    radioButton = radioButton2;
                }
                else if (radioButton3.Checked)
                {
                    ikincilToplamFiyat += (double)Boyut.Büyük;
                    radioButton = radioButton3;
                }
                else
                {
                    MessageBox.Show("Lütfen bir boyut seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BoyutSecili = false;
                } 
                break;
            }
            return radioButton;
        }

        public double AdetSec(NumericUpDown AdetSayisi)
        {
            return ikincilToplamFiyat = ikincilToplamFiyat * (double)AdetSayisi.Value;
        }


        public void SiparisListesiYazdir(NumericUpDown nmbud,ListBox listbox)
        {
            if (MenuSecili == true && BoyutSecili == true)
            {
                ToplamFiyat += ikincilToplamFiyat;
                FinalFiyat += ikincilToplamFiyat;
                ToplamMenuListesi += $"{nmbud.Value} adet {radioButton.Text} boy {SeciliMenuAdi}, Ekstralar:";
                foreach (var item in SeciliEkstralar)
                {
                    ToplamMenuListesi += " " + item.EkstraAdi + " ,";
                }
                ToplamMenuListesi = ToplamMenuListesi.Substring(0, ToplamMenuListesi.Length - 1);
                string metin = $"{ToplamMenuListesi} =>   {ikincilToplamFiyat.ToString("C")}";
                ButunSiparisler.Add( metin );
                listbox.Items.Add(metin);
            }
            else ikincilToplamFiyat = 0;
        }
    }
}
