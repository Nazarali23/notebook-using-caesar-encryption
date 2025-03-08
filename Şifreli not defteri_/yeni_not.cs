using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şifreli_not_defteri_
{
    public partial class yeni_not : UserControl
    {
        public yeni_not()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DateTime tumzaman = DateTime.Now;
            string saat = tumzaman.ToLongTimeString();
            MessageBox.Show(saat);
        }

        private void kaydetme_butonu_Click(object sender, EventArgs e)
        {
            string klasör_ismi = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "notlar.txt") ;
            DateTime tumtarih = DateTime.Now;
            string tarih = tumtarih.ToShortDateString();
            string saat = tumtarih.ToLongTimeString();
            string dosya_ismi = (klasör_ismi + "\\" + tarih + ".txt");
            try
            {
            int anahtar = Convert.ToInt32(şifreleme_anahtarı.Text);
                if (!Directory.Exists(klasör_ismi))
                {
                    Directory.CreateDirectory(klasör_ismi);
                    File.Create(dosya_ismi).Close();
                    MessageBox.Show("dosya oluşturuldu! devam etmek için \" tamam \" butonunu tıklayınız ");

                    string not = saat + " \n " + kullanici_notu.Text;
                    if (kullanici_notu.Text != null)
                    {
                        string şifreli_metin = "";
                        for (int i = 0; i < not.Length; i++)
                        {
                            int binary_kodu = Convert.ToInt32(not[i]);
                            int gecici = binary_kodu + anahtar;
                            char tekrar_metin = (char)gecici;
                            şifreli_metin += tekrar_metin;
                        }
                        string şifrelenmiş_metin = şifreli_metin;
                        MessageBox.Show("metin şifreleniyor lütfen bekleyin!" );Thread.Sleep(2000);
                        bool varmı = File.Exists(dosya_ismi);
                        if (varmı == true)
                        {
                            File.AppendAllText(dosya_ismi, şifrelenmiş_metin);
                            MessageBox.Show($"{tarih} tarihinde saat {saat}'de yazdığnız not başarıyla kaydedilmiştir!");
                            kullanici_notu.Text = "";
                        }
                        else
                        {
                            File.Create(dosya_ismi).Close();
                            File.AppendAllText(dosya_ismi, şifrelenmiş_metin);
                        }
                    }
                    else { MessageBox.Show("kaydedilecek not bulunamadı, lütfen notunuzu giriniz!"); }
                }
                else
                {
                    string not = saat + " \n " + kullanici_notu.Text;
                    string şifreli_metin = "";
                    for (int i = 0; i < not.Length; i++)
                    {
                        int binary_kodu = Convert.ToInt32(not[i]);
                        int gecici = binary_kodu + anahtar;
                        char tekrar_metin = (char)gecici;
                        şifreli_metin += tekrar_metin;
                    }
                    string şifrelenmiş_metin = şifreli_metin;
                    MessageBox.Show("metin şifreleniyor lütfen bekleyin!"); Thread.Sleep(2000);
                    bool varmı = File.Exists(dosya_ismi);
                    if (varmı == true)
                    {
                        File.AppendAllText(dosya_ismi, şifrelenmiş_metin);
                        MessageBox.Show($"{tarih} tarihinde saat {saat}'de yazdığnız not başarıyla kaydedilmiştir!");
                        kullanici_notu.Text = "";
                    }
                    else
                    {
                        File.Create(dosya_ismi).Close();
                        File.AppendAllText(dosya_ismi, şifrelenmiş_metin);
                    }
                }
            } catch { MessageBox.Show("şifrelemek için lütfen anahtar sayıyı giriniz"); }
        }
    }
}
