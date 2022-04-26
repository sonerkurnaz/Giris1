using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList cuval = new ArrayList();
            //cuval.Add("ali");
            //cuval.Add(12);

            //List<string> sehirler = new List<string>();
            //sehirler.Add("Adana");
            //sehirler.Add("Urfa");
            //sehirler.Add("Bursa");

            //List<int> sayilar = new List<int>();


            //Console.WriteLine("Kaç eleman gireceksiniz: ");
            //int elemanSayisi = int.Parse(Console.ReadLine());

            ////Bu döngü girilen eleman sayısı kkadar veri ekleyecek
            //Random rnd = new Random();
            //int tekSayi = 0, ciftSayi = 0, gecici = 0;
            //for (int i = 0; i < elemanSayisi; i++)
            //{
            //    gecici = rnd.Next(1, 50);
            //    if (gecici % 2 == 0)
            //        ciftSayi++;
            //    else
            //        tekSayi++;

            //    sayilar.Add(gecici);
            //}
            //Console.WriteLine("Tek sayı adedi: " + tekSayi);
            //Console.WriteLine("Çift sayı adedi: " + ciftSayi);

            #region Ornek1
            /*
              1- Bir sınıftaki kişilerin ad ve soyadlarını tutan listeyi yazınız.
              2- Aynı sınıfın vize ve final notlarını tutacak listeyi yazınız.
              3- Sınıftakilerin gecip kalma durumları
              
             */

            List<string> siniflistesi = new();
            List<int> vize1 = new();
            List<int> vize2 = new();
            List<int> final = new();
            List<float> sonuclar = new();

            //Sinif listesi oluşturuluyor
            siniflistesi.Add("Ali");
            siniflistesi.Add("Veli");
            siniflistesi.Add("Ayşe");
            siniflistesi.Add("Fatma");

            //Vize 1 notları
            vize1.Add(40);
            vize1.Add(45);
            vize1.Add(50);
            vize1.Add(55);

            //Vize 2 notları
            vize2.Add(45);
            vize2.Add(50);
            vize2.Add(55);
            vize2.Add(60);

            //final notları
            final.Add(50);
            final.Add(50);
            final.Add(50);
            final.Add(50);

            float not = 0;
            //geçip kalma notları hesaplanıyor
            for (int i = 0; i < vize1.Count; i++)
            {
                not = (vize1[i] + vize2[i]) / 2 * 0.3f + final[i] * 0.7f;
                sonuclar.Add(not);
            }
            for (int i = 0; i < sonuclar.Count; i++)
            {
                Console.WriteLine(siniflistesi[i] + "-" + "Geçme Notu: " + sonuclar[i]);
            }


            #endregion


        }
    }
}
