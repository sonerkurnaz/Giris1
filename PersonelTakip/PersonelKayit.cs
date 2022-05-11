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
    struct Adres
    {
        public string il;
        public string ilce;
        public string cadde;
        public string sokak;
        public string numara;

    }
    struct Kisi
    {
        public string Ad;
        public string Soyad;
        public string TcNo;
        public string Gsm;
        public string Email;
        public DateTime DogumTarihi;
        public Adres Adres;

    }

    public partial class PersonelKayit : Form
    {
        string ad, soyad, tcno, gsm, email;
        DateTime dogumTarihi;


        List<string> Adlar = new List<string>();
        List<string> Soyadlar = new List<string>();
        List<string> TcNolar = new List<string>();
        List<string> Gsmler = new List<string>();
        List<string> Emailler = new List<string>();
        List<DateTime> DogumTarihleri = new List<DateTime>();

        List<Kisi> Kisiler = new List<Kisi>();

        /*
         struck tanımlaması
         */


        public PersonelKayit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] satilar = File.ReadAllLines("Personel.txt");
            foreach (var satir in satilar)
            {
                string[] veriler = satir.Split(";");
                //Adlar.Add(veriler[0]);
                //Soyadlar.Add(veriler[1]);
                //GsmLer.Add(veriler[2]);
                //Emailler.Add(veriler[3]);
                //TcNolar.Add(veriler[4]);
                //DogumTarihleri.Add(Convert.ToDateTime(veriler[5]));


                Kisi kisi = new Kisi();
                kisi.Ad = veriler[0];
                kisi.Soyad = veriler[1];
                kisi.Gsm = veriler[2];
                kisi.Email = veriler[3];
                kisi.TcNo = veriler[4];
                kisi.DogumTarihi = Convert.ToDateTime(veriler[5]);

                Kisiler.Add(kisi);


            }


            for (int i = 0; i < satilar.Length; i++)
            {

                string yazilacakSatir = Adlar[i] + "-" + Soyadlar[i] + "-" + Gsmler[i] + Emailler[i] + "-" + TcNolar[i] + DogumTarihleri[i];

                listBox1.Items.Add(yazilacakSatir);
            }
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
        {// Ornek bir structer dan instance alinmasi
            Kisi ahmet = new Kisi();
            ahmet.Ad = "Ahmet";
            ahmet.Soyad = "Yilmaz";
            ahmet.TcNo = "321321321";
            ahmet.Email = "ahmet@gmail.com";
            ahmet.DogumTarihi = DateTime.Now.AddYears(-20);
            ahmet.Adres.il = "adana";
            ahmet.Adres.ilce = "Kozan";
            ahmet.Adres.cadde = "Zafer cad";
            ahmet.Adres.sokak = "Gul Sok";
            ahmet.Adres.numara = "No:5 kat:2 D:3";
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
