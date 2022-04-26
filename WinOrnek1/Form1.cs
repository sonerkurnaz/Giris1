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
            araclar.Add("TOFAŞ");
            araclar.Add("BMW");
            araclar.Add("MERCEDES");
            araclar.Add("SUBARU");

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

            Random rnd
        }
    }
}
