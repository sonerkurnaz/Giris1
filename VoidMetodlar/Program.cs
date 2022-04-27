using System;

namespace VoidMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TekCift();
            //1-100 arasındaki tek ve çift
            //sayıların toplamını yapan metod.
            Not




        }
        static void AlanHesabı()
        {
            //int kisa = 0, uzun = 0;
            //Console.WriteLine("Kısa Kenar: ");
            //kisa = int.Parse(Console.ReadLine());

            //Console.WriteLine("Uzun Kenar: ");
            //uzun = int.Parse(Console.ReadLine());
            //Console.WriteLine("Alan: " + (kisa * uzun));
            //Console.WriteLine("Çevre: " + (kisa * uzun));
        }
        /// <summary>
        /// 1-100 arasındaki tek ve çift sayıların toplamını verir
        /// </summary>
        static void TekCift()
        {
        //    int tekToplam = 0, ciftToplam = 0;
        //    for (int i = 0; i < 100; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            ciftToplam += i;
        //        }
        //        else
        //        {
        //            tekToplam += i;
        //        }
        //    }
        //    Console.WriteLine("Tek Toplamlar: " + tekToplam);
        //    Console.WriteLine("Çift Toplamlar: " + ciftToplam);
        }
        static void NotHesaplama(float vize1, float vize2, float final)
        {

            float ortalama = 0;


            ortalama = (vize1 + vize2) / 2 * 0.3f + final * 0.7f;

            Console.WriteLine("Ortalamanız: " + ortalama);
        }


    }
}



