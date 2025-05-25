using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Veri_tabanii
{
    public partial class OgrenciAramaForm: Form
    {
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        public OgrenciAramaForm()
        {
            InitializeComponent();
        }
        private void btnAra_Click_1(object sender, EventArgs e)
        {

            //string aranan = txtAdArama.Text.Trim();

            //if (string.IsNullOrEmpty(aranan))
            //{
            //    MessageBox.Show("Lütfen bir arama terimi giriniz.");
            //    return;
            //}

            //try
            //{
            //    baglanti.Open();

            //    SqlCommand komut = new SqlCommand(
            //        "SELECT OgrenciNumara, Ad, Soyad FROM Ogrenciler WHERE OgrenciNumara LIKE @aranan OR Ad LIKE @aranan OR Soyad LIKE @aranan",
            //        baglanti);
            //    komut.Parameters.AddWithValue("@aranan", "%" + aranan + "%");

            //    SqlDataAdapter da = new SqlDataAdapter(komut);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);

            //    dataGridView1.DataSource = dt;

            //    baglanti.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Hata: " + ex.Message);
            //    baglanti.Close();
            //}

            try
            {
                string ogrenciNumara = txtArama.Text.Trim();
                string ad = txtAdArama.Text.Trim();  // Ad için bir TextBox (opsiyonel)
                string soyad = txtSoyadArama.Text.Trim();  // Soyad için bir TextBox (opsiyonel)

                using (SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString))
                {
                    // Stored procedureyi çalıştıracak komut
                    SqlCommand komut = new SqlCommand("sp_OgrenciAra", baglanti);
                    komut.CommandType = CommandType.StoredProcedure;

                    // Parametreler
                    komut.Parameters.AddWithValue("@OgrenciNumara", string.IsNullOrEmpty(ogrenciNumara) ? (object)DBNull.Value : ogrenciNumara);
                    komut.Parameters.AddWithValue("@Ad", string.IsNullOrEmpty(ad) ? (object)DBNull.Value : ad);
                    komut.Parameters.AddWithValue("@Soyad", string.IsNullOrEmpty(soyad) ? (object)DBNull.Value : soyad);

                    // Bağlantıyı aç
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // Verileri DataTable'a çek

                    // DataGridView'e veriyi bağla
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        
    }
}
