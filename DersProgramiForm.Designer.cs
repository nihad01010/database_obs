namespace Veri_tabanii
{
    partial class DersProgramiForm
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
            this.dgvDersProgrami = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersProgrami)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDersProgrami
            // 
            this.dgvDersProgrami.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersProgrami.Location = new System.Drawing.Point(258, 71);
            this.dgvDersProgrami.Name = "dgvDersProgrami";
            this.dgvDersProgrami.RowHeadersWidth = 51;
            this.dgvDersProgrami.RowTemplate.Height = 24;
            this.dgvDersProgrami.Size = new System.Drawing.Size(240, 150);
            this.dgvDersProgrami.TabIndex = 0;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(303, 275);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(140, 23);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ders Programi";
            // 
            // DersProgramiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.dgvDersProgrami);
            this.Name = "DersProgramiForm";
            this.Text = "DersProgramiForm";
            this.Load += new System.EventHandler(this.DersProgramiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersProgrami)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDersProgrami;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label1;
    }
}