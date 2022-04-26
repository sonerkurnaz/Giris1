using System;

namespace ArraySinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] arabalar = { "Bmw", "Audi", "Fiat",
            //    "Toyota", "Honda", "Alfa Romeo", "Subaru" };
            //Console.WriteLine("Aradığınız araç?");
            //string arananAraba = Console.ReadLine();
            //int index = Array.IndexOf(arabalar, arananAraba);

            //if (index == -1)
            //{
            //    Console.WriteLine("Aradığınız" + arananAraba + "listede yoktur.");
            //}
            //else
            //{
            //    Console.WriteLine("Aradığınız" + arananAraba + " " + index + ".sıradadır.");
            //}
            //index = Array.IndexOf(arabalar, arananAraba,2);

            #region Array.Reverse
            string[] arabalar = { "Bmw", "Audi", "Fiat",
                "Toyota", "Honda", "Alfa Romeo", "Subaru" };
            Array.Sort(arabalar);
            Array.Reverse(arabalar);
            foreach(var item in arabalar)
            {
                Console.WriteLine(item);    

            }
            
            #endregion


        }
    }
}
