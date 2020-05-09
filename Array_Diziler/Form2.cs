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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] arabalar = { "Mercedes", "Ferrari", "Bugatti", "Lamborghini", "Porsche", "Audi", "Seat", "Honda", "Alfa Romeo" };
        private void btnSonEleman_Click(object sender, EventArgs e)
        {
            string sonEleman = arabalar[arabalar.Length - 1];
            MessageBox.Show("Dizideki son eleman: " + sonEleman);
        }

        private void btnRastgeleEleman_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int uretienSayi = rnd.Next(0, arabalar.Length);
            this.Text = arabalar[uretienSayi];
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arabalar.Length; i++)
            {
                listBox1.Items.Add(arabalar[i]);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                int alinanDeger = Convert.ToInt32(textBox1.Text);
                MessageBox.Show(arabalar[alinanDeger]);
            }
            catch (Exception)
            {
                string deger = textBox1.Text;
                int indexNo = Array.IndexOf(arabalar, deger);
                MessageBox.Show(indexNo.ToString());
            }
        }

        int secilenIndex = 0;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = listBox1.SelectedItem.ToString();
            secilenIndex = listBox1.SelectedIndex;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            arabalar[secilenIndex] = textBox2.Text;
            listBox1.Items.Clear();
            foreach (var item in arabalar)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
// Dizinin eleman sayısını bilmiyoruz, ancak bizden istenen son elemanı kullanıcıya göstermek:   araba.Lenght => Dizinin uzunluğunu verir.
// Dizinin son indexteki elemanına ulaşmak için genel mantık şudur:
// Son index her zaman dizi uzunluğunun bir eksiğidir.
// Hangi tip dizi olursa olsun dizi içinden tek bir eleman okunacaksa ve index numarası          biliniyorsa [] operatörü okunabilir.
// [] operatörüyle diziye eleman atama sadece Array-İlkel diziler ile yapılır.
// Array.Clear(arabalar, secilenIndex, 1); // arabalar dizisinden istenen indexten başlayıp 1    tane sil.