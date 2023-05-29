namespace OOPHamburgerProjesi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            TSMSiparisYonetimi = new ToolStripMenuItem();
            SMISiparisOlustur = new ToolStripMenuItem();
            TSMUrunYonetimi = new ToolStripMenuItem();
            SMIMenuEkle = new ToolStripMenuItem();
            SMIEkstraMalzemeEkle = new ToolStripMenuItem();
            SMISiparisBilgileri = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TSMSiparisYonetimi, TSMUrunYonetimi });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // TSMSiparisYonetimi
            // 
            TSMSiparisYonetimi.DropDownItems.AddRange(new ToolStripItem[] { SMISiparisOlustur, SMISiparisBilgileri });
            TSMSiparisYonetimi.Name = "TSMSiparisYonetimi";
            TSMSiparisYonetimi.Size = new Size(129, 24);
            TSMSiparisYonetimi.Text = "Sipariş Yönetimi";
            // 
            // SMISiparisOlustur
            // 
            SMISiparisOlustur.Name = "SMISiparisOlustur";
            SMISiparisOlustur.Size = new Size(224, 26);
            SMISiparisOlustur.Text = "Sipariş Oluştur";
            SMISiparisOlustur.Click += SMISiparisOlustur_Click;
            // 
            // TSMUrunYonetimi
            // 
            TSMUrunYonetimi.DropDownItems.AddRange(new ToolStripItem[] { SMIMenuEkle, SMIEkstraMalzemeEkle });
            TSMUrunYonetimi.Name = "TSMUrunYonetimi";
            TSMUrunYonetimi.Size = new Size(116, 24);
            TSMUrunYonetimi.Text = "Ürün Yönetimi";
            // 
            // SMIMenuEkle
            // 
            SMIMenuEkle.Name = "SMIMenuEkle";
            SMIMenuEkle.Size = new Size(222, 26);
            SMIMenuEkle.Text = "Menü Ekle";
            SMIMenuEkle.Click += SMIMenuEkle_Click;
            // 
            // SMIEkstraMalzemeEkle
            // 
            SMIEkstraMalzemeEkle.Name = "SMIEkstraMalzemeEkle";
            SMIEkstraMalzemeEkle.Size = new Size(222, 26);
            SMIEkstraMalzemeEkle.Text = "Eksta Malzeme Ekle";
            SMIEkstraMalzemeEkle.Click += SMIEkstraMalzemeEkle_Click;
            // 
            // SMISiparisBilgileri
            // 
            SMISiparisBilgileri.Name = "SMISiparisBilgileri";
            SMISiparisBilgileri.Size = new Size(224, 26);
            SMISiparisBilgileri.Text = "Sipariş Bilgileri";
            SMISiparisBilgileri.Click += SMISiparisBilgileri_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem TSMSiparisYonetimi;
        private ToolStripMenuItem SMISiparisOlustur;
        private ToolStripMenuItem TSMUrunYonetimi;
        private ToolStripMenuItem SMIMenuEkle;
        private ToolStripMenuItem SMIEkstraMalzemeEkle;
        private ToolStripMenuItem SMISiparisBilgileri;
    }
}