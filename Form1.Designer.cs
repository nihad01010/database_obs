namespace Veri_tabanii
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.btnGuncelleme = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnNotGirme = new System.Windows.Forms.Button();
            this.btnBilgiGirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(325, 34);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(197, 27);
            this.EkleBtn.TabIndex = 0;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuncelleme
            // 
            this.btnGuncelleme.Location = new System.Drawing.Point(325, 124);
            this.btnGuncelleme.Name = "btnGuncelleme";
            this.btnGuncelleme.Size = new System.Drawing.Size(197, 28);
            this.btnGuncelleme.TabIndex = 2;
            this.btnGuncelleme.Text = "Guncelle";
            this.btnGuncelleme.UseVisualStyleBackColor = true;
            this.btnGuncelleme.Click += new System.EventHandler(this.btnGuncelleme_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(325, 169);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(197, 31);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "Listeleme";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(325, 214);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(197, 31);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Arama";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnNotGirme
            // 
            this.btnNotGirme.Location = new System.Drawing.Point(325, 259);
            this.btnNotGirme.Name = "btnNotGirme";
            this.btnNotGirme.Size = new System.Drawing.Size(197, 31);
            this.btnNotGirme.TabIndex = 5;
            this.btnNotGirme.Text = "Not Girme";
            this.btnNotGirme.UseVisualStyleBackColor = true;
            this.btnNotGirme.Click += new System.EventHandler(this.btnNotGirme_Click);
            // 
            // btnBilgiGirisi
            // 
            this.btnBilgiGirisi.Location = new System.Drawing.Point(325, 307);
            this.btnBilgiGirisi.Name = "btnBilgiGirisi";
            this.btnBilgiGirisi.Size = new System.Drawing.Size(197, 32);
            this.btnBilgiGirisi.TabIndex = 6;
            this.btnBilgiGirisi.Text = "Bilgi gir";
            this.btnBilgiGirisi.UseVisualStyleBackColor = true;
            this.btnBilgiGirisi.Click += new System.EventHandler(this.btnBilgiGirisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBilgiGirisi);
            this.Controls.Add(this.btnNotGirme);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelleme);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EkleBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.Button btnGuncelleme;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnNotGirme;
        private System.Windows.Forms.Button btnBilgiGirisi;
    }
}

