using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace Veri_tabanii
{
    public partial class NotGoruntuleForm : Form
    {
        string kullaniciAdi;
        public NotGoruntuleForm(string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi;

        }

        // Form yüklendiğinde, notları çek
        // Öğrenci ID'sine göre notları getir


        // Notları getiren metod
        private void NotGoruntuleForm_Load(object sender, EventArgs e)
        {
            dgvNotlar.AutoGenerateColumns = true;
            NotlariGetir(kullaniciAdi); // kullanıcı adıyla verileri çek
        }


        private void NotlariGetir(string kullaniciAdi)
        {
            using (SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString))
            {
                SqlCommand komut = new SqlCommand("sp_OgrenciNotlariGetir", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi); // PARAMETRE GÖNDERİLİYOR

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();

                try
                {
                    baglanti.Open();
                    da.Fill(dt);
                    dgvNotlar.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }


        // Notları gösterme butonuna tıklanınca çalışacak metod
        private void btnNotlariGoster_Click(object sender, EventArgs e)
        {

            NotGoruntuleForm notFormu = new NotGoruntuleForm(kullaniciAdi);
            notFormu.ShowDialog(); // veya .Show() kullanabilirsiniz
        }
    }
}
