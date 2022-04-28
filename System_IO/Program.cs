using System;
using System.IO;

namespace System_IO // System Input/Output Kütüphanesi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DriveInfo => bilgisayarınızdaki sürücü bilgilerine erişim imkanı verir

            DriveInfo[] driveInfos = DriveInfo.GetDrives();

            foreach (var drive in driveInfos)
            {
                Console.WriteLine(drive.Name);
                Console.WriteLine(drive.TotalSize);
                Console.WriteLine(drive.DriveType);
                Console.WriteLine(drive.TotalFreeSpace);
                Console.WriteLine(drive.DriveFormat);
                Console.WriteLine(drive.IsReady);
            }

            //DirectoryInfo => Sürücülerdeki klasörleri verir

            string[] dirs = Directory.GetDirectories(@"c:\");
            if (Directory.Exists(@"c:\BenimKlasorum"))
            {
                Directory.CreateDirectory(@"c:\BenimKlasorum");
            }

            foreach (var item in dirs)
            {
                Console.WriteLine(item);
            }

            DosyaOlustur();

            Console.WriteLine("Hello World!");
        }

        private static void DosyaOlustur()
        {
            FileStream fi = File.Create(@"c:\BenimKlasorum\test.txt");
            Byte[] buffer = new UTF8Encoding(true)
        }
    }
}
