using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici...";
            string kurs2 = "Program Geliştirici...";
            string kurs3 = "Java Geliştirici...";

            // array - dizi
            // kurslar.Length kursalar dizininde kaçtane eleman varsa onu alır

            string[] kurslar = new string[]
            { "Yazılım Geliştirici...",
              "Program Geliştirici...",
              "Java Geliştirici..." };

            //tekrarlama
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("1. Yöntem Bitti");

            //tekrarlama yöntem 2
            //in kurslar = Kursları dolaş
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("2. Yöntem Bitti");


            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
