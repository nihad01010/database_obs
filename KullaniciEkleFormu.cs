using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Veri_tabanii
{
    public partial class KullaniciEkleFormu : Form
    {
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        public KullaniciEkleFormu()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string rol = cmbRol.SelectedItem?.ToString();
            string ad = txtAd.Text.Trim();       // Yeni TextBox: txtAd
            string soyad = txtSoyad.Text.Trim(); // Yeni TextBox: txtSoyad

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(rol) || string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad))
            {
                MessageBox.Show("Tüm alanları doldurmalısınız.");
                return;
            }

            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("sp_KullaniciEkle", baglanti);
                komut.CommandType = System.Data.CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@Sifre", sifre);
                komut.Parameters.AddWithValue("@Rol", rol);
                komut.Parameters.AddWithValue("@Ad", ad);
                komut.Parameters.AddWithValue("@Soyad", soyad);

                int sonuc = komut.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    MessageBox.Show("Kullanıcı başarıyla eklendi.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı eklenemedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KullaniciEkleFormu_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Add("Öğrenci");
            cmbRol.Items.Add("Hoca");
            cmbRol.SelectedIndex = 0;
        }
    }
}
