using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_tabanii
{
    public partial class Form1 : Form
    {
        private int kullaniciId;
        private string kullaniciAdi;
        private string rol;

        // Yapıcı metodun parametrelerini ekliyoruz
        public Form1(int kullaniciId, string kullaniciAdi, string rol)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            this.kullaniciAdi = kullaniciAdi;
            this.rol = rol;

            // Parametrelerle ilgili işlemleri gerçekleştirebilirsiniz
        }

    // Diğer kodlar burada olacak


        

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciEkleForm frm = new OgrenciEkleForm();
            frm.ShowDialog();
        }
       

        private void button2_Click_1(object sender, EventArgs e)
        {
            OgrenciSilForm silForm = new OgrenciSilForm();
            silForm.ShowDialog();
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            OgrenciGuncelleme guncelleForm = new OgrenciGuncelleme();
            guncelleForm.ShowDialog();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            OgrenciListeleForm listeleForm = new OgrenciListeleForm();
            listeleForm.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OgrenciAramaForm aramaForm = new OgrenciAramaForm();
            aramaForm.Show();
        }

        private void btnNotGirme_Click(object sender, EventArgs e)
        {
            NotEklemeForm notEkleForm = new NotEklemeForm(kullaniciId, kullaniciAdi, rol);
            notEkleForm.Show();  // Not ekleme formunu aç
            this.Hide();  // Login formunu gizle


        }

        private void btnBilgiGirisi_Click(object sender, EventArgs e)
        { 
            BilgiGirisiFormu bilgiGirisiFormu = new BilgiGirisiFormu();
            bilgiGirisiFormu.ShowDialog();
        

        }
    }
}
