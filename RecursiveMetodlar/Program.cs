using System;

namespace RecursiveMetodlar
{
    internal class Program
    {
        // bir fonksiyonun içinde yine kendisinden bir parça
        // bulunuyorsa bu fonksiyonlara özyineli (recursive)
        // fonksiyon denilir -  metot içerisinde kendisini
        // tekrardan çağırma işlemi

        static void Main(string[] args)
        {

            // Bir sayinin faktoryelini nasil aliriz.

            // 5! = 5x4x3x2x1

            // FaktoryelHesapla(5);
            //RecursiveFaktoryel(3);
            //Console.WriteLine("Hello World!");

            //fibanocci sayilari 
            // 0,1,2,3,5,8,13,21,34,55....
            // fibanocci(100);
            Console.WriteLine(Fib_Recursive(20));
        }


        public static long Fib(int n)
        {
            if (n < 2)
                return n;
            long[] f = new long[n + 1];
            f[0] = 0;
            f[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
                Console.WriteLine(f[i]);
            }
            return f[n];
        }

        public static long Fib_Recursive(int n)
        {
            if (n == 0 || n == 1)
                return n;
            return Fib(n - 2) + Fib(n - 1);
        }


        public static void fibanocci(int sayi)
        {
            decimal[] fib = new decimal[sayi];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i < sayi; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
                Console.Write("i= " + i + " =>" + fib[i]);
                Console.WriteLine("  Oran :" + fib[i] / (fib[i - 1]));
            }


        }
        public static void FaktoryelHesapla(int sayi)
        {
            long sonuc = 1;
            if (sayi > 1)
            {
                for (int i = 1; i <= sayi; i++)
                {
                    sonuc *= i;
                }
            }

        }
        public static long RecursiveFaktoryel(int sayi)
        {
            if (sayi == 0)
                return 1;
            else
                return sayi * RecursiveFaktoryel(sayi - 1);
        }
    }
}
