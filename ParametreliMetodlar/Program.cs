using System;

namespace ParametreliMetodlar
{
    internal class Program
    { /*
            PARAMETRELİ METOTLAR
            Disaridan gelecek olan degerlere gore islem yonunu degistirecek olan metotlardir...
            Parametredeki degiskene, iceride deger atanmaz!
            Metot prensipleri geregi, parametrenin nereden gelecegi soylenmez....
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // EkranaYazdir("Hello World");
            // Verilen kelimeyi harf harf ekrana bastiran metod.

            // Verilen string icerisinde ki turkce harflerin
            // sayisi bulan metod..
            //SesliHarfSayisi("şemsi paşa pasajında sesi büzüşeciler");

            // 1- Rastgele Sifre üreten metod yaziniz. 
            // En az 1 tane buyuk harf , en az 1 sayi olacak ve
            // en az 8 karakter uzunlugunda olacak

            // Verilen sayinin asal sayi olup olmadigini belirleyen metod 
            Console.WriteLine(Topla(1, 2, 3, 4, 5, 6, 7, 8, 9));
            Console.WriteLine(Topla(1, 2, 3, 4, 5, 8, 6, 7, 8, 9, 10, 11, 12));
        }

        /// <summary>
        /// Verilen Sayilari Toplar
        /// </summary>
        /// <param name="sayi1">int tipinde</param>
        /// <param name="sayi2">int tipinde</param>
        /// <returns>int tipinde</returns>
        public static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static int Topla(int sayi1, float sayi2)
        {
            return sayi1 + (int)sayi2;
        }
        /// <summary>
        /// Uç Parametreli metod
        /// </summary>
        /// <param name="sayi1"></param>
        /// <param name="sayi2"></param>
        /// <param name="sayi3"></param>
        /// <returns></returns>
        public static int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        public static int Topla(int sayi1, int sayi2, int sayi3, int sayi4)
        {
            return sayi1 + sayi2 + sayi3 + sayi4;
        }
        /// <summary>
        /// Sonsuz parametreli metod
        /// </summary>
        /// <param name="parametreler">parametreler bir int dizisidir</param>
        /// <returns></returns>
        public static int Topla(params int[] parametreler)
        {
            int toplam = 0;
            foreach (var item in parametreler)
            {
                toplam += item;
            }
            return toplam;
        }

        public static void DavetiyeGonder(params string[] davetliler)
        {
            foreach (var davetli in davetliler)
            {
                Console.WriteLine(davetli);
            }
        }
        public static void SesliHarfSayisi(string cumle)
        {
            // Turkçe harfler : ç,ı,ğ,ş,ö,ü
            char[] turkceHarfler = { 'ç', 'ı', 'ğ', 'ş', 'ö', 'ü' };
            int[] turkceHarfSayisi = { 0, 0, 0, 0, 0, 0 };
            foreach (var harf in cumle)
            {
                if (harf == 'ç')
                    turkceHarfSayisi[0]++;
                if (harf == 'ı')
                    turkceHarfSayisi[1]++;
                if (harf == 'ğ')
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
                Console.WriteLine(turkceHarfler[i] + " :" + turkceHarfSayisi[i]);
            }

        }
        static void EkranaYazdir(string mesaj)
        {
            foreach (char harf in mesaj)
            {
                Console.WriteLine(harf);
            }
        }
    }
}
