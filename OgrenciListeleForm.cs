using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Threading.Tasks;

namespace Veri_tabanii
{
    public partial class OgrenciListeleForm : Form
    {
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        public OgrenciListeleForm()
        {
            InitializeComponent();
             // Form load olayına bağlıyoruz
        }

        private void OgrenciListeleForm_Load_1(object sender, EventArgs e)
        {
            ListeleOgrenciler();
        }

        private async void ListeleOgrenciler()
        {
            //try
            //{
            //    DataTable dt = await Task.Run(() =>
            //    {
            //        using (SqlConnection localBaglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString))
            //        {
            //            localBaglanti.Open();

            //            SqlDataAdapter da = new SqlDataAdapter("SELECT OgrenciNumara, Ad, Soyad FROM Ogrenciler", localBaglanti);
            //            DataTable tempDt = new DataTable();
            //            da.Fill(tempDt);

            //            return tempDt;
            //        }
            //    });

            //    // UI iş parçacığında DataGridView'e veri bağlama
            //    dataGridView1.DataSource = dt;
            //    dataGridView1.Refresh();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Hata: " + ex.Message);
            //}
            try
            {
                using (SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString))
                {
                    await baglanti.OpenAsync(); // Asynchronous connection opening

                    // Stored procedureyi çalıştıracak komut
                    SqlCommand komut = new SqlCommand("sp_OgrenciListele", baglanti);
                    komut.CommandType = CommandType.StoredProcedure;

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