using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace Veri_tabanii
{
    public partial class OgrenciGuncelleme: Form
    {
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        public OgrenciGuncelleme()
        {
            InitializeComponent();
        }

        

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            //string numara = txtNumara.Text.Trim();
            //string yeniAd = txtAd.Text.Trim();
            //string yeniSoyad = txtSoyad.Text.Trim();

            //if (numara == "" || yeniAd == "" || yeniSoyad == "")
            //{
            //    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            //    return;
            //}

            //try
            //{
            //    baglanti.Open();
            //    SqlCommand komut = new SqlCommand(
            //        "UPDATE Ogrenciler SET Ad = @Ad, Soyad = @Soyad WHERE OgrenciNumara = @Numara",
            //        baglanti);
            //    komut.Parameters.AddWithValue("@Ad", yeniAd);
            //    komut.Parameters.AddWithValue("@Soyad", yeniSoyad);
            //    komut.Parameters.AddWithValue("@Numara", numara);

            //    int etkilenen = komut.ExecuteNonQuery();
            //    baglanti.Close();

            //    if (etkilenen > 0)
            //        MessageBox.Show("Öğrenci bilgileri güncellendi.");
            //    else
            //        MessageBox.Show("Böyle bir numaraya sahip öğrenci bulunamadı.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Hata: " + ex.Message);
            //    baglanti.Close();
            //}
            try
            {
                string numara = txtNumara.Text.Trim();
                string ad = txtAd.Text.Trim();
                string soyad = txtSoyad.Text.Trim();
                int devamsizlik = Convert.ToInt32(txtDevamsizlik.Text.Trim());
                string sinif = txtSinif.Text.Trim();
                string bolum = txtBolum.Text.Trim();
                string kullaniciAdi = txtKullaniciAdi.Text.Trim();

                using (SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString))
                {
                    SqlCommand komut = new SqlCommand("sp_OgrenciGuncelle", baglanti);
                    komut.CommandType = CommandType.StoredProcedure;

                    komut.Parameters.AddWithValue("@OgrenciNumara", numara);
                    komut.Parameters.AddWithValue("@Ad", ad);
                    komut.Parameters.AddWithValue("@Soyad", soyad);
                    komut.Parameters.AddWithValue("@Devamsizlik", devamsizlik);
                    komut.Parameters.AddWithValue("@Sinif", sinif);
                    komut.Parameters.AddWithValue("@Bolum", bolum);
                    komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                    baglanti.Open();
                    int sonuc = komut.ExecuteNonQuery();
                    baglanti.Close();

                    if (sonuc > 0)
                        MessageBox.Show("Öğrenci bilgileri güncellendi.");
                    else
                        MessageBox.Show("Belirtilen numarada öğrenci bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

       
    }
}
