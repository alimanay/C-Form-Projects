namespace öğrencinot
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_Soyisim = new System.Windows.Forms.TextBox();
            this.Cinsiyet = new System.Windows.Forms.GroupBox();
            this.RadioButton_Kadın = new System.Windows.Forms.RadioButton();
            this.RadioBtn_Erkek = new System.Windows.Forms.RadioButton();
            this.numericUpDown_OgrenciNo = new System.Windows.Forms.NumericUpDown();
            this.OgrenciListesi = new System.Windows.Forms.ListBox();
            this.KalanOgrenciler = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.VizeBtn = new System.Windows.Forms.NumericUpDown();
            this.FinalBtn = new System.Windows.Forms.NumericUpDown();
            this.BütBtn = new System.Windows.Forms.NumericUpDown();
            this.Btn_ListeyeEkle = new System.Windows.Forms.Button();
            this.Btn_Hesapla = new System.Windows.Forms.Button();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Hesapla = new System.Windows.Forms.Button();
            this.text_İsim = new System.Windows.Forms.TextBox();
            this.Cinsiyet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_OgrenciNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BütBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci No";
            // 
            // text_Soyisim
            // 
            this.text_Soyisim.Location = new System.Drawing.Point(101, 64);
            this.text_Soyisim.Name = "text_Soyisim";
            this.text_Soyisim.Size = new System.Drawing.Size(100, 22);
            this.text_Soyisim.TabIndex = 2;
            this.text_Soyisim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_Soyisim_KeyPress);
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.Controls.Add(this.RadioButton_Kadın);
            this.Cinsiyet.Controls.Add(this.RadioBtn_Erkek);
            this.Cinsiyet.Location = new System.Drawing.Point(39, 164);
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Size = new System.Drawing.Size(227, 51);
            this.Cinsiyet.TabIndex = 6;
            this.Cinsiyet.TabStop = false;
            this.Cinsiyet.Text = "Cinsiyet";
            // 
            // RadioButton_Kadın
            // 
            this.RadioButton_Kadın.AutoSize = true;
            this.RadioButton_Kadın.Location = new System.Drawing.Point(120, 21);
            this.RadioButton_Kadın.Name = "RadioButton_Kadın";
            this.RadioButton_Kadın.Size = new System.Drawing.Size(62, 20);
            this.RadioButton_Kadın.TabIndex = 5;
            this.RadioButton_Kadın.TabStop = true;
            this.RadioButton_Kadın.Text = "Kadın";
            this.RadioButton_Kadın.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_Erkek
            // 
            this.RadioBtn_Erkek.AutoSize = true;
            this.RadioBtn_Erkek.Location = new System.Drawing.Point(15, 21);
            this.RadioBtn_Erkek.Name = "RadioBtn_Erkek";
            this.RadioBtn_Erkek.Size = new System.Drawing.Size(63, 20);
            this.RadioBtn_Erkek.TabIndex = 4;
            this.RadioBtn_Erkek.TabStop = true;
            this.RadioBtn_Erkek.Text = "Erkek";
            this.RadioBtn_Erkek.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_OgrenciNo
            // 
            this.numericUpDown_OgrenciNo.Location = new System.Drawing.Point(101, 108);
            this.numericUpDown_OgrenciNo.Name = "numericUpDown_OgrenciNo";
            this.numericUpDown_OgrenciNo.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_OgrenciNo.TabIndex = 3;
            // 
            // OgrenciListesi
            // 
            this.OgrenciListesi.FormattingEnabled = true;
            this.OgrenciListesi.ItemHeight = 16;
            this.OgrenciListesi.Location = new System.Drawing.Point(39, 272);
            this.OgrenciListesi.Name = "OgrenciListesi";
            this.OgrenciListesi.Size = new System.Drawing.Size(603, 228);
            this.OgrenciListesi.TabIndex = 8;
            // 
            // KalanOgrenciler
            // 
            this.KalanOgrenciler.FormattingEnabled = true;
            this.KalanOgrenciler.ItemHeight = 16;
            this.KalanOgrenciler.Location = new System.Drawing.Point(648, 12);
            this.KalanOgrenciler.Name = "KalanOgrenciler";
            this.KalanOgrenciler.Size = new System.Drawing.Size(324, 468);
            this.KalanOgrenciler.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(978, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kalan Kız Öğrenci Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(978, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kalan Erkek  Öğrenci Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(978, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kalan Öğrenci Oranı";
        
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Büt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Final";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Vize";
            // 
            // VizeBtn
            // 
            this.VizeBtn.Location = new System.Drawing.Point(376, 19);
            this.VizeBtn.Name = "VizeBtn";
            this.VizeBtn.Size = new System.Drawing.Size(120, 22);
            this.VizeBtn.TabIndex = 7;
            // 
            // FinalBtn
            // 
            this.FinalBtn.Location = new System.Drawing.Point(376, 62);
            this.FinalBtn.Name = "FinalBtn";
            this.FinalBtn.Size = new System.Drawing.Size(120, 22);
            this.FinalBtn.TabIndex = 8;
            // 
            // BütBtn
            // 
            this.BütBtn.Location = new System.Drawing.Point(376, 106);
            this.BütBtn.Name = "BütBtn";
            this.BütBtn.Size = new System.Drawing.Size(120, 22);
            this.BütBtn.TabIndex = 9;
            // 
            // Btn_ListeyeEkle
            // 
            this.Btn_ListeyeEkle.Location = new System.Drawing.Point(54, 237);
            this.Btn_ListeyeEkle.Name = "Btn_ListeyeEkle";
            this.Btn_ListeyeEkle.Size = new System.Drawing.Size(212, 29);
            this.Btn_ListeyeEkle.TabIndex = 6;
            this.Btn_ListeyeEkle.Text = "Listeye Ekle";
            this.Btn_ListeyeEkle.UseVisualStyleBackColor = true;
            this.Btn_ListeyeEkle.Click += new System.EventHandler(this.Btn_ListeyeEkle_Click);
            // 
            // Btn_Hesapla
            // 
            this.Btn_Hesapla.Location = new System.Drawing.Point(376, 139);
            this.Btn_Hesapla.Name = "Btn_Hesapla";
            this.Btn_Hesapla.Size = new System.Drawing.Size(120, 34);
            this.Btn_Hesapla.TabIndex = 10;
            this.Btn_Hesapla.Text = "Hesapla";
            this.Btn_Hesapla.UseVisualStyleBackColor = true;
            this.Btn_Hesapla.Click += new System.EventHandler(this.Btn_Hesapla_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Location = new System.Drawing.Point(408, 237);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(99, 29);
            this.Btn_Guncelle.TabIndex = 11;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = true;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Location = new System.Drawing.Point(534, 237);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(108, 29);
            this.Btn_Sil.TabIndex = 12;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Hesapla
            // 
            this.Hesapla.Location = new System.Drawing.Point(991, 164);
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.Size = new System.Drawing.Size(113, 36);
            this.Hesapla.TabIndex = 13;
            this.Hesapla.Text = "hesapla";
            this.Hesapla.UseVisualStyleBackColor = true;
            this.Hesapla.Click += new System.EventHandler(this.Hesapla_Click);
            // 
            // text_İsim
            // 
            this.text_İsim.Location = new System.Drawing.Point(101, 27);
            this.text_İsim.Name = "text_İsim";
            this.text_İsim.Size = new System.Drawing.Size(100, 22);
            this.text_İsim.TabIndex = 1;
            this.text_İsim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_İsim_KeyPress_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 512);
            this.Controls.Add(this.text_İsim);
            this.Controls.Add(this.Hesapla);
            this.Controls.Add(this.Btn_Sil);
            this.Controls.Add(this.Btn_Guncelle);
            this.Controls.Add(this.Btn_Hesapla);
            this.Controls.Add(this.Btn_ListeyeEkle);
            this.Controls.Add(this.BütBtn);
            this.Controls.Add(this.FinalBtn);
            this.Controls.Add(this.VizeBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KalanOgrenciler);
            this.Controls.Add(this.OgrenciListesi);
            this.Controls.Add(this.numericUpDown_OgrenciNo);
            this.Controls.Add(this.Cinsiyet);
            this.Controls.Add(this.text_Soyisim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
          
            this.Cinsiyet.ResumeLayout(false);
            this.Cinsiyet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_OgrenciNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BütBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_Soyisim;
        private System.Windows.Forms.GroupBox Cinsiyet;
        private System.Windows.Forms.RadioButton RadioButton_Kadın;
        private System.Windows.Forms.RadioButton RadioBtn_Erkek;
        private System.Windows.Forms.NumericUpDown numericUpDown_OgrenciNo;
        private System.Windows.Forms.ListBox OgrenciListesi;
        private System.Windows.Forms.ListBox KalanOgrenciler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown VizeBtn;
        private System.Windows.Forms.NumericUpDown FinalBtn;
        private System.Windows.Forms.NumericUpDown BütBtn;
        private System.Windows.Forms.Button Btn_ListeyeEkle;
        private System.Windows.Forms.Button Btn_Hesapla;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.Button Hesapla;
        private System.Windows.Forms.TextBox text_İsim;
    }
}

