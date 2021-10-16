using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metematıkOyuns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        char[] islemler = new char[4];
        int ılkGrup = 0;
        int ıkıncıGrup = 0;
        char islem;
        int puan = 0;
        int sure = 60;
        int sayi1 = 0;
        int sayi2 = 0;
        int sayi3 = 0;
        int sayi4 = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            islemler[0] = '+';
            islemler[1] = '-';
            islemler[2] = '*';
            islemler[3] = '/';
            islem = islemler[r.Next(0, 4)];
            sayi1 = r.Next(0, 100);
            sayi2 = r.Next(0, 100);
            sayi3 = r.Next(0, 100);
            sayi4 = r.Next(0, 100);
            

            
            lblIlkgrup.Text = ılkGrup.ToString();
            lblıkıncıGrup.Text = ıkıncıGrup.ToString();
            lblıslem.Text = islem.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
            if (ılkGrup > ıkıncıGrup) ;
            }
            txtDurum.Text = ("Tebrikler Doğru cevapladınız 10 puan kazandınız");
            if (e.KeyCode == Keys.Right)
            {
                txtDurum.Text = ("Üzgünüz Yanlış Cevapladınız zamanınız 10 saniye kısaldı");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sure == 0) ;
            {
                tmrsure.Enabled = false;
                MessageBox.Show("Süreniz dolmuştur oyun bitti");
            }
        }
    }









