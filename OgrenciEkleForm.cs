using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace Veri_tabanii
{
    public partial class OgrenciEkleForm : Form
    {
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        public OgrenciEkleForm()
        {
            InitializeComponent();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            
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
                    SqlCommand komut = new SqlCommand("sp_OgrenciEkle", baglanti);
                    komut.CommandType = CommandType.StoredProcedure;

                    komut.Parameters.AddWithValue("@OgrenciNumara", numara);
                    komut.Parameters.AddWithValue("@Ad", ad);
                    komut.Parameters.AddWithValue("@Soyad", soyad);
                    komut.Parameters.AddWithValue("@Devamsizlik", devamsizlik);
                    komut.Parameters.AddWithValue("@Sinif", sinif);
                    komut.Parameters.AddWithValue("@Bolum", bolum);
                    komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Öğrenci başarıyla eklendi.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }   
}

