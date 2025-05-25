using System.Configuration;
using System.Data.SqlClient;
using System.Data;

using System.Windows.Forms;
using System;

namespace Veri_tabanii
{
    public partial class NotEklemeForm : Form
    {
        private int kullaniciId;
        private string kullaniciAdi;
        private string rol;
        public NotEklemeForm(int kullaniciId, string kullaniciAdi, string rol)
        {
            this.kullaniciId = kullaniciId;
            this.kullaniciAdi = kullaniciAdi;
            this.rol = rol;
            InitializeComponent();
        }

       
        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

            //    string numara = txtNumara.Text.Trim();
            //    string ders = txtDers.Text.Trim();
            //    int vize, final;

            //    if (!int.TryParse(txtVize.Text, out vize) || !int.TryParse(txtFinal.Text, out final))
            //    {
            //        MessageBox.Show("Lütfen geçerli vize ve final notu giriniz.");
            //        return;
            //    }

            //    if (string.IsNullOrWhiteSpace(numara) || string.IsNullOrWhiteSpace(ders))
            //    {
            //        MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            //        return;
            //    }

            //    try
            //    {
            //        baglanti.Open();

            //        // Öğrenci numarasından ID'yi al
            //        SqlCommand idBulKomut = new SqlCommand(
            //            "SELECT OgrenciId FROM Ogrenciler WHERE OgrenciNumara = @numara", baglanti);
            //        idBulKomut.Parameters.AddWithValue("@numara", numara);

            //        object ogrenciIdObj = idBulKomut.ExecuteScalar();

            //        if (ogrenciIdObj == null)
            //        {
            //            MessageBox.Show("Girilen öğrenci numarası bulunamadı.");
            //            baglanti.Close();
            //            return;
            //        }

            //        int ogrenciId = Convert.ToInt32(ogrenciIdObj);

            //        // Not ekleme işlemi
            //        SqlCommand komut = new SqlCommand(
            //            "INSERT INTO Notlar (OgrenciId, DersAdi, Vize, Final) VALUES (@ogrenciId, @ders, @vize, @final)",
            //            baglanti);
            //        komut.Parameters.AddWithValue("@ogrenciId", ogrenciId);
            //        komut.Parameters.AddWithValue("@ders", ders);
            //        komut.Parameters.AddWithValue("@vize", vize);
            //        komut.Parameters.AddWithValue("@final", final);
            //        komut.ExecuteNonQuery();

            //        baglanti.Close();

            //        MessageBox.Show("Not başarıyla kaydedildi.");
            //        this.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Hata: " + ex.Message);
            //        baglanti.Close();
            //    }

            try
            {
                string ogrenciNumara = txtNumara.Text;
                string dersAdi = txtDers.Text;
                int vize = Convert.ToInt32(txtVize.Text);
                int final = Convert.ToInt32(txtFinal.Text);

                int kullaniciId = 1;
                string kullaniciAdi = "Admin";

                baglanti.Open();

                SqlCommand komut = new SqlCommand("sp_NotEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@OgrenciID", ogrenciNumara);
                komut.Parameters.AddWithValue("@DersAdi", dersAdi);
                komut.Parameters.AddWithValue("@Vize", vize);
                komut.Parameters.AddWithValue("@Final", final);
                komut.Parameters.AddWithValue("@KullaniciID", kullaniciId);
                komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                // Prosedürü çalıştır
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Not başarıyla kaydedildi.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }
    }
}
