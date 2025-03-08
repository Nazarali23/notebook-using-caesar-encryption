namespace Şifreli_not_defteri_
{
    partial class dosyaları_görme
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
            this.dosya_gösterme = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.silme = new System.Windows.Forms.Label();
            this.silmekistenendosyaismi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dosya_gösterme
            // 
            this.dosya_gösterme.AutoSize = true;
            this.dosya_gösterme.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosya_gösterme.Location = new System.Drawing.Point(62, 90);
            this.dosya_gösterme.Name = "dosya_gösterme";
            this.dosya_gösterme.Size = new System.Drawing.Size(79, 30);
            this.dosya_gösterme.TabIndex = 0;
            this.dosya_gösterme.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(58, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kaydettiğiniz dosyalarınız:";
            // 
            // silme
            // 
            this.silme.AutoSize = true;
            this.silme.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silme.Location = new System.Drawing.Point(67, 526);
            this.silme.Name = "silme";
            this.silme.Size = new System.Drawing.Size(193, 31);
            this.silme.TabIndex = 2;
            this.silme.Text = "dosyaları silme:";
            // 
            // silmekistenendosyaismi
            // 
            this.silmekistenendosyaismi.Location = new System.Drawing.Point(295, 534);
            this.silmekistenendosyaismi.MaxLength = 10;
            this.silmekistenendosyaismi.Name = "silmekistenendosyaismi";
            this.silmekistenendosyaismi.Size = new System.Drawing.Size(201, 22);
            this.silmekistenendosyaismi.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(574, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dosyaları_görme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.silmekistenendosyaismi);
            this.Controls.Add(this.silme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dosya_gösterme);
            this.Name = "dosyaları_görme";
            this.Size = new System.Drawing.Size(895, 592);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dosya_gösterme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label silme;
        private System.Windows.Forms.TextBox silmekistenendosyaismi;
        private System.Windows.Forms.Button button1;
    }
}
