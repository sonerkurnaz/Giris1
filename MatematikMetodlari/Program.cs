using System;

namespace MatematikMetodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PI sayısı
            Console.WriteLine(Math.PI);

            //Mutlak değer

            Console.WriteLine(Math.Abs(-27));

            //yuvarlama : Floor => verilen sayıyı bir alt tam degere yuvarlar
            Console.WriteLine(Math.Floor(12.9));

            //Ceiling => verilen sayıyı bir üst tam sayıya yuvarlar

            Console.WriteLine(Math.Ceiling(12.1));

            //Round => verilen sayının yaridan fazlası ise yukarı, yarıdan azı ise yuvarlar
            //Not: sayı .50 ise tek mi çift mi olduguna bakılır.
            //eğer tek ise yukarı, çift ise aşağı yuvarlama yapılır
            Console.WriteLine(Math.Round(12.55));
            Console.WriteLine(Math.Round(12.45));
            Console.WriteLine(Math.Round(12.50));
            Console.WriteLine(Math.Round(13.50));

            //Truncate => Sayının tam kısmını alır. Virgülden sonraki küsüratlı kısma bakmaz

            Console.WriteLine(Math.Truncate(22.50));

            //Max Value
            Console.WriteLine(Math.Max(12,45));

            //Min Value
            Console.WriteLine(Math.Min(12, 45));
        }
    }
}
