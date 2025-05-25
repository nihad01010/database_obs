using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace Veri_tabanii
{
    public partial class OgrenciSilForm : Form
    {
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        public OgrenciSilForm()
        {
            InitializeComponent();
            btnSil.Click += btnSil_Click; // Butonun Click olayını burada bağlıyoruz
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            string numara = txtNumara.Text.Trim();

            if (string.IsNullOrEmpty(numara))
            {
                MessageBox.Show("Lütfen silinecek öğrencinin numarasını girin.");
                return;
            }

            try
            {
                using (SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString))
                {
                    SqlCommand komut = new SqlCommand("sp_OgrenciSil", baglanti);
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@OgrenciNumara", numara);

                    baglanti.Open();
                    int sonuc = komut.ExecuteNonQuery();
                    baglanti.Close();

                    if (sonuc > 0)
                        MessageBox.Show("Öğrenci başarıyla silindi.");
                    else
                        MessageBox.Show("Böyle bir öğrenci bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        
    }
}
