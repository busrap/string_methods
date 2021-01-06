using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_metod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string kelimeler_alt_alta_yazdır(string metin1)
        {
            string[] kelime = metin1.Split(' ');
            foreach (string kelimeler in kelime)
            {
                lst_ayrı_kelimeler.Items.Add(kelimeler);
            }

            return kelime[0];
        }
       void cumleleri_alt_alta_yazdır(string metin2)
        {
            string[] cümleler = metin2.Split('.');
            foreach (string cümle in cümleler)
            {
                lst_ayrı_cümleler.Items.Add(cümle);
            }
            
        }
        string karakter_saymaca(string metin3)
        {
            string veri = metin3;
            int sayaç = 0;
            foreach (char i in veri)
            {

                if (i != ' ')
                {

                    sayaç++;
                }
            }
            MessageBox.Show("Metinde ki karakter sayısı =  " + sayaç.ToString());
            return veri;
        }
        string kelime_sayısı(string metin4)
        {
            string[] veri = metin4.Split(' ');
            int kelime_sayacı = 0;
            foreach (string kelime in veri)
            {
                kelime_sayacı++;
            }
            MessageBox.Show("Toplam kelime sayısı = " + kelime_sayacı);
            return veri[0];
        }
        string cümleleri_ayır(string metin5)          // 0 tanımlamıştın ama bir fazla saydı sebebini sor hocaya cümle sayacı için
        {
            int cümle_sayıcı = -1;
            string[] cümle = metin5.Split('.');
            foreach (string eleman in cümle)
            {
                cümle_sayıcı++;
            }
            MessageBox.Show(string.Format("Toplam cümle sayısı= {0}",cümle_sayıcı));
            return cümle[0];
        }
        string kücük_yazdır(string metin6)
        {
            string kücük_yaz = metin6.ToLower();
            return kücük_yaz;
        }
        string büyük_yaz(string metin7)
        {
            string büyük_yaz = metin7.ToUpper();
            return büyük_yaz;
        }
        private void checkBox_kelime_ayır_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_kelime_ayır.Checked)
            {
                kelimeler_alt_alta_yazdır(textBox_metin.Text);
            }

        }

        private void checkBox_cümleleri_ayır_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cümleleri_ayır.Checked)
            {
                cumleleri_alt_alta_yazdır(textBox_metin.Text);
            }

        }

        private void checkBox_kelime_toplam_sayı_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_kelime_toplam_sayı.Checked)
            {
                kelime_sayısı(textBox_metin.Text);
            }
        }

        private void checkBox_toplam_harf_sayısı_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_toplam_harf_sayısı.Checked)
            {

                karakter_saymaca(textBox_metin.Text);
            }
        }

        private void checkBox_cümlelerin_toplam_sayısı_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cümlelerin_toplam_sayısı.Checked)
            {
                cümleleri_ayır(textBox_metin.Text);
            }
        }

        private void checkBox_kücük_yazdır_CheckedChanged(object sender, EventArgs e)
        {
            
            MessageBox.Show("( Metin tamamen küçük harf ile yazdırıldı... )\n\n"+kücük_yazdır(textBox_metin.Text));
        }

        private void checkBox_büyük_yazdır_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("( Metin tamamen büyük harf ile yazdırıldı... )\n\n" + büyük_yaz(textBox_metin.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
