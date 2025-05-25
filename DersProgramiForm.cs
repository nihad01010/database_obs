using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veri_tabanii
{
    public partial class DersProgramiForm : Form
    {
        private int ogrenciId;

        public DersProgramiForm(int ogrenciId)
        {
            InitializeComponent();
            this.ogrenciId = ogrenciId;
        }

        private void DersProgramiForm_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            SqlCommand komut = new SqlCommand("sp_OgrenciDersProgramiGetir", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@OgrenciID", ogrenciId);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            try
            {
                baglanti.Open();
                da.Fill(dt);
                dgvDersProgrami.DataSource = dt;
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
    }
}
