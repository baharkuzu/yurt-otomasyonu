using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AtamanApart
{
    public partial class StudentRegistry : MaterialForm
    {
        public StudentRegistry()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Lime700, Primary.Lime700, Primary.Lime700, Accent.Orange400, TextShade.WHITE);
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.16.0; Data Source =your Path");
        DataSet dtst = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();

        string durum = "";

        public void temiz()
        {
            if (durum_aktif.Checked)
            {
                durum_aktif.Checked = false;
            }
            else if (durum_pasif.Checked)
            {
                durum_pasif.Checked = false;
            }
            tc_no.Clear();
            ad.Clear();
            soyad.Clear();
            okul.Clear();
            bolum.Clear();
            tel_no.Clear();
            ikanetgah.Clear();
            anne_adsoyad.Clear();
            baba_adsoyad.Clear();
            yakin_tel.Clear();
            oda_no.Clear();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tc_no.Text) || string.IsNullOrEmpty(ad.Text) || string.IsNullOrEmpty(soyad.Text) || string.IsNullOrEmpty(okul.Text) || string.IsNullOrEmpty(bolum.Text) || string.IsNullOrEmpty(sinif.Text) || string.IsNullOrEmpty(tel_no.Text) || string.IsNullOrEmpty(sehir.Text) || string.IsNullOrEmpty(ikanetgah.Text) || string.IsNullOrEmpty(oda_no.Text) || string.IsNullOrEmpty(anne_adsoyad.Text) || string.IsNullOrEmpty(baba_adsoyad.Text) || string.IsNullOrEmpty(yakin_tel.Text))
            {
                MessageBox.Show("Kayıt işlemi için geçerli tüm alanları eksiksiz doldurunuz.", "Kayıt İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();

                if (durum_aktif.Checked == true)
                    durum = durum_aktif.Text;
                else
                    durum = durum_pasif.Text;

                string ekleme = "INSERT into ogrenci ([ogrenci_tc],[ogrenci_ad],[ogrenci_soyad],[d_tarih],[okul],[bolum],[sinif],[telefon_no],[sehir],[ikametgah],[anne_adsoyad],[baba_adsoyad],[yakin_tel],[durum],[oda])  Values ('" + tc_no.Text + "','" + ad.Text + "','" + soyad.Text + "','" + d_tarih.Text + "','" + okul.Text + "','" + bolum.Text + "','" + sinif.Text + "','" + tel_no.Text + "','" + sehir.Text + "','" + ikanetgah.Text + "','" + anne_adsoyad.Text + "','" + baba_adsoyad.Text + "','" + yakin_tel.Text + "','" + durum + "','" + oda_no.Text + "')";
                OleDbCommand kaydet = new OleDbCommand(ekleme, baglanti);
                kaydet.ExecuteNonQuery();

                MessageBox.Show("Kayıt işlemi başarıyla gerçekleştirilmiştir.", "Başarılı Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();

            }
            temiz();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tc_no.Text) || string.IsNullOrEmpty(ad.Text) || string.IsNullOrEmpty(soyad.Text) || string.IsNullOrEmpty(okul.Text) || string.IsNullOrEmpty(bolum.Text) || string.IsNullOrEmpty(sinif.Text) || string.IsNullOrEmpty(tel_no.Text) || string.IsNullOrEmpty(sehir.Text) || string.IsNullOrEmpty(ikanetgah.Text) || string.IsNullOrEmpty(oda_no.Text) || string.IsNullOrEmpty(anne_adsoyad.Text) || string.IsNullOrEmpty(baba_adsoyad.Text) || string.IsNullOrEmpty(yakin_tel.Text))
            {
                MessageBox.Show("Güncelleme işlemi için önce öğrenci aratınız.", "Güncelleme İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                try
                {
                    if (durum_aktif.Checked == true)
                        durum = durum_aktif.Text;
                    else
                        durum = durum_pasif.Text;

                    string sql = "UPDATE ogrenci SET ogrenci_ad='" + ad.Text + "',ogrenci_soyad='" + soyad.Text + "',d_tarih='" + d_tarih.Text + "',okul='" + okul.Text + "',bolum='" + bolum.Text + "',sinif='" + sinif.Text + "',telefon_no='" + tel_no.Text + "',sehir='" + sehir.Text + "',ikametgah='" + ikanetgah.Text + "',anne_adsoyad='" + anne_adsoyad.Text + "',baba_adsoyad='" + baba_adsoyad.Text + "',yakin_tel='" + yakin_tel.Text + "',durum='" + durum + "',oda='" + oda_no.Text + "' where ogrenci_tc='" + tc_no.Text + "'";
                    OleDbCommand komut = new OleDbCommand(sql, baglanti);
                    if (komut.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Güncelleme işlemi başarıyla gerçekleştirilmiştir.", "Başarılı Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message.ToString());
                }
                baglanti.Close();
            }
            temiz();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tc_no.Text) || string.IsNullOrEmpty(ad.Text) || string.IsNullOrEmpty(soyad.Text) || string.IsNullOrEmpty(okul.Text) || string.IsNullOrEmpty(bolum.Text) || string.IsNullOrEmpty(sinif.Text) || string.IsNullOrEmpty(tel_no.Text) || string.IsNullOrEmpty(sehir.Text) || string.IsNullOrEmpty(ikanetgah.Text) || string.IsNullOrEmpty(oda_no.Text) || string.IsNullOrEmpty(anne_adsoyad.Text) || string.IsNullOrEmpty(baba_adsoyad.Text) || string.IsNullOrEmpty(yakin_tel.Text))
            {
                MessageBox.Show("Silme işlemi için önce öğrenci aratınız.", "Silme İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (durum_aktif.Checked == true)
                    durum = durum_aktif.Text;
                else
                    durum = durum_pasif.Text;

                string silme = "DELETE From ogrenci Where [ogrenci_tc]='" + tc_no.Text + "'";
                baglanti.Open();


                if (durum == "Pasif")
                {

                    if (MessageBox.Show("Kayıt pasif halde, silinebilir.\nSilmek istediğinize emin misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        OleDbCommand sil_komut = new OleDbCommand(silme, baglanti);
                        sil_komut.ExecuteNonQuery();
                        MessageBox.Show("Silme işlemi başarıyla gerçekleştirilmiştir.", "Başarılı Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (durum == "Aktif")
                {
                    if (MessageBox.Show("Kayıt aktif halde,silinmemeli.\nSilmek istediğinize emin misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        OleDbCommand sil_komut = new OleDbCommand(silme, baglanti);
                        sil_komut.ExecuteNonQuery();
                        MessageBox.Show("Silme işlemi başarıyla gerçekleştirilmiştir.", "Başarılı Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                baglanti.Close();
            }
            temiz();
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            temiz();
        }

        private void kayit_ara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
       string text = "select * from ogrenci where ogrenci_tc='" + tc_no.Text + "'";
       OleDbCommand arama = new OleDbCommand(text, baglanti);
       OleDbDataReader oku = arama.ExecuteReader();

       if (oku.Read())
       {
           //MessageBox.Show("Kişi mevcut");
           ad.Text = oku["ogrenci_ad"].ToString();
           soyad.Text = oku["ogrenci_soyad"].ToString();
           soyad.Text = oku["ogrenci_soyad"].ToString();
           d_tarih.Text = oku["d_tarih"].ToString();
           okul.Text = oku["okul"].ToString();
           bolum.Text = oku["bolum"].ToString();
           sinif.Text = oku["sinif"].ToString();
           tel_no.Text = oku["telefon_no"].ToString();
           sehir.Text = oku["sehir"].ToString();
           ikanetgah.Text = oku["ikametgah"].ToString();
           anne_adsoyad.Text = oku["anne_adsoyad"].ToString();
           baba_adsoyad.Text = oku["baba_adsoyad"].ToString();
           yakin_tel.Text = oku["yakin_tel"].ToString();
           durum = oku["durum"].ToString();

           if (durum == "Aktif")
           {
               durum_aktif.Checked = true;
           }
           else
           {
               durum_pasif.Checked = true;
           }

           oda_no.Text = oku["oda"].ToString();
       }
       else
       {
           MessageBox.Show("Aradığınız T.C kimlik numarasına ait bir öğrenci bulunmamaktadır.", "Arama İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
       }
       baglanti.Close();
        }



        #region Form İçerikleri Kontrol Etme

        private void tc_no_KeyPress(object sender, KeyPressEventArgs e)
                {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Lütfen sayı giriniz.");
            }
            else
            {
                e.Handled = false;
            }

            if (tc_no.TextLength == 11)
            {
                MessageBox.Show("TC kimlik numarası 11 karakterden oluşmaktadır.Lütfen doğru girildiğinden emin olunuz.");
                e.Handled = true;
                tc_no.Clear();
            }
        }

        private void ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bu alanda rakam bulunamaz,lütfen düzgün doldurulduğundan emin olunuz.");
            }
            else
            {
                e.Handled = false;
            }
        }


        private void soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bu alanda rakam bulunamaz,lütfen düzgün doldurulduğundan emin olunuz.");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void okul_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bu alanda rakam bulunamaz,lütfen düzgün doldurulduğundan emin olunuz.");
    }
            else
            {
                e.Handled = false;
            }
        }

        private void bolum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bu alanda rakam bulunamaz,lütfen düzgün doldurulduğundan emin olunuz.");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void tel_no_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Lütfen sayı giriniz.");
    }
            else
            {
                e.Handled = false;
            }

            if (tel_no.TextLength == 10)
            {
                e.Handled = true;
                MessageBox.Show("Telefon numarası 10 karakterden oluşur.Alanın doğru girildiğinden emin olunuz.");
                tel_no.Clear();
            }
        }

        private void oda_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Lütfen sayı giriniz.");
    }
            else
            {
                e.Handled = false;
            }
            if (oda_no.TextLength > 2)
            {
                e.Handled = true;
            }

        }

        private void anne_adsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bu alanda rakam bulunamaz,lütfen düzgün doldurulduğundan emin olunuz.");
    }
            else
            {
                e.Handled = false;
            }
        }

        private void baba_adsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bu alanda rakam bulunamaz,lütfen düzgün doldurulduğundan emin olunuz.");
    }
            else
            {
                e.Handled = false;
            }
        }

        private void yakin_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Lütfen sayı giriniz.");
    }
            else
            {
                e.Handled = false;
            }

            if (yakin_tel.TextLength == 10)
            {
                e.Handled = true;
                MessageBox.Show("Telefon numarası 10 karakterden oluşur.Alanın doğru girildiğinden emin olunuz.");
                yakin_tel.Clear();
            }
        }



        #endregion




    }
}
