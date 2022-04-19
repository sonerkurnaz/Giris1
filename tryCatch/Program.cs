using System;

namespace tryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ornek
            //int sayi1, sayi2;
            //float sonuc;
            //try
            //{
            //    Console.Write("1.Sayıyı giriniz: ");
            //    sayi1 = int.Parse(Console.ReadLine());

            //    Console.Write("2.Sayıyı giriniz: ");
            //    sayi2 = int.Parse(Console.ReadLine());

            //    sonuc = sayi1 / sayi2;
            //    Console.WriteLine("Sonuc" + sonuc);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("Daha kücük sayi giriniz.");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Sifira bolme hatasi");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Düzgün veri giriniz. Girdiğiniz veri sayisal degil");
            //}
            //catch (Exception ex)
            //{
            //    //Hata oluştu: Value was either too large or too small for an Int32.
            //    //Hata oluştu: Attempted to divide by zero.
            //    //Hata oluştu: Input string was not in a correct format.
            //    Console.WriteLine("Hata oluştu: " + ex.Message);
            //}
            #endregion
            #region Ornek2
            DateTime dogumTarihi;
            string input;
            try
            {
                Console.Write("Dogum tarihinizi giriniz:");
                input = Console.ReadLine();
                dogumTarihi= DateTime.Parse(input);
                Console.WriteLine(dogumTarihi.ToString());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Girilen deger dogru formatta degil.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            #endregion
            Console.ReadLine();
        }
    }
}
