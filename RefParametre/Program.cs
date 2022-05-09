using System;

namespace RefParametre
{
    internal class Program
    { /*
                REF ANAHTAR KELİMESİ
        ref parametre niteleyicisi C#’ın “değer olarak çağrı” 
        yerine “referans olarak çağrı” oluşturmasını sağlar. 
        ref kullanarak, void tipli methodlardan değer alabilirsiniz.
        Üstelik bu değeri alabilmek için yeni bir değişken atamanıza 
        gerek bile kalmaz. ref, methoda parametre olarak soktuğunuz,
        elinizdeki varolan değişkeni değiştirebilir.
        */
        static void Main(string[] args)
        {
            string[] elemanlar = new string[3];

            elemanlar[0] = "ali@gmail.com";
            elemanlar[1] = "veli@gmail.com";
            elemanlar[2] = "ayse@hotmail.com";

            //Console.Write("Mail Adresi: ");
            //string mailAddress = Console.ReadLine();

            MailGonder(ref elemanlar, "ercan@gmail.com");

            //foreach (string eleman in elemanlar)
            //{
            //    Console.WriteLine(eleman);
            //}
        }
        public static void MailGonder(ref string[] mailadresleri, string gonderen)
        {
            foreach (var item in mailadresleri)
            {
                Console.WriteLine(item + " adresinde " + gonderen + "  tarafindan mail gonderilmistir.");
            }
        }


        public static void MailListecisi(ref string[] HangiDiziyeEklensin, string VerilerNeredenGeliyor)
        {
            // ; gordugumuz yerden degerleri bolup, diziye ekleyelim...
            string[] gelenDegerler = VerilerNeredenGeliyor.Split(';');

            for (int i = 0; i < gelenDegerler.Length; i++)
            {
                Array.Resize<string>(ref HangiDiziyeEklensin, HangiDiziyeEklensin.Length + 1);
                HangiDiziyeEklensin[i] = gelenDegerler[i];
            }
        }
    }
}
