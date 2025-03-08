using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şifreli_not_defteri_
{
    public partial class notları_okuma : UserControl
    {
        public notları_okuma()
        {
            InitializeComponent();
        }
        private void tamam_çöz_Click(object sender, EventArgs e)
        {
            try
            {
                string klasör_ismi = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "notlar.txt");
                DateTime tumtarih = DateTime.Now;
                string tarih = tumtarih.ToShortDateString();
                string saat = tumtarih.ToLongTimeString();
                string dosya_ismi = (klasör_ismi + "\\" + tarih + ".txt");
                string çözülecek_dosya_ismi = not_ismi.Text;
                string çözülecek_dosya_ismi_yolu = (klasör_ismi + "\\" + çözülecek_dosya_ismi + ".txt");
                try
                {
                    string[] dosya_içeriği = File.ReadAllLines(çözülecek_dosya_ismi_yolu);
                    int anahtar = Convert.ToInt32(anahtarsayi.Text);
                    Regex saatFormati = new Regex(@"\b(?:[01]\d|2[0-3]):[0-5]\d:[0-5]\d\b");
                    string şifreli_metin = "";
                    if (anahtarsayi == null) { MessageBox.Show("lütfen anahtarınızı giriniz!"); }
                    else
                    {
                        foreach (string satir in dosya_içeriği)
                        {
                            string kalan = saatFormati.Replace(satir, "");
                            for (int i = 0; i < kalan.Length; i++)
                            {
                                int binary_kodu = Convert.ToInt32(kalan[i]);
                                int gecici = binary_kodu - anahtar;
                                char tekrar_metin = (char)gecici;
                                şifreli_metin += tekrar_metin;
                            }
                            for (int i = 0; i < dosya_içeriği.Length; i++)
                            {
                                string çözulmuş_not = şifreli_metin;
                                string saattekrar = saatFormati.Match(satir).Value;
                                label3.Text = (saattekrar + çözulmuş_not);
                            }
                        }
                    }
                }
                catch { } 
            }
            catch (Exception) { MessageBox.Show("aradığınız not bulunamadı lütfen tekrar giriniz!"); }
        }

        private void anahtarsayi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
