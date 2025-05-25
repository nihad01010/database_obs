using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veri_tabanii
{
    public partial class OgrenciAnaMenuForm: Form
    {
        string kullaniciAdi;
        string rol;
        int kullaniciId;
        public OgrenciAnaMenuForm(int kullaniciId, string kullaniciAdi, string rol)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi;
            this.rol = rol;
            this.kullaniciId = kullaniciId;
        }

        
        private void btnBilgilerim_Click(object sender, EventArgs e)
        {
            OgrenciBilgiForm bilgilerForm = new OgrenciBilgiForm(kullaniciId);
            bilgilerForm.ShowDialog();
        }

       
       

        private void btnNotlarim_Click(object sender, EventArgs e)
        {
            NotGoruntuleForm notlarForm = new NotGoruntuleForm(kullaniciAdi);
            notlarForm.ShowDialog();
        }

        private void btnDersProgrami_Click(object sender, EventArgs e)
        {
            DersProgramiForm form = new DersProgramiForm(GlobalVariables.OgrenciId); // öğrenci id global değişkenden alınabilir
            form.Show();
        }
    }
}
