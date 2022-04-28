using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSansur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "İstanbul'da ulaşıma ve taksi ücretlerine zam geldiği son dakika haberiyle duyuruldu. Bu noktada İstanbul taksimetre açılış fiyatı ile taksi zammı 2022 ne kadar kaç TL oldu ? soruları yanıt aramaya başladı. Milyonlarca vatandaşın yaşadığı megakentte toplu ulaşım araçlarının ücretlerinde yapılan bu düzenleme taksicilerin yüzünü güldürürken vatandaşlar için ise oldukça zorlayıcı olacak. İşte 2022 İstanbul taksimetre açılış ücreti ile indi bindi ve kısa mesafe ücretleri...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                textBox1.Text = textBox1.Text.Replace(item.ToString(), "***", StringComparison.OrdinalIgnoreCase);
            }
        }
    }
}
