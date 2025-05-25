using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Veri_tabanii
{
    public partial class BilgiGirisiFormu : Form
    {
        public BilgiGirisiFormu()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sinif = txtSinif.Text.Trim();
            string bolum = txtBolum.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sinif) || string.IsNullOrEmpty(bolum))
            {
                MessageBox.Show("Tüm alanları doldurunuz.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString;

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string query = "INSERT INTO Ogrenciler (KullaniciAdi, Sinif, Bolum) VALUES (@kullaniciAdi, @sinif, @bolum)";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@sinif", sinif);
                    komut.Parameters.AddWithValue("@bolum", bolum);

                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Bilgiler başarıyla kaydedildi.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bilgiler kaydedilemedi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
