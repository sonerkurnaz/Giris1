using System;

namespace TarihMetodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime baslangic = DateTime.Now;
            //Günün Tarih ve Zamanı almak
            Console.WriteLine(DateTime.Now);

            //sadece gün ay yıl
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.ToLongDateString());

            //Tarih formatlamak

            Console.WriteLine(DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year);

            //artık yıl kontrolü

            bool artikYilmi = DateTime.IsLeapYear(2022);

            //Son 10 yılın artık yılları hangisidir

            for (int i = 2000; i < DateTime.Now.Year; i++)
            {
                artikYilmi = DateTime.IsLeapYear(i);
                if (artikYilmi)
                {
                    Console.WriteLine(i);
                }
            }

            //Haftanın günü
            Console.WriteLine(DateTime.Now.DayOfWeek);

            //Yılın Günü

            Console.WriteLine(DateTime.Now.DayOfYear);
            DateTime trh = DateTime.Now.AddDays(10);
            Console.WriteLine(trh);

            //timespan
            DateTime bora = new DateTime(1994, 9, 13);
            DateTime simdi = DateTime.Now;

            TimeSpan tarihFarki = simdi - bora;
            Console.WriteLine("Bora " + tarihFarki.Days + "gündür hayatta");
            Console.WriteLine("Bora" + tarihFarki.TotalDays + "saniyedir yaşıyor");

            DateTime bitis = DateTime.Now;
            tarihFarki = bitis - baslangic;
            Console.WriteLine("Program " + tarihFarki.TotalMilliseconds + " ms  calismistir");

            Console.WriteLine("Hello World!");
        }
    }
}
