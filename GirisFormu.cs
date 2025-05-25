using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace Veri_tabanii
{
    public partial class GirisFormu : Form
    {
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        public GirisFormu()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                string kullaniciAdi = txtKullaniciAdi.Text;  // Kullanıcı adı
                string sifre = txtSifre.Text;  // Şifre

                if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
                {
                    MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.");
                    return;
                }

                baglanti.Open();

                // Stored Procedure kullanarak giriş yapma
                SqlCommand komut = new SqlCommand("sp_KullaniciGiris", baglanti);
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@Sifre", sifre);

                SqlDataReader reader = komut.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();  // Kullanıcıyı bul
                    int kullaniciId = Convert.ToInt32(reader["KullaniciID"]);  // Kullanıcı ID'si alınıyor
                    string rol = reader["Rol"].ToString();

                    // Kullanıcı bilgilerini bir sonraki forma taşı
                    MessageBox.Show("Giriş başarılı! Hoş geldiniz " + kullaniciAdi);

                    // Rol kontrolü
                    if (rol == "Hoca")  // Öğretmense işlemler formunu aç
                    {
                        // Hoca formunu kullaniciId, kullaniciAdi ve rol parametreleri ile açıyoruz
                        Form1 hocaForm = new Form1(kullaniciId, kullaniciAdi, rol);
                        hocaForm.Show();
                        this.Hide();  // Login formunu gizle
                    }
                    else if (rol == "Öğrenci")  // Öğrenci ise sadece notları görüntüleme formunu aç
                    {
                        // Öğrenci formunu kullaniciId parametresiyle açıyoruz
                        OgrenciAnaMenuForm anaForm = new OgrenciAnaMenuForm(kullaniciId, kullaniciAdi, rol);
                        anaForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz rol.");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        private void btnKullaniciEkle_Click_1(object sender, EventArgs e)
        {
            KullaniciEkleFormu KullaniciEkleFormu = new KullaniciEkleFormu();
            KullaniciEkleFormu.ShowDialog(); // Veya Show() ile de açılabilir
        }

    }
}