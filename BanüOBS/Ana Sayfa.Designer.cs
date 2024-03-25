namespace BanüOBS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ogrenciEkle = new System.Windows.Forms.Button();
            this.ogrenciDuzenle = new System.Windows.Forms.Button();
            this.ogrenciListele = new System.Windows.Forms.Button();
            this.ogrenciSil = new System.Windows.Forms.Button();
            this.cikisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenciEkle
            // 
            this.ogrenciEkle.Location = new System.Drawing.Point(18, 217);
            this.ogrenciEkle.Name = "ogrenciEkle";
            this.ogrenciEkle.Size = new System.Drawing.Size(130, 61);
            this.ogrenciEkle.TabIndex = 0;
            this.ogrenciEkle.Text = "Öğrenci Ekle";
            this.ogrenciEkle.UseVisualStyleBackColor = true;
            this.ogrenciEkle.Click += new System.EventHandler(this.ogrenciEkle_Click);
            // 
            // ogrenciDuzenle
            // 
            this.ogrenciDuzenle.Location = new System.Drawing.Point(165, 217);
            this.ogrenciDuzenle.Name = "ogrenciDuzenle";
            this.ogrenciDuzenle.Size = new System.Drawing.Size(130, 61);
            this.ogrenciDuzenle.TabIndex = 1;
            this.ogrenciDuzenle.Text = "Öğrenci Düzenle";
            this.ogrenciDuzenle.UseVisualStyleBackColor = true;
            this.ogrenciDuzenle.Click += new System.EventHandler(this.ogrenciDuzenle_Click);
            // 
            // ogrenciListele
            // 
            this.ogrenciListele.Location = new System.Drawing.Point(312, 217);
            this.ogrenciListele.Name = "ogrenciListele";
            this.ogrenciListele.Size = new System.Drawing.Size(130, 61);
            this.ogrenciListele.TabIndex = 2;
            this.ogrenciListele.Text = "Öğrenci Listele";
            this.ogrenciListele.UseVisualStyleBackColor = true;
            this.ogrenciListele.Click += new System.EventHandler(this.ogrenciListele_Click);
            // 
            // ogrenciSil
            // 
            this.ogrenciSil.Location = new System.Drawing.Point(463, 217);
            this.ogrenciSil.Name = "ogrenciSil";
            this.ogrenciSil.Size = new System.Drawing.Size(130, 61);
            this.ogrenciSil.TabIndex = 3;
            this.ogrenciSil.Text = "Öğrenci Sil";
            this.ogrenciSil.UseVisualStyleBackColor = true;
            this.ogrenciSil.Click += new System.EventHandler(this.ogrenciSil_Click);
            // 
            // cikisYap
            // 
            this.cikisYap.Location = new System.Drawing.Point(611, 217);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(130, 61);
            this.cikisYap.TabIndex = 4;
            this.cikisYap.Text = "Çıkış Yap";
            this.cikisYap.UseVisualStyleBackColor = true;
            this.cikisYap.Click += new System.EventHandler(this.cikisYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bandırma Onyedi Eylül Üniversitesi Öğrenci Bilgi Sistemi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 319);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.ogrenciSil);
            this.Controls.Add(this.ogrenciListele);
            this.Controls.Add(this.ogrenciDuzenle);
            this.Controls.Add(this.ogrenciEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Bandırma Onyedi Eylül Üniversitesi Öğrenci Bilgi Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ogrenciEkle;
        private System.Windows.Forms.Button ogrenciDuzenle;
        private System.Windows.Forms.Button ogrenciListele;
        private System.Windows.Forms.Button ogrenciSil;
        private System.Windows.Forms.Button cikisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

