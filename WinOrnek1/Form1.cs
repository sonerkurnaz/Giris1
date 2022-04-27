using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOrnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> araclar = new List<string>();
            araclar.Add("Tofas");
            araclar.Add("Bmw");
            araclar.Add("Mercedes");
            araclar.Add("Subaru");

            foreach (var araba in araclar)
            {
                listBox1.Items.Add(araba);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //rastgele 50 sayı oluşturunuz.
            //tek sayiları listbox1 e 
            // çift sayları listbox2 ye 
            // hem 3 hem de 5 bölünenleri de ayrı bir listeye atınız



            Random rnd = new Random();
            int sayi = 0;
            for (int i = 0; i < 50; i++)
            {

                sayi = rnd.Next(100);
                if (sayi % 2 == 0)
                {
                    listBox1.Items.Add(sayi);
                }
                else
                {
                    listBox2.Items.Add(sayi);
                }
                if (sayi % 15 == 0)
                {
                    listBox3.Items.Add(sayi);
                }
            }









        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string deger = textBox1.Text;
            int elemanSayisi = int.Parse(deger);
            int[] sayilar = new int[elemanSayisi];
            // Girilen eleman sayisi kadar 1-10
            // arasinda sayi uretisin.
            // Olusturulan dizideki sayilarin
            // frekansi nedir ? (Tekrar Sayisi)
            // Sonuclari Listbox'a yaziniz.

            //1-Random Degerler atayin

            //2- Frekans heabi yapilacak

            //3-ListBox'a eklenecek 
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] sayilar = new int[20];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(100);
                listBox1.Items.Add(sayilar[i]);
            }
            int enKucuk = sayilar[0], enBuyuk = sayilar[0];
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (enKucuk > sayilar[i])
                {
                    enKucuk = sayilar[i];
                }
                if (enBuyuk < sayilar[i])
                {
                    enBuyuk = sayilar[i];
                }
            }
            listBox2.Items.Add("En Küçük:" + enKucuk);
            listBox2.Items.Add("En Büyük:" + enBuyuk);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }
    }
}
