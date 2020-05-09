using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] dizi = new int[3];
            dizi[2] = 655;
            dizi[0] = 45252;
            dizi[1] = 1233;
            // dizi[3] = 765423; // Dizi 3 elemanlı olduğu için en son index numarası 2'dir. Bu işlem hata verir. Index was outside of the array hatası alıyorsanız dizinin kapasitesinden fazla eleman eklemekten dolayı bu hata geliyor demektir.
            char[] karakterler = { 'a', 'b', 'c' };
            string[] sehirler = new string[3] { "New York", "Los Angeles", "San Fransisco" };
        }
    }
}
// Array(Dizi): Birden fazla aynı tipteki veriyi bir arada tutmayı sağlar.
// Birinci tanımlama: <veri tipi>[] <dizi adı> = new <veri tipi>[<eleman sayısı>];
// İkinci tanımlama: <veri tipi>[] <dizi adı> = {<deger1>, <deger2>, ... };
// Üçüncü tanımlama : <veri tipi>[] <dizi adı> = new <veri tipi>[<eleman sayısı>] {<deger1>, <deger2>, ... };