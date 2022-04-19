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

            //string username, password;

            //Console.Write("Username: ");
            //username = Console.ReadLine();

            //Console.Write("Password: ");
            //password = Console.ReadLine();
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
            //if (username == "Admin" && password == "qweasd")
            //{
            //    Console.WriteLine("Hoşgeldiniz.");
            //}
            //else if (username == "Admin" && password != "qweasd")
            //{
            //    Console.WriteLine("Username dogru. parola yanlış");
            //}
            //else if (username != "Admin" && password != "qweasd")
            //{
            //    Console.WriteLine("Bütün bilgiler yanlış.");
            //}
            //else if (username != "Admin" && password == "qweasd")
            //{
            //    Console.WriteLine("Username yanlış");
            //}

            #endregion
            #region Ornek2
            /*Girilen not 0-30 araligi ise "FF" 30-50 araligi
             * "DD" 50-70 "BB" 70-100 "AA" aldınız şeklinde
             * kullanıcıyı uyarınız..
             */
            //int not;
            //Console.Write("Notunuzu giriniz: ");
            //not = int.Parse(Console.ReadLine());

            //if (not <= 30)
            //{
            //    Console.WriteLine("Harf Notunuz:FF");
            //}
            //else if (not >= 30 && not < 50)
            //{
            //    Console.WriteLine("Harf Notunuz:DD");
            //}
            //else if (not >= 50 && not < 70)
            //{
            //    Console.WriteLine("Harf Notunuz:BB");
            //}
            //else if (not >= 70 && not < 100)
            //{
            //    Console.WriteLine("Harf Notunuz:AA");
            //}
            //else
            //{
            //    Console.WriteLine("Böyle bir not yok");
            //}



            #endregion
            #region Ornek3
            /*Disaridan urun adi girilecek, kasiyer bize ürünün hangi reyonda oldugunu soyleyecek..
             * domates,biber,patlican=>sebze reyonu
             * diş macunu,parfüm,sampuan=kozmetik
             * cep tel, bilgisayar, ses sistemi=tekno.
             * baska bi ürüne bizde yok uyarısı
             */
            //string input;
            //Console.WriteLine("Ne ariyorsunuz?");
            //input = Console.ReadLine();

            //if (input == "Domates" || input == "Biber" || input == "Patlıcan")
            //{
            //    Console.WriteLine("Lütfen sebze reyonuna gidiniz.");
            //}
            //else if (input == "Diş Macunu" || input == "Parfüm" || input == "Şampuan")
            //{
            //    Console.WriteLine("Lütfen kozmetik reyonuna gidiniz.");
            //}
            //else if (input == "Cep Telefonu" || input == "Bilgisayar" || input == "Ses Sistemi")
            //{
            //    Console.WriteLine("Lütfen Teknoloji reyonuna gidiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Bu ürün bizde yok!");
            //}





            #endregion
            #region Ornek4
            /*
             * Dısarıdan siparis alınacak kitap miktari girilsin.
             * siparis sayısı 20'den azsa toplam ucretten %5,
             * 20-50 aralıgında ise %10, 50-100 araliği ise %15,
             * 100den fazla ise %25 indirim yapılsın
             * kitabın birim fiyatı =5 TL
             * amac= odenecek tutarı kullanıcıya göstermek
             */
            #endregion
            #region Odev
            /*
             Kullanicidan 2 sayi alin
             Birde Ekrana [+,-,/,*] 
            Bunlardan hangisini girdi ise ona gore işlem yapin
             */
            //int sayi1, sayi2;
            //string input;
            //Console.Write("1.Sayıyı giriniz: ");
            //sayi1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı giriniz: ");
            //sayi2 = int.Parse(Console.ReadLine());

            //Console.Write("İşlem seçiniz: (+,-,/,*): ");
            //input =  Console.ReadLine();
            //if(input == "+")
            //{
            //    Console.WriteLine("Sonuç: " +(sayi1+sayi2));
            //}else if(input == "-")
            //{
            //    Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
            //}else if (input == "*")
            //{
            //    Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
            //}else if (input == "/")
            //{
            //    Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
            //}else
            //{ Console.WriteLine("Yanlış girdi."); }


            /*
             Soru 2: Ekrandan girilen mevsime gore aylari bastirin.
             */
            string input;
            Console.Write("Mevsim giriniz: ");
            input = Console.ReadLine();

            if (input == "Kış" || input == "KIŞ" || input == "kış")
            {
                Console.WriteLine("ARALIK,OCAK,ŞUBAT");
            }
            else if (input == "İlkbahar" || input == "İLKBAHAR" || input == "ilkbahar")
            {
                Console.WriteLine("MART,NİSAN,MAYIS");
            }
            else if (input == "Yaz" || input == "YAZ" || input == "yaz")
            {
                Console.WriteLine("HAZİRAN,TEMMUZ,AĞUSTOS");
            }
            else if (input == "Sonbahar" || input == "SONBAHAR" || input == "sonbahar")
            {
                Console.WriteLine("EYLÜL,EKİM,KASIM");
            }
            else
            {
                Console.WriteLine("Böyle bir mevsim yok!");
            }
            /*
             Ekrandan suyun sicakligini alin. Ve Kati ,sivi ,Gaz halini belirleyin
             */

            /*
             Girilen bir tam sayinin kaç basamakli oldugunu ekrana yaziniz.
             
             */
            #endregion
        }
    }
}
