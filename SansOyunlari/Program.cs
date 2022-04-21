using System;

namespace SansOyunlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * ekrandan deneme sayisi alınacak.
             * deneme sayisi kadar bir dizi olusturulacak
             * dizi
             */
            int deneme = 0;
            Console.WriteLine("Deneme sayısı giriniz: ");
            deneme = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] yaziTura = new int[deneme];

            for (int i = 0; i < deneme; i++)
            {
                yaziTura[i] = rnd.Next(2);
            }
            int yazi = 0, tura = 0;
            for (int i = 0; i < deneme; i++)
            {
                if (yaziTura[i] == 0)

                {
                    yazi = yazi + 1;
                }
                else
                    tura = tura + 1;
            }
            Console.WriteLine("Yazı: " + yazi);
            Console.WriteLine("Tura: " + tura);

            Console.WriteLine("Hello World!");
        }
    }
}
