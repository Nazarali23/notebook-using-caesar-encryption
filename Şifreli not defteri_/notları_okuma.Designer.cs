namespace Şifreli_not_defteri_
{
    partial class notları_okuma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.not_ismi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.çözülmüş_notpaneli = new System.Windows.Forms.Panel();
            this.anahtarsayi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tamam_çöz = new System.Windows.Forms.Button();
            this.çözülmüş_notpaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(769, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifresini çözmek istediğiniz not ismini giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Örnek: \"1.01.2024\"";
            // 
            // not_ismi
            // 
            this.not_ismi.Location = new System.Drawing.Point(274, 142);
            this.not_ismi.Name = "not_ismi";
            this.not_ismi.Size = new System.Drawing.Size(300, 22);
            this.not_ismi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.MaximumSize = new System.Drawing.Size(796, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "notlarınız:";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // çözülmüş_notpaneli
            // 
            this.çözülmüş_notpaneli.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.çözülmüş_notpaneli.Controls.Add(this.label3);
            this.çözülmüş_notpaneli.Location = new System.Drawing.Point(43, 181);
            this.çözülmüş_notpaneli.Name = "çözülmüş_notpaneli";
            this.çözülmüş_notpaneli.Size = new System.Drawing.Size(852, 476);
            this.çözülmüş_notpaneli.TabIndex = 4;
            // 
            // anahtarsayi
            // 
            this.anahtarsayi.Location = new System.Drawing.Point(597, 142);
            this.anahtarsayi.MaxLength = 99;
            this.anahtarsayi.Name = "anahtarsayi";
            this.anahtarsayi.Size = new System.Drawing.Size(83, 22);
            this.anahtarsayi.TabIndex = 6;
            this.anahtarsayi.TextChanged += new System.EventHandler(this.anahtarsayi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(562, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Anahtar sayı";
            // 
            // tamam_çöz
            // 
            this.tamam_çöz.BackColor = System.Drawing.Color.Teal;
            this.tamam_çöz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tamam_çöz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tamam_çöz.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tamam_çöz.Location = new System.Drawing.Point(701, 116);
            this.tamam_çöz.Name = "tamam_çöz";
            this.tamam_çöz.Size = new System.Drawing.Size(138, 48);
            this.tamam_çöz.TabIndex = 5;
            this.tamam_çöz.Text = "tamam";
            this.tamam_çöz.UseVisualStyleBackColor = false;
            this.tamam_çöz.Click += new System.EventHandler(this.tamam_çöz_Click);
            // 
            // notları_okuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.anahtarsayi);
            this.Controls.Add(this.tamam_çöz);
            this.Controls.Add(this.çözülmüş_notpaneli);
            this.Controls.Add(this.not_ismi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "notları_okuma";
            this.Size = new System.Drawing.Size(895, 592);
            this.çözülmüş_notpaneli.ResumeLayout(false);
            this.çözülmüş_notpaneli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox not_ismi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel çözülmüş_notpaneli;
        private System.Windows.Forms.Button tamam_çöz;
        private System.Windows.Forms.TextBox anahtarsayi;
        private System.Windows.Forms.Label label4;
    }
}
