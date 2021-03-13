using System;
using System.Collections.Generic;
using System.Text;

namespace Metorlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete EKLENDİ : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokaAdedi)
        {
            Console.WriteLine("Sepete EKLENDİ : " + urunAdi);
        }
    }
}
