using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class PersonelKayit : Form
    {
        string ad, soyad, tcno, gsm, email;
        DateTime dogumTarihi;
        public PersonelKayit()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Ekrandan degerleri okuma

            
            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            gsm = txtGsm.Text;
            email = txtEmail.Text;
            tcno = txtTcNo.Text;

            dogumTarihi = dateTimePicker1.Value;
            #endregion
            #region Gelen Verileri Kontrol Et
            if (ad.Length < 2)
            {
                MessageBox.Show("Ad alani en az iki karakter olmalidir..");
                return;
            }
            if (soyad.Length < 2)
            {
                MessageBox.Show("Soyad  alani en az iki karakter olmalidir..");
                return;
            }
            if (gsm.Length < 10)
            {
                //532 111 22 33
                MessageBox.Show("Gsm alani en az 10 karakter olmalidir..");
                return;
            }
            if (!(tcno.Length == 11))
            {
                MessageBox.Show("TcNo alani 11 karakter olmalidir..");
                return;
            }
            if (dogumTarihi.Year > 2005 && dogumTarihi.Year < DateTime.Now.Year)
            {
                MessageBox.Show("Yaşin tutmadi .Buyude gel..");
                return;
            }
            if (!email.Contains("@"))
            {
                MessageBox.Show("Email Duzgun formatta olmalidir..");
                return;
            }
            #endregion
            #region Dosyaya yazma


            string path = @"Personel.txt";

            StreamWriter sw = File.AppendText(path);
            sw.WriteLine(ad + ";" + soyad + ";" + gsm + ";" + email + ";" + tcno);
            sw.Close();
            
            #endregion

            
        }

        private void PersonelKayit_Load(object sender, EventArgs e)
        {

        }
        
        public void FormuTemizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtEmail.Text = "";
            txtGsm.Text = "";
            txtTcNo.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
