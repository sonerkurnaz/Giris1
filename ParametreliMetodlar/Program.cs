using System;

namespace ParametreliMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EkranaYazdir("Hello World!");
            TurkceHarfler("şemsi paşa pasajında sesi büzüşesiciler");
            //verilen kelimeyi harf harf bastıran metod.

            //Verilen string içerisindeki türkçe
            //harflerin sayısını bulan metod.
        }

        static void EkranaYazdir(string mesaj)
        {
            foreach (char harf in mesaj)
            {
                Console.WriteLine(harf);
            }
        }
        public static void TurkceHarfler(string cumle)
        {
            char[] turkceHarf = { 'ç', 'ı', 'ğ', 'ş', 'ö', 'ü' };
            int[] turkceHarfSayisi = { 0, 0, 0, 0, 0, 0 };
            foreach (char harf in cumle)
            {
                if (harf == 'ç')
                    turkceHarfSayisi[0]++;
                if (harf == 'ı')
                    turkceHarfSayisi[1]++;
                if (harf =='ğ')
                    turkceHarfSayisi[2]++;
                if (harf == 'ş')
                    turkceHarfSayisi[3]++;
                if (harf == 'ö')
                    turkceHarfSayisi[4]++;
                if (harf == 'ü')
                    turkceHarfSayisi[5]++;

            }
            for (int i = 0; i < turkceHarfSayisi.Length; i++)
            {
                Console.WriteLine(turkceHarf[i]+" :"+turkceHarfSayisi[i]);
            }
        }
    }
}
