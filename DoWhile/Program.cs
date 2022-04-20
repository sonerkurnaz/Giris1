using System;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ornek1
            int tekToplam = 0, ciftToplam = 0, sayac = 0;
            do
            {
                if (sayac % 2 == 0)
                {
                    ciftToplam += sayac;
                }
                else
                {
                    tekToplam += sayac;
                }
                sayac++;
            } while (sayac <= 100);
            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Çift Toplam: " + ciftToplam);

            //Faktoriyel
            
            decimal a = 1, b = 5;
            Console.WriteLine("Bir sayı giriniz:");
            b=int.Parse(Console.ReadLine());
            do
            {
                a = a * b;
                b--;
            } while (b > 0) ;
            Console.WriteLine("Sonuç: " + a);

            #endregion
        }
    }
}
