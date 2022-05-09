using System;

namespace OutParametre
{
    internal class Program
    {
        /*
     * OUT ANAHTAR KELİMESİ
     * Bir metot icerisinden disariya birden fazla deger dondurmek 
     * isterseniz, "return" anahtar kelimesi fonksiyonlarda size 
     * yetmeyecektir. Void metotlar ise zaten geriye deger dondurmez. 
     * Bu bilinenleri yikabilmek icin kullandigimiz anahtar 
     * kelime "out" anahtar kelimesidir...
     */


        static void Main(string[] args)
        {

            double yakalananSonuc;

            geriyeDegerDonduren(12, out yakalananSonuc);

            Console.WriteLine(yakalananSonuc.ToString());


            int toplamaSonucu;
            int farkSonucu;
            long carpimSonucu;
            double bolumSonucu;
            byte modSonucu;

            Hesapla(9, 4,
                out toplamaSonucu,
                out farkSonucu,
                out carpimSonucu,
                out bolumSonucu,
                out modSonucu);
            Console.WriteLine("Toplam:" + toplamaSonucu);
            Console.WriteLine("Fark:" + farkSonucu);
            Console.WriteLine("Carpim:" + carpimSonucu);
            Console.WriteLine("Bolum:" + bolumSonucu);




        }


        public static void geriyeDegerDonduren(int sayi, out double firlatilanSonuc)
        {
            firlatilanSonuc = Math.Pow(sayi, 2);
        }

        public static void Hesapla(int sayiBir,
            int sayiIki,
            out int toplam,
            out int fark,
            out long carpim,
            out double bolum,
            out byte mod)
        {
            toplam = sayiBir + sayiIki;
            fark = sayiBir - sayiIki;
            carpim = sayiBir * sayiIki;
            bolum = sayiBir / sayiIki;
            mod = (byte)(sayiBir % sayiIki);
        }

    }
}
