namespace OOPHamburgerProjesi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnSiparisOlustur = new Button();
            label3 = new Label();
            lblFiyat = new Label();
            btnSiparisTamamla = new Button();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 464);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(428, 106);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 432);
            label2.Name = "label2";
            label2.Size = new Size(142, 29);
            label2.TabIndex = 18;
            label2.Text = "MALZEME SEÇİN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 351);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 65);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "BOYUT SEÇİNİZ";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(342, 26);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(86, 32);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Büyük";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(174, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(72, 32);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Orta";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(6, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(86, 32);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "Küçük";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 317);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(428, 28);
            comboBox1.TabIndex = 17;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 288);
            label1.Name = "label1";
            label1.Size = new Size(109, 26);
            label1.TabIndex = 16;
            label1.Text = "MENÜ SEÇİN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(428, 273);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnSiparisOlustur
            // 
            btnSiparisOlustur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisOlustur.Location = new Point(12, 638);
            btnSiparisOlustur.Name = "btnSiparisOlustur";
            btnSiparisOlustur.Size = new Size(209, 86);
            btnSiparisOlustur.TabIndex = 20;
            btnSiparisOlustur.Text = "Sipariş Oluştur";
            btnSiparisOlustur.UseVisualStyleBackColor = true;
            btnSiparisOlustur.Click += btnSiparis_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(377, 653);
            label3.Name = "label3";
            label3.Size = new Size(172, 57);
            label3.TabIndex = 21;
            label3.Text = "TOPLAM TUTAR:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFiyat
            // 
            lblFiyat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiyat.Location = new Point(555, 653);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(101, 57);
            lblFiyat.TabIndex = 22;
            lblFiyat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSiparisTamamla
            // 
            btnSiparisTamamla.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisTamamla.Location = new Point(845, 638);
            btnSiparisTamamla.Name = "btnSiparisTamamla";
            btnSiparisTamamla.Size = new Size(199, 86);
            btnSiparisTamamla.TabIndex = 23;
            btnSiparisTamamla.Text = "Sipariş Tamamla";
            btnSiparisTamamla.UseVisualStyleBackColor = true;
            btnSiparisTamamla.Click += button1_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 584);
            label5.Name = "label5";
            label5.Size = new Size(113, 35);
            label5.TabIndex = 25;
            label5.Text = "Adet:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(131, 592);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(90, 27);
            numericUpDown1.TabIndex = 26;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(446, 10);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(598, 624);
            listBox1.TabIndex = 27;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 736);
            Controls.Add(listBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(btnSiparisTamamla);
            Controls.Add(lblFiyat);
            Controls.Add(label3);
            Controls.Add(btnSiparisOlustur);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnSiparisOlustur;
        private Label label3;
        private Label lblFiyat;
        private Button btnSiparisTamamla;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private ListBox listBox1;
    }
}