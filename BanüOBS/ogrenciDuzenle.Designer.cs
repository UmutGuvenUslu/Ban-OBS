namespace BanüOBS
{
    partial class ogrenciDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciDuzenle));
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.NumaraSorgulayıcıTextBox = new System.Windows.Forms.TextBox();
            this.ogrenciEkleButton = new System.Windows.Forms.Button();
            this.ogrenciOkuduguBolumList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BilgiDegistirTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 35;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(64, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Öğrencinin Numarası";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumaraSorgulayıcıTextBox
            // 
            this.NumaraSorgulayıcıTextBox.Location = new System.Drawing.Point(21, 180);
            this.NumaraSorgulayıcıTextBox.Name = "NumaraSorgulayıcıTextBox";
            this.NumaraSorgulayıcıTextBox.Size = new System.Drawing.Size(201, 20);
            this.NumaraSorgulayıcıTextBox.TabIndex = 33;
            // 
            // ogrenciEkleButton
            // 
            this.ogrenciEkleButton.Location = new System.Drawing.Point(21, 327);
            this.ogrenciEkleButton.Name = "ogrenciEkleButton";
            this.ogrenciEkleButton.Size = new System.Drawing.Size(110, 28);
            this.ogrenciEkleButton.TabIndex = 32;
            this.ogrenciEkleButton.Text = "Öğrenciyi Düzenle";
            this.ogrenciEkleButton.UseVisualStyleBackColor = true;
            this.ogrenciEkleButton.Click += new System.EventHandler(this.ogrenciEkleButton_Click);
            // 
            // ogrenciOkuduguBolumList
            // 
            this.ogrenciOkuduguBolumList.FormattingEnabled = true;
            this.ogrenciOkuduguBolumList.Items.AddRange(new object[] {
            "Öğrenci Adı",
            "Öğrenci Soyadı",
            "Öğrenci Vize Notu",
            "Öğrenci Final Notu"});
            this.ogrenciOkuduguBolumList.Location = new System.Drawing.Point(21, 234);
            this.ogrenciOkuduguBolumList.Name = "ogrenciOkuduguBolumList";
            this.ogrenciOkuduguBolumList.Size = new System.Drawing.Size(201, 21);
            this.ogrenciOkuduguBolumList.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(47, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Değiştirilecek Bilgiyi Giriniz";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BilgiDegistirTextBox
            // 
            this.BilgiDegistirTextBox.Location = new System.Drawing.Point(21, 289);
            this.BilgiDegistirTextBox.Name = "BilgiDegistirTextBox";
            this.BilgiDegistirTextBox.Size = new System.Drawing.Size(201, 20);
            this.BilgiDegistirTextBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Değiştirilecek Bilgiyi Seçiniz";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ogrenciDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 375);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumaraSorgulayıcıTextBox);
            this.Controls.Add(this.ogrenciEkleButton);
            this.Controls.Add(this.ogrenciOkuduguBolumList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BilgiDegistirTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ogrenciDuzenle";
            this.ShowIcon = false;
            this.Text = "Öğrenci Düzenle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NumaraSorgulayıcıTextBox;
        private System.Windows.Forms.Button ogrenciEkleButton;
        private System.Windows.Forms.ComboBox ogrenciOkuduguBolumList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BilgiDegistirTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}