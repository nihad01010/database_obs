namespace Veri_tabanii
{
    partial class OgrenciAnaMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBilgilerim = new System.Windows.Forms.Button();
            this.btnNotlarim = new System.Windows.Forms.Button();
            this.btnDersProgrami = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBilgilerim
            // 
            this.btnBilgilerim.Location = new System.Drawing.Point(292, 114);
            this.btnBilgilerim.Name = "btnBilgilerim";
            this.btnBilgilerim.Size = new System.Drawing.Size(184, 42);
            this.btnBilgilerim.TabIndex = 0;
            this.btnBilgilerim.Text = "Bilgilerim";
            this.btnBilgilerim.UseVisualStyleBackColor = true;
            this.btnBilgilerim.Click += new System.EventHandler(this.btnBilgilerim_Click);
            // 
            // btnNotlarim
            // 
            this.btnNotlarim.Location = new System.Drawing.Point(292, 176);
            this.btnNotlarim.Name = "btnNotlarim";
            this.btnNotlarim.Size = new System.Drawing.Size(184, 39);
            this.btnNotlarim.TabIndex = 1;
            this.btnNotlarim.Text = "Notlarim";
            this.btnNotlarim.UseVisualStyleBackColor = true;
            this.btnNotlarim.Click += new System.EventHandler(this.btnNotlarim_Click);
            // 
            // btnDersProgrami
            // 
            this.btnDersProgrami.Location = new System.Drawing.Point(292, 241);
            this.btnDersProgrami.Name = "btnDersProgrami";
            this.btnDersProgrami.Size = new System.Drawing.Size(184, 41);
            this.btnDersProgrami.TabIndex = 2;
            this.btnDersProgrami.Text = "Ders Programi";
            this.btnDersProgrami.UseVisualStyleBackColor = true;
            this.btnDersProgrami.Click += new System.EventHandler(this.btnDersProgrami_Click);
            // 
            // OgrenciAnaMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDersProgrami);
            this.Controls.Add(this.btnNotlarim);
            this.Controls.Add(this.btnBilgilerim);
            this.Name = "OgrenciAnaMenuForm";
            this.Text = "Ogrenci Ana Menusu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBilgilerim;
        private System.Windows.Forms.Button btnNotlarim;
        private System.Windows.Forms.Button btnDersProgrami;
    }
}