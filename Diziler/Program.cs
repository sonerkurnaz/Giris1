using System;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] siniftakiler = { "Ali", "Veli", "Ayşe", "Fatma" };
            int[] vize1 = { 30, 40, 50, 35 };
            int[] vize2 = { 50, 40, 45, 50 };
            int[] final = { 50, 55, 60, 50 };

            ////Ayseyi ekrana yazalım
            ////Bunun için aysenin dizideki index nosunu bilmem lazım
            ////Ayse dizide 2. sıradadır (dikkat diziler 0'dan baslar)
            //Console.WriteLine(siniftakiler[2]);

            ////Aysenin 1.vizesi kactır?
            ////Vize 1 dizisinin 2.elemanı aysenin vize notudur.
            //Console.WriteLine(vize1[2]);

            ////Aysenin 2.vize notu yanlıs girilmiş. olması gereken 55
            ////Vize2 notunu degiştirmek için

            //vize2[2] = 55;
            ////vize2[6] = 55;//Burası index was out of array hatasi

            ////Sınıftakileri ekrana foreach ile yazalım
            //Console.WriteLine("-----------------FOREACH DONGUSU-------------------");
            //foreach (string ogrenci in siniftakiler)
            //{
            //    Console.WriteLine(ogrenci);
            //}
            ////for ile yazalım
            //Console.WriteLine("-----------------FOR DONGUSU-------------------");
            //for (int i = 0; i < siniftakiler.Length; i++)
            //{
            //    Console.WriteLine(siniftakiler[i]);
            //}
            //Console.WriteLine("-----------------WHILE DONGUSU-------------------");
            ////while

            //int sayac = 0;
            //while (sayac < siniftakiler.Length)
            //{
            //    Console.WriteLine(siniftakiler[sayac]);
            //    sayac++;
            //}

            //Console.WriteLine("-----------------DO WHILE DONGUSU-------------------");

            //do
            //{
            //    Console.WriteLine(siniftakiler[sayac]);
            //    sayac++;
            //} while (sayac < siniftakiler.Length);

            //siniftakiler dizisinin son elemanını ekrana yazın
            //Console.WriteLine(siniftakiler[siniftakiler.Length - 1]);


            //siniftakiler dizisinin vize ortalamaları?
            //1. yol foreach
            float ortalama1 = 0, ortalama2 = 0;
            //foreach (int not in vize1)
            //{
            //    ortalama1 += not;
            //}
            //ortalama1 = ortalama1 / 4;
            //foreach (int not in vize2)
            //{
            //    ortalama1 += not;
            //}
            //ortalama2 = ortalama2 / 4;

            //Console.WriteLine("Birinci Vize Ortalaması: " + ortalama1);
            //Console.WriteLine("İkinci Vize Ortalaması: " + ortalama2);

            //2.Yol For ile
            //ortalama1 = 0;
            //ortalama2 = 0;

            //for (int i = 0; i < 4; i++)
            //{
            //    ortalama1 = ortalama1 + vize1[i];
            //    ortalama2 = ortalama2 + vize2[i];
            //}
            //ortalama1= ortalama1 / 4;
            //ortalama2= ortalama2 / 4;
            //Console.WriteLine("Birinci Vize Ortalaması: " + ortalama1);
            //Console.WriteLine("İkinci Vize Ortalaması: " + ortalama2);

            // siniftakilerin tek tek vize ortalamları?
            float ortalama;
            for (int i = 0; i < siniftakiler.Length; i++)
            {
                
            }




            Console.WriteLine("Hello World!");
        }
    }
}
