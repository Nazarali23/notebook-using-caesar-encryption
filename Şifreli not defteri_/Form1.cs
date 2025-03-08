using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şifreli_not_defteri_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void not_oluştur_Click(object sender, EventArgs e)
        {
            yeni_not1.Show();
            yeni_not1.BringToFront();
            notları_okuma1.Hide();
            dosyaları_görme1.Hide();
        }

        private void not_okuma_Click(object sender, EventArgs e)
        {
            notları_okuma1.Show();
            notları_okuma1.BringToFront();
            dosyaları_görme1.Hide();
            yeni_not1.Hide();
        }

        private void dosyaları_göster_Click(object sender, EventArgs e)
        {
            dosyaları_görme1.Show();
            dosyaları_görme1.BringToFront();
            yeni_not1.Hide();
            notları_okuma1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notları_okuma1.Hide();
            yeni_not1.Hide();
            dosyaları_görme1.Hide();
        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {
            notları_okuma1.Hide();
            yeni_not1.Hide();
            dosyaları_görme1.Hide();

        }
    }
}
