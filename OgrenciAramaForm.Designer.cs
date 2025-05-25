namespace Veri_tabanii
{
    partial class OgrenciAramaForm
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
            this.txtAdArama = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSoyadArama = new System.Windows.Forms.TextBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdArama
            // 
            this.txtAdArama.Location = new System.Drawing.Point(427, 194);
            this.txtAdArama.Name = "txtAdArama";
            this.txtAdArama.Size = new System.Drawing.Size(209, 22);
            this.txtAdArama.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(451, 286);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(144, 32);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(117, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(304, 179);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtSoyadArama
            // 
            this.txtSoyadArama.Location = new System.Drawing.Point(427, 240);
            this.txtSoyadArama.Name = "txtSoyadArama";
            this.txtSoyadArama.Size = new System.Drawing.Size(209, 22);
            this.txtSoyadArama.TabIndex = 3;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(427, 148);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(209, 22);
            this.txtArama.TabIndex = 4;
            // 
            // OgrenciAramaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.txtSoyadArama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAdArama);
            this.Name = "OgrenciAramaForm";
            this.Text = "OgrenciAramaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSoyadArama;
        private System.Windows.Forms.TextBox txtArama;
    }
}