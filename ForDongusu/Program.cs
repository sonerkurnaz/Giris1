using System;

namespace ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //int sayi = 0;
            //for (int deger = 0; deger < 1000; deger++)
            //{
            //    Console.WriteLine(deger);
            //}
            #endregion
            #region Ornek1
            //bir ila 10 arasındaki cift sayilari ekrana mod almadan basınız.
            //for (int i = 0; i <= 10; i=i+2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Ornek2
            //azalma örnegi

            //1-10 arasındaki tek sayıları tersten sirali şekilde ekrana basınız

            //for (int i = 9; i >0; i=i-2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Ornek3
            //Ayın ilk günü pazartesi olarak kabul edildiğinde
            //30 günlük takvimde pazar günlerini ekrana basın
            //for (int i = 0; i < 30; i=i+7)
            //{
            //    if (i==0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine("--------------------------------");

            //}
            //for (int i = 28; i > 0; i = i - 7) //2.yol
            //{
            //    if (i == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("--------------------------------");
            //for (int i = 28; i > 0; i = i - 7) //2.yol
            //{
            //    if (i == 0)
            //    {

            //    }


            //}


            #endregion

            #region Ornek4
            //for (char c = 'A'; c < 'Z'; c++)
            //{
            //    Console.WriteLine(c+"-"+Convert.ToInt32(c));
            //}
            #endregion
            #region Ornek5
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Yıl"+DateTime.Now.Year);
            Console.WriteLine("Ay"+DateTime.Now.Month);
            Console.WriteLine("Gün"+DateTime.Now.Day);
            Console.WriteLine("Haftanın kacıncı günü"+DateTime.Now.DayOfWeek);
            Console.WriteLine("Yılın kacıncı günü"+DateTime.Now.DayOfYear);

            for (int i = 2010; i <= DateTime.Now.Year; i++)
            {
                //pandemi yıllarını es geçelim 2020-2021
                
                if (!(i==2020 || i==2021))
                {
                    Console.WriteLine(i);
                }
            }
            #endregion

        }
    }
}
