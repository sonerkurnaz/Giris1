using System;

namespace HazirMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OrnekCompare();
            //OrnekStartwith()
            //OrnekIndexOf();
            //OrnekRemove();
            //OrnekReplace();
            //OrnekSplit();
            //OrnekInsert();
            //OrnekToUpperToLower();
            //OrnekToCharArray();
            //OrnekTrim();
            OrnekSubString();
        }

        private static void OrnekSubString()
        {
            string ornekMetin = "Bugün hava çok guzel";
            //1.Kullanım
            string yeniMetin= ornekMetin.Substring(5);
            Console.WriteLine(yeniMetin);
            //2.Kullanım
            Console.WriteLine(ornekMetin.Substring(6,4));
        }

        private static void OrnekTrim()
        {
            string ornekMetin = "    Bugün hava çok guzel      ";
            Console.WriteLine(ornekMetin.Trim());
            
        }

        private static void OrnekToCharArray()
        {
            string ornekMetin = "Bugün hava çok guzel";
            char[] harfler = ornekMetin.ToCharArray();
            
        }

        private static void OrnekToUpperToLower()
        {
            string ornekMetin = "Bugün hava çok guzel";
            Console.WriteLine(ornekMetin.ToLower());
            Console.WriteLine(ornekMetin.ToUpper());

        }

        private static void OrnekInsert()
        {
            string ornekMetin = "Bugün hava çok guzel";
            string yeniMetin = ornekMetin.Insert(11,"çok ");
            Console.WriteLine(yeniMetin);
        }

        private static void OrnekSplit()
        {
            string ornekMetin = "Sultangazi'de 5 katlı apartmanın çatısına çıkan çocuk canını hiçe sayarak temizlik yapmaya başladı. Çatının ucunu kadar ilerleyip dakikalarca orada duran çocuğun o anları saniye saniye kameraya yansıdı.";
            string[] cumleler = ornekMetin.Split(".");
        }

        private static void OrnekReplace()
        {
            string ornekMetin = "Bugün hava çok guzel";
            string yeniMetin = ornekMetin.Replace("guzel", "berbat");
            Console.WriteLine(ornekMetin);
            Console.WriteLine(yeniMetin);
        }

        private static void OrnekRemove()
        {
            string ornekMetin = "Bugün hava çok guzel";
            


        }

        private static void OrnekIndexOf()
        {
            string ornekMetin = "Bugün hava çok guzel";
            int index = ornekMetin.IndexOf('a');
            Console.WriteLine("Index Numarası: " + index);
            index = ornekMetin.LastIndexOf('u');
            Console.WriteLine("LastIndex Numarası: " + index);
        }

        public static void OrnekStartwith()
        {

            string ornekMtin = Console.ReadLine();
            bool result = ornekMtin.StartsWith("bil");
            if (result)
            {
                Console.WriteLine("Cümle bil ile başlamaktadır.");
            }
            else
            {
                Console.WriteLine("Cümle bil ile başlamamaktadır.");
            }
        }

        private static void OrnekCompare()
        {
            #region OrnekMetin1


            string ornekMetin = Console.ReadLine();
            int sonuc = ornekMetin.CompareTo("bilgeadam");
            string mesaj = "";
            switch (sonuc)
            {
                case -1:
                    mesaj = "Kelime diğer kelime ile eşleşmektedir." +
                    "Eksik karakter var";
                    break;
                case 0:
                    mesaj = "Tebrikler! Kelimeler eşleşmektedir";
                    break;
                case 1:
                    mesaj = "Kelime diğer kelime ile eşleşmemektedir fazla karakter var";
                    break;
                default:
                    break;
            }
            Console.WriteLine(mesaj);
            #endregion
        }
    }
}
