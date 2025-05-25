using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_tabanii
{
    public partial class OgrenciBilgiForm : Form
    {
        private int ogrenciId;
        public OgrenciBilgiForm(int ogrenciId)
        {
            InitializeComponent();
            this.ogrenciId = ogrenciId;

            // DataGridView'e verileri yükle
            LoadOgrenciBilgileri(ogrenciId);
        }

        private void LoadOgrenciBilgileri(int ogrenciId)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString;
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("sp_OgrenciBilgileri", baglanti);
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@OgrenciId", ogrenciId);

                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Verileri DataGridView'e aktar
                    dataGridView1.DataSource = dt;

                    // Eğer sadece tek bir öğrenci bilgisi gösterilecekse, ilk satırı seçebilirsiniz
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.Rows[0].Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

    }
}

