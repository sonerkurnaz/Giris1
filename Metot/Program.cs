using System;

namespace Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = Topla(3, 5);
            Console.WriteLine(Topla("Ali","Veli"));
            Console.WriteLine(toplam);
            EkranaYaz("akdsjfad");
            Console.WriteLine("Hello World!");
            
            
        }
        /// <summary>
        /// verilen string tipinden mesajı consola yazar
        /// </summary>
        /// <param name="mesaj">string tipinden mesaj</param>
        public static void EkranaYaz(string mesaj)
        {
            Console.WriteLine(mesaj);
        }

        //Bütün metodlar class içerisinde olmak zorundadır.
        //Aşağıdaki metodun geri dönüş tipi integer, aldıgı 2 adet parametre vardır
        //her ikisi de integerdır
        public static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static float Topla(float sayi1, float sayi2)
        {
            return sayi1 + sayi2;
        }
        /// <summary>
        /// Verilen 2 stringi toplar
        /// </summary>
        /// <param name="a">String tipinden ilk deger</param>
        /// <param name="b">String tipinden ikinci deger</param>
        /// <returns>iki stringi birleştirip geri döner.</returns>
        public static string Topla(string a, string b)
        {
            return a + b;
        }
        public static decimal Topla(decimal sayi1, decimal sayi2)
        {
            return sayi1 + sayi2;
        }
        // 1- Rastgele Sifre üreten metod yaziniz. 
        // En az 1 tane buyuk harf , en az 1 sayi olacak ve
        // en az 8 karakter uzunlugunda olacak
        public static void SifreUret()
        {
            
            Random rnd = new Random();
            int sayi = rnd.Next();
            Console.WriteLine(sayi);

            

        }


        // Verilen sayinin asal sayi olup olmadigini belirleyen metod 
        

    }
}
