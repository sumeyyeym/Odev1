using System;
using System.Windows.Forms;

namespace degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            float s1 = 213.1231F;

            double s2 = 54545.44575;

            decimal s3 = 7897957.77838M;

            //Ctrl + Shift + B = Build işlemi kısa yolu
        }

        private void BtnTamSayilar_Click(object sender, EventArgs e)
        {
            // Ctrl + R + G ==> Gereksiz usinleri siler
            // Ctrl + K + D => Kodları düzenler
            // Ctrl + E + W => Wordwrap
            // Ctrl + K + C => yorum satırına alma
            // Ctrl + K + U => yorum satırından çıkart

            // byte = ram üzerinde 8 bitlik bir alan kapsar. 0 ile 255 değer aralığında veri tutar
            byte sayi = 12;

            //sbyte: 8 bitlik alna kaplar
            sbyte sayi1 = 23;

            short sayi2 = 213;

            ushort sayi3 = 123;

            int sayi4 = 21321;

            uint sayi5 = 2131;

            long sayi6 = 7478976746;

            ulong sayi7 = 154876425454545;


        }

        private void BtnMetinsel_Click(object sender, EventArgs e)
        {
            char karakter = 'a';

            string metin = "bilge \"adam\" beşiktaş"; //adam kelimesini çift tırnak içinde verir. değer başlangıcı ve bitişi olarak kullanılan tırnak işaretinin etkisini kaldırmak ve hatanın önüne geçmek için ters slash kullanılmıştır. \ = kaçış karakteri

            metin = "bilge\nadam\nbeşiktaş"; // \n = new line. yani bir alt satıra atarak çalıştırmasını sağlar. ayrıca bu satırda, üstteki metin bilgisi silinmiş ve yeni değer verilmiş olunur.

            metin = "bilge\tadam\tbeşiktaş"; // \t = tab tuşuna basılınca oluşan boşluk kadar boşluk bırakır

            MessageBox.Show(metin);
        }

        private void BtnMantiksal_Click(object sender, EventArgs e)
        {
            bool olumlu = true;
            bool olumsuz = false;
            bool result1 = 10 > 4;// true
            bool rasult2 = 10 < 4; // false
        }
    }
}
