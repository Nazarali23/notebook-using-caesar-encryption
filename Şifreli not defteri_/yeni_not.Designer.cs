namespace Şifreli_not_defteri_
{
    partial class yeni_not
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.kullanici_notu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kaydetme_butonu = new System.Windows.Forms.Button();
            this.şifreleme_anahtarı = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kullanici_notu
            // 
            this.kullanici_notu.AcceptsReturn = true;
            this.kullanici_notu.AcceptsTab = true;
            this.kullanici_notu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.kullanici_notu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kullanici_notu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_notu.Location = new System.Drawing.Point(26, 82);
            this.kullanici_notu.MaxLength = 5000;
            this.kullanici_notu.Multiline = true;
            this.kullanici_notu.Name = "kullanici_notu";
            this.kullanici_notu.Size = new System.Drawing.Size(829, 413);
            this.kullanici_notu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "saat başlığnı görmek \r\n     için tıklayınız";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "notunuz şu saat başlığı\r\naltında kaydedilecektir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "Notunuzu aşağıya giriniz:";
            // 
            // kaydetme_butonu
            // 
            this.kaydetme_butonu.BackColor = System.Drawing.Color.Teal;
            this.kaydetme_butonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kaydetme_butonu.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetme_butonu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kaydetme_butonu.Location = new System.Drawing.Point(641, 501);
            this.kaydetme_butonu.Name = "kaydetme_butonu";
            this.kaydetme_butonu.Size = new System.Drawing.Size(214, 71);
            this.kaydetme_butonu.TabIndex = 4;
            this.kaydetme_butonu.Text = "Kaydet";
            this.kaydetme_butonu.UseVisualStyleBackColor = false;
            this.kaydetme_butonu.Click += new System.EventHandler(this.kaydetme_butonu_Click);
            // 
            // şifreleme_anahtarı
            // 
            this.şifreleme_anahtarı.Location = new System.Drawing.Point(808, 46);
            this.şifreleme_anahtarı.MaxLength = 99;
            this.şifreleme_anahtarı.Name = "şifreleme_anahtarı";
            this.şifreleme_anahtarı.Size = new System.Drawing.Size(47, 22);
            this.şifreleme_anahtarı.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(643, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "şifreleme anahtarı:";
            // 
            // yeni_not
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.şifreleme_anahtarı);
            this.Controls.Add(this.kaydetme_butonu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullanici_notu);
            this.Name = "yeni_not";
            this.Size = new System.Drawing.Size(895, 592);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullanici_notu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kaydetme_butonu;
        private System.Windows.Forms.TextBox şifreleme_anahtarı;
        private System.Windows.Forms.Label label4;
    }
}
