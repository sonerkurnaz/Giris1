using System;

namespace AritmetikIslemler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Matematiksel Islemler
            //int sayi1 = 5;
            //int sayi2 = 3;
            //int sonuc = 0;
            //Toplama işlemi

            //sonuc = sayi1 + sayi2;

            /*
             Yorum satırına almak için ctrl +k +c
            cıkarmak için 

             */
            //Console.WriteLine("-----------İşlem yapılacak sayılar   5,3-----------");
            //Console.WriteLine("Toplam: " + sonuc);//sonuc:8
            //Console.WriteLine("Toplam: " +sayi1+sayi2);//sonuc:53
            //Console.WriteLine("Toplam: " +(sayi1+sayi2));//sonuc:8
            //Console.WriteLine("Toplam: " +(sayi2+sayi1));//sonuc:8
            //Console.WriteLine("---------------Çıkarma--------------");

            //int fark = sayi1 - sayi2;
            //Console.WriteLine("Fark: " + fark);
            //Console.WriteLine("Fark: " + (sayi1 - sayi2));

            //Console.WriteLine("---------------Çarpma---------------");
            //int carpim = sayi1 * sayi2;
            //Console.WriteLine("Çarpma: " + carpim);
            //Console.WriteLine("Çarpma: " + (sayi1 * sayi2));

            //Console.WriteLine("---------------Bölme---------------");
            //int bolum = sayi1 / sayi2;
            //Console.WriteLine("Bolum: " + bolum);
            //Console.WriteLine("Bolum: " + (sayi1 / sayi2));

            //O'a bölme hatası
            //sayi1 = 0;
            //if(sayi2==0) //sayi2 0'a eşitmi
            //{
            //    Console.WriteLine("Bölen sayi 0 olamaz");
            //}
            //else
            //{
            //    bolum = sayi1 / sayi2;

            //}
            //Console.WriteLine("------------------Arttirma-------------------");

            //Console.WriteLine("Sayi:" + sayi1);
            //sayi1 = sayi1 + 1;
            //Console.WriteLine("Sayi:" + sayi1);
            //sayi1 += 1; //bu da sayi1 degiskenini 1 arttirir
            //Console.WriteLine("Sayi:" + sayi1);
            //sayi1++; // Bu da arttırır
            //Console.WriteLine("Sayi:" + sayi1);

            //Console.WriteLine("------------------Çıkartma-------------------");
            //Console.WriteLine("Sayi:" + sayi1);
            //sayi1 = sayi1 - 1;
            //Console.WriteLine("Sayi:" + sayi1);
            //sayi1 -= 1; //bu da sayi1 degiskenini 1 eksiltir
            //Console.WriteLine("Sayi:" + sayi1);
            //sayi1--; // Bu da eksiltir
            //Console.WriteLine("Sayi:" + sayi1);

            #endregion
            #region Ekrandan deger okuma
            /*
             * ekrandan deger okumak için Console.ReadLine() kullanılır
             * 
             * bu metod geriye her zaman string döner.
             * sayisal veri almak istiyorsak bu stringi çevirmek  (Convert) lazım.Örnekler asagıdadır
             * 
             * 
             */

            //string input, input2;
            //Console.Clear();

            //Console.WriteLine("Bir şeyler giriniz."); //Ekrana mesaj basar
            //input = Console.ReadLine();            //Ekrandan deger okur
            //sayi1 = Convert.ToInt32(input);       //girilen degeri integer a cevirir

            //Console.WriteLine("bir şeyler daha giriniz.");
            //input2 = Console.ReadLine();
            //sayi2 = Convert.ToInt32(input2);


            //Console.WriteLine("Girilen Deger: " + input + input2);
            //Console.WriteLine("Girilenlerin Toplami: " + (sayi1 + sayi2));
            //int sayi3 = Convert.ToInt32(Console.ReadLine());



            #endregion
            #region Sorular
            //Soru 1: Dışarıdan alınan 2 sayının toplamıyla,farkının birbirlerine bölümünden kalanın sonucu kaçtır?

            //Soru 2: Farkın toplama bölümünden kalan kactır?
            //string input = "";
            //Console.WriteLine("1.Sayıyı giriniz: ");
            //input = Console.ReadLine();
            //sayi1 = Convert.ToInt32(input);

            //Console.WriteLine("2.Sayıyı giriniz: ");
            //input = Console.ReadLine();
            //sayi2 = Convert.ToInt32(input);

            //float toplam = sayi1 + sayi2;
            #endregion
            #region Ornek 2
            /*
             * Dişaridan girilen bir sayının 10 eksiğinin 20 fazlasının 2'ye bölümünden kalanın karesi kactır?
             */
            Console.WriteLine();
            int sayi1, sayi2, bolumkalan;
            //Console.WriteLine("Sayı giriniz.");
            //sayi1 = Convert.ToInt32(Console.ReadLine());




            #endregion
            #region Ornek3
            //Console.Write("1.Sayıyı girniz");
            //string input = Console.ReadLine();
            //sayi1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı girniz");
            //input = Console.ReadLine();
            //sayi2 = int.Parse(Console.ReadLine());

            //int kareToplam, kareFark;
            //kareToplam = sayi1 * sayi2 + sayi1 * sayi2;
            //kareFark = sayi1 * sayi2 - sayi1 * sayi2;

            #endregion
            #region Ornek4
            //float vize1, vize2, final, ortalama;
            //Console.Write("1.Vize: ");
            //vize1 = float.Parse(Console.ReadLine());

            //Console.Write("2.Vize: ");
            //vize2 = float.Parse(Console.ReadLine());

            //Console.Write("Final: ");
            //final = float.Parse(Console.ReadLine());

            //ortalama = (vize1 + vize2) / 2 * 0.3f + final * 0.7f;
            //Console.WriteLine("Not Ortalamanız: " + ortalama);
            #endregion


            #region Ornek5
            //string ad, soyad, email;
            //Console.Write("Adınız: ");
            //ad = Console.ReadLine();

            //Console.Write("Soyadınız: ");
            //soyad = Console.ReadLine();
            //email = ad + "." + soyad + "@gmail.com";
            //Console.WriteLine("Email adresiniz: " + email);

            #endregion
            #region Ornek6
            string input;
             Console.WriteLine("1.Sayıyı giriniz: ");
            input = Console.ReadLine();
            sayi1 = Convert.ToInt32(input);

            Console.WriteLine("2.Sayıyı giriniz: ");
            input = Console.ReadLine();
            sayi2 = Convert.ToInt32(input);
            if (sayi2 != 0)
            {
                float bolum=sayi1 / (float)sayi2;
            }
            #endregion











            Console.WriteLine("Hello World!");
        }
    }
}
