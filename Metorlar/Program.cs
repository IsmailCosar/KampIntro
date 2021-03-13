using System;

namespace Metorlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product elma = new Product();
            elma.Adi = "Elma";
            elma.Fiyati = 15;
            elma.Aciklama = "Amasya elması";
            elma.StokAdedi = 10;

            Product cilek = new Product();
            cilek.Adi = "Çilek";
            cilek.Fiyati = 80;
            cilek.Aciklama = "Diyarbakır karpuzu";
            cilek.StokAdedi = 1;

            Product[] urunler = new Product[] { elma, cilek };

            //type-safe -- tip güvenli
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------------------");
            }

            Console.WriteLine("--------Metotlar-------");

            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(elma);
            sepetManager.Ekle(cilek);

            //X
            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Kırmızı", 12, 8);

            //Dont repeat yourself - DRY Kendini tekrar etme - Clean Code - Best Prictice
        }
    }
}
