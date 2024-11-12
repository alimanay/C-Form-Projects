using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace öğrencinot
{
    public partial class Form1 : Form
    {
        private List<string> Ögrenciler = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }


        int toplam_Ogrenci = 0;
        private void Btn_ListeyeEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_İsim == null || text_Soyisim == null || numericUpDown_OgrenciNo.Value == 0)
                {
                    MessageBox.Show("Lütfen Tüm Bilgileri Doldurunuz! ");
                    OgrenciListesi.Items.Remove(OgrenciListesi.SelectedItems);
                }
                else
                {
                    if (RadioBtn_Erkek.Checked == true)
                    {
                        if (VizeBtn.Value == 100 || FinalBtn.Value == 100)
                        {
                            KalanOgrenciler.Text = "";
                        }
                        else
                        if (Sonuc < 60)
                        {
                            KalanOgrenciler.Items.Insert(0, "Erkek" + ", " + "İsim:" + text_İsim.Text + "   " + "Soyİsim:" + text_Soyisim.Text + "  Ogrenci no" + numericUpDown_OgrenciNo.Value + "  " + "Ortalama:" + Sonuc + " KALDI");
                        }
                    }
                    if (RadioButton_Kadın.Checked == true)
                    {
                        if (VizeBtn.Value == 100 || FinalBtn.Value == 100)
                        {
                            KalanOgrenciler.Text = "";
                        }
                        else
                        if (Sonuc < 60)
                        {
                            KalanOgrenciler.Items.Insert(0, "Kadın" + ", " + "İsim:" + text_İsim.Text + "   " + "SoyİSim:" + text_Soyisim.Text + "  Ogrenci no:" + numericUpDown_OgrenciNo.Value + " " + "Ortalama:" + Sonuc + " KALDI");

                        }


                        if (RadioBtn_Erkek.Checked == true)
                        {
                            OgrenciListesi.Items.Insert(0, label1.Text + " " + text_İsim.Text + "   " + label2.Text + " " + text_Soyisim.Text + "   " + "Erkek" + label3.Text + "  " + Convert.ToString(numericUpDown_OgrenciNo.Value) + "   " + label9.Text + "   " + VizeBtn.Value + "   " + label8.Text + "   " +
                           "" + FinalBtn.Value + "  " + "Ortalama:" + Sonuc);
                            toplam_Ogrenci++;

                            text_İsim.Text = "";
                            text_Soyisim.Text = "";
                            numericUpDown_OgrenciNo.Value = 0;
                            VizeBtn.Value = 0;
                            FinalBtn.Value = 0;
                            BütBtn.Value = 0;
                            Sonuc = 0;
                            RadioBtn_Erkek.Checked = false;
                        }
                        else
                        {
                            OgrenciListesi.Items.Insert(0, "isim" + text_İsim.Text + "   " + "Soyİsim:" + text_Soyisim.Text + "   " + "Kadın" + label3.Text + "  " + Convert.ToString(numericUpDown_OgrenciNo.Value) + "   " + label9.Text + "   " + VizeBtn.Value + "   " + label8.Text + "   " +
                         "" + FinalBtn.Value + "  " + "Ortalama:" + Sonuc);
                            toplam_Ogrenci++;
                            text_İsim.Text = "";
                            text_Soyisim.Text = "";
                            numericUpDown_OgrenciNo.Value = 0;
                            VizeBtn.Value = 0;
                            FinalBtn.Value = 0;
                            BütBtn.Value = 0;
                            Sonuc = 0;
                            RadioButton_Kadın.Checked = false;
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        double Sonuc;
        private void Btn_Hesapla_Click(object sender, EventArgs e)
        {

            if (BütBtn.Value == 0)
            {
                Sonuc = (((Convert.ToDouble(VizeBtn.Value) * 40) / 100) + ((Convert.ToDouble(FinalBtn.Value) * 60) / 100));

            }
            else
            {

                Sonuc = ((Convert.ToDouble(VizeBtn.Value * 40)) / 100) + ((Convert.ToDouble(BütBtn.Value) * 60) / 100);
            }

        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {

            if (text_İsim.Text != null || text_Soyisim.Text != null || numericUpDown_OgrenciNo.Value != 0 || VizeBtn.Value != 0 || FinalBtn.Value != 0 || BütBtn.Value != 0)
            {

                try
                {
                    int index = OgrenciListesi.Items.IndexOf(OgrenciListesi.Text);
                    int index1 = KalanOgrenciler.Items.IndexOf(KalanOgrenciler.Text);

                    OgrenciListesi.Items.Remove(OgrenciListesi.SelectedItem);
                    OgrenciListesi.Items.Insert(index, "isim:" + label1.Text + ": " + "Soyisim:" + text_İsim.Text + " " + label2.Text + ":" + text_Soyisim.Text + " " + label3.Text + " " + numericUpDown_OgrenciNo.Value + " " + label9.Text + VizeBtn.Value + "  " + label8.Text + " " + FinalBtn.Value + " ");

                    KalanOgrenciler.Items.Insert(index1, "isim:" + text_İsim.Text + "   " + "Soyisim:" + text_Soyisim.Text + "  " + " " + numericUpDown_OgrenciNo.Value + "Ortalama:" + Sonuc + " KALDI");
                    KalanOgrenciler.Items.Remove(KalanOgrenciler.SelectedItem);
                }
                catch (Exception)
                {

                    MessageBox.Show("Geçersiz  İşlem Bilgileri Doldurunuz!");
                }
            }
            else
            {
                MessageBox.Show("lütfen Güncellemek İçin Bilgileri Doldurunuz");
            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {

            if (OgrenciListesi.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silmek için bir öğrenci seçin!");
                return;
            }

            string selectedItem = OgrenciListesi.SelectedItem.ToString();

            string[] parts = selectedItem.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string studentNo = parts[4];

            // Öğrenciyi OgrenciListesi'nden sil
            OgrenciListesi.Items.Remove(OgrenciListesi.SelectedItem);


            for (int i = KalanOgrenciler.Items.Count - 1; i >= 0; i--)
            {
                string item = KalanOgrenciler.Items[i].ToString();


                if (item.Contains("Ogrenci no" + studentNo))
                {
                    KalanOgrenciler.Items.RemoveAt(i);
                }
            }

            MessageBox.Show("Öğrenci silindi!");
        }

        private void Hesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int erkekSA = 0;
                int kadınSa = 0;

                foreach (string item in KalanOgrenciler.Items)
                {
                    if (item.Split(',')[0] == "Erkek")
                    {
                        erkekSA++;
                    }
                    else
                    {
                        kadınSa++;
                    }
                }
                label4.Text = "Kalan Kız Öğrenci Sayısı:" + kadınSa.ToString();
                label5.Text = "kalan Erkek Öğrenci Sayısı" + erkekSA.ToString();
                label6.Text = Math.Round((double)(erkekSA + kadınSa) / toplam_Ogrenci * 100) + "%";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void text_Soyisim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void text_İsim_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
