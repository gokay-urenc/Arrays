using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Array_Diziler
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ArrayList dizi = new ArrayList();
            dizi.Add("Hello World");
            dizi.Add(13);
            dizi.Add(true);
            dizi.Add(221.10);
            dizi.Remove(221.10);

            foreach (var item in dizi)
            {
                string okunanVeri = item as string;
            }
        }
    }
}
// ArrayList her tipten veriyi alır.
// Aldığı her veriyi ise otomatik olarak object tipine çevirir.
// Diziye eleman eklemek kolaydır. Fakat okumak için cast işlemi yapılmalıdır.
// Cast işlemi yapılırken okunan verinin tipinden emin olmak gerekir.
// as operatörü bir cast işlemidir.
// Normal cast olayından farklı olarak sadece referans tiplerde çalışır.
// Cast yapılmaya çalışılan değer işleme tabi tutulamıyorsa yani hatalı olacaksa atama yapılan   değişkenin default(varsayılan) değerini alır.