namespace Şifreli_not_defteri_
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
            this.menu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dosyaları_göster = new System.Windows.Forms.Button();
            this.not_okuma = new System.Windows.Forms.Button();
            this.not_oluştur = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.yeni_not1 = new Şifreli_not_defteri_.yeni_not();
            this.notları_okuma1 = new Şifreli_not_defteri_.notları_okuma();
            this.dosyaları_görme1 = new Şifreli_not_defteri_.dosyaları_görme();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Turquoise;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.Controls.Add(this.label2);
            this.menu.Controls.Add(this.dosyaları_göster);
            this.menu.Controls.Add(this.not_okuma);
            this.menu.Controls.Add(this.not_oluştur);
            this.menu.Location = new System.Drawing.Point(30, 27);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(346, 592);
            this.menu.TabIndex = 0;
            this.menu.Paint += new System.Windows.Forms.PaintEventHandler(this.menu_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(104, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 52);
            this.label2.TabIndex = 3;
            this.label2.Text = "Menu";
            // 
            // dosyaları_göster
            // 
            this.dosyaları_göster.BackColor = System.Drawing.Color.Teal;
            this.dosyaları_göster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dosyaları_göster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dosyaları_göster.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyaları_göster.Location = new System.Drawing.Point(29, 450);
            this.dosyaları_göster.Name = "dosyaları_göster";
            this.dosyaları_göster.Size = new System.Drawing.Size(288, 91);
            this.dosyaları_göster.TabIndex = 2;
            this.dosyaları_göster.Text = "Notlarınız";
            this.dosyaları_göster.UseVisualStyleBackColor = false;
            this.dosyaları_göster.Click += new System.EventHandler(this.dosyaları_göster_Click);
            // 
            // not_okuma
            // 
            this.not_okuma.BackColor = System.Drawing.Color.Teal;
            this.not_okuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.not_okuma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.not_okuma.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.not_okuma.Location = new System.Drawing.Point(29, 306);
            this.not_okuma.Name = "not_okuma";
            this.not_okuma.Size = new System.Drawing.Size(288, 91);
            this.not_okuma.TabIndex = 1;
            this.not_okuma.Text = "Şifreli notları oku";
            this.not_okuma.UseVisualStyleBackColor = false;
            this.not_okuma.Click += new System.EventHandler(this.not_okuma_Click);
            // 
            // not_oluştur
            // 
            this.not_oluştur.BackColor = System.Drawing.Color.Teal;
            this.not_oluştur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.not_oluştur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.not_oluştur.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.not_oluştur.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.not_oluştur.Location = new System.Drawing.Point(29, 163);
            this.not_oluştur.Name = "not_oluştur";
            this.not_oluştur.Size = new System.Drawing.Size(288, 91);
            this.not_oluştur.TabIndex = 0;
            this.not_oluştur.Text = "Yeni not oluştur";
            this.not_oluştur.UseVisualStyleBackColor = false;
            this.not_oluştur.Click += new System.EventHandler(this.not_oluştur_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.yeni_not1);
            this.panel1.Controls.Add(this.notları_okuma1);
            this.panel1.Controls.Add(this.dosyaları_görme1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(399, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 592);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(815, 156);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notlarınızın gizliliğini \r\n       koruyoruz!";
            // 
            // yeni_not1
            // 
            this.yeni_not1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.yeni_not1.Location = new System.Drawing.Point(-5, 3);
            this.yeni_not1.Name = "yeni_not1";
            this.yeni_not1.Size = new System.Drawing.Size(895, 592);
            this.yeni_not1.TabIndex = 3;
            // 
            // notları_okuma1
            // 
            this.notları_okuma1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.notları_okuma1.Location = new System.Drawing.Point(-5, 3);
            this.notları_okuma1.Name = "notları_okuma1";
            this.notları_okuma1.Size = new System.Drawing.Size(895, 592);
            this.notları_okuma1.TabIndex = 2;
            // 
            // dosyaları_görme1
            // 
            this.dosyaları_görme1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.dosyaları_görme1.Location = new System.Drawing.Point(3, -1);
            this.dosyaları_görme1.Name = "dosyaları_görme1";
            this.dosyaları_görme1.Size = new System.Drawing.Size(895, 592);
            this.dosyaları_görme1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Şifreli_not_defteri_.Properties.Resources.WhatsApp_Görsel_2024_01_01_saat_12_41_08_2879b07d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Şifreli Günlük";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button dosyaları_göster;
        private System.Windows.Forms.Button not_okuma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button not_oluştur;
        private System.Windows.Forms.Label label2;
        private notları_okuma notları_okuma1;
        private dosyaları_görme dosyaları_görme1;
        private yeni_not yeni_not1;
    }
}

