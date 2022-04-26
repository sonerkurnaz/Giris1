using System;
using System.Collections;

namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList dizi = new ArrayList();
            dizi.Add("Adana");
            dizi.Add(1);
            dizi.Add(new DateTime());
            dizi.Add(true);
            dizi.Add("Urfa");
            dizi.Add("Bursa");
            dizi.Add("Edirne");
            dizi.Add("İzmir");
            dizi.Add("Ayse");
            dizi.Add("Fatma");

            //Araya eleman eklemek

            dizi.Insert(3, "Ali");
            dizi.Insert(5, "Veli");

            //Verilen elemanı listeden kaldırmak

            dizi.Remove("Veli");

            //ArrayListi sıralamak için .sort kullanılır
            // dizi.Sort();

            //O anki eleman sayısına eşitliyor
            dizi.TrimToSize();




            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
