using System;

namespace KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ornek


            //string kod;
            //Console.WriteLine("İçecek kodunu giriniz: ");
            //kod = Console.ReadLine();

            //if (kod == "Ç" || kod == "ç")
            //{
            //    Console.WriteLine("Çay");
            //}
            //else if (kod == "M" || kod == "m")
            //{
            //    Console.WriteLine("Meyve Suyu");
            //}
            //else if (kod == "L" || kod == "l")
            //{
            //    Console.WriteLine("Limonata");
            //}
            //else
            //{
            //    Console.WriteLine("girilen kod cözülemedi");
            //}
            #endregion
            #region Ornek1
            //Ekrandan kullanıcı adi ve parola alinacak
            //dogru girmiş ise hosgeldiniz mesajı versin
            //Diğer türlü hangisinin hatalı oldgugunu ekrana yazsın
            //kullanıcı adi: admin, parola: qweasd

            string username, password;

            Console.Write("Username: ");
            username = Console.ReadLine();

            Console.Write("Password: ");
            password = Console.ReadLine();
            ////Normalde olmasi gereken
            ////if (username == "Admin" && password == "qweasd")
            ////{

            ////    Console.WriteLine("Hoşgeldiniz.");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Kullanıcı adınız ya da parolanız yanlıs.");
            ////}
            //if (username == "Admin")
            //{
            //    if (password == "qweasd")
            //    {
            //        Console.WriteLine("Hoşgeldiniz.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kullanıcı Adı dogru. ancak parola yanlış.");
            //    }
            //}
            #endregion
            #region ornek1 2.yol
            /*kod dogru şifre dogru
             * kod dogru sifre yanlıs
             * kod yanlıs şifre yanlıs
             * kod yanlıs sifre dogru
             */
            if (username == "Admin" && password == "qweasd")
            {
                Console.WriteLine("Hoşgeldiniz.");
            }
            else if (username == "Admin" && password != "qweasd")
            {
                Console.WriteLine("Username dogru. parola yanlış");
            }
            else if (username != "Admin" && password != "qweasd")
            {
                Console.WriteLine("Bütün bilgiler yanlış.");
            }
            else if (username != "Admin" && password == "qweasd")
            {
                Console.WriteLine("Username yanlış");
            }

            #endregion
        }
    }
}
