using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şifreli_not_defteri_
{
    public partial class dosyaları_görme : UserControl
    {
        public dosyaları_görme()
        {
            InitializeComponent();
            string klasör_ismi = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "notlar.txt");           
            DateTime tumtarih = DateTime.Now;
            string tarih = tumtarih.ToShortDateString();
            string saat = tumtarih.ToLongTimeString();
            string dosya_ismi = (klasör_ismi + "\\" + tarih + ".txt");
            if (!Directory.Exists(klasör_ismi))
            {
                Directory.CreateDirectory(klasör_ismi);
            }
            string[] dosyalar = Directory.GetFiles(klasör_ismi);
            string dosyalarım = "";
            foreach (string dosya in dosyalar)
            {
              dosyalarım += (Path.GetFileName(dosya)+"\n");
            }
            dosya_gösterme.Text = dosyalarım;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string klasör_ismi = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "notlar.txt");
            DateTime tumtarih = DateTime.Now;
            string tarih = tumtarih.ToShortDateString();
            string saat = tumtarih.ToLongTimeString();  
            if (string.IsNullOrEmpty(silmekistenendosyaismi.Text))
            {
                MessageBox.Show("lütfen silmek istediğiniz dosya ismini giriniz!"); return;
            }
            string dosya_ismi = Path.Combine(klasör_ismi,silmekistenendosyaismi.Text + ".txt");
            string[] dosyalar = Directory.GetFiles(klasör_ismi);
            string dosyalarım = "";
            if (dosyalar.Any(d => string.Equals(Path.GetFileNameWithoutExtension(d), silmekistenendosyaismi.Text, StringComparison.OrdinalIgnoreCase)))
            {
                DialogResult result = MessageBox.Show("silmek istediğinizden emin misiniz?", "Evet-Hayır", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string[] böl = dosya_gösterme.Text.Split('\n');
                    for (int i = 0; i < böl.Length; i++)
                    {
                        if (böl[i] == silmekistenendosyaismi.Text)
                        {
                            File.Delete(dosya_ismi);
                            MessageBox.Show("Dosya başarıyla silindi!");
                        }
                    }
                    dosya_gösterme.Text = "";
                    foreach (string dosya in dosyalar)
                    {
                        dosyalarım += (Path.GetFileName(dosya) + "\n");
                    }
                    dosya_gösterme.Text = dosyalarım;
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Dosyanız silinmedi!");
                }
            } else { MessageBox.Show("silmek istediğiniz dosya bulunamadı, lütfen tekrar deneyiniz!"); }
        }
    }
}
