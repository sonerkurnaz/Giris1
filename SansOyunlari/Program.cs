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
            //int deneme = 0;
            //Console.WriteLine("Deneme sayısı giriniz: ");
            //deneme = int.Parse(Console.ReadLine());
            //Random rnd = new Random();
            //int[] yaziTura = new int[deneme];

            //for (int i = 0; i < deneme; i++)
            //{
            //    yaziTura[i] = rnd.Next(2);
            //}
            //int yazi = 0, tura = 0;
            //for (int i = 0; i < deneme; i++)
            //{
            //    if (yaziTura[i] == 0)

            //    {
            //        yazi = yazi + 1;
            //    }
            //    else
            //        tura = tura + 1;
            //}
            //Console.WriteLine("Yazı: " + yazi);
            //Console.WriteLine("Tura: " + tura);

            //Console.WriteLine("Hello World!");

            /*
             Deneme sayisi ekrandan alınacak
            Her atılan basket sonucu bir dizide tutulacak

            İki takımın müsabakasını yapınız
            Sonucu da ekrana yazınız

            

             */
            int denemeSayisi = 150;

            byte[] FenerBahce = new byte[denemeSayisi];
            byte[] GalataSaray = new byte[denemeSayisi];
            Random random = new Random();

            for (int i = 0; i < denemeSayisi; i++)
            {
                FenerBahce[i] = (byte)random.Next();
                GalataSaray[i] = (byte)random.Next();
            }
            int bos = 0, serbestAtis = 0, ikiliAtis = 0, uclukAtis = 0;
            int gsBos = 0, gsSerbest = 0, gsikili = 0, gsUcluk = 0;

            for (int i = 0; i < denemeSayisi; i++)
            {
                switch (FenerBahce[i])
                {
                    case 0:
                        bos = bos + 1;
                        break;
                        case 1:
                            serbestAtis=serbestAtis + 1;
                        break;
                    case 2:
                        ikiliAtis = ikiliAtis + 1;
                        break;
                    case 3:uclukAtis = uclukAtis + 1;
                        break;
                    default:
                        break;
                }
                switch (GalataSaray[i])
                {
                    case 0:
                        gsBos = gsBos + 1;
                        break;
                    case 1:
                        gsSerbest = gsSerbest + 1;
                        break;
                    case 2:
                        gsikili = gsikili + 1;
                        break;
                    case 3:
                        gsUcluk = gsUcluk + 1;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
