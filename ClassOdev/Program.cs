using System;

namespace ClassOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Ayakkabi nike1 = new Ayakkabi();
            nike1.aadi = "Nike";
            nike1.marka = "Air Force 17-156-156";
            nike1.oncekiFiyat = 1100;
            nike1.indirimFiyat = 999;

            Ayakkabi nike2 = new Ayakkabi();
            nike2.aadi = "Nike";
            nike2.marka = "Air Jordan 17-12213-2316";
            nike2.oncekiFiyat = 1800;
            nike2.indirimFiyat = 899;

            Ayakkabi nike3 = new Ayakkabi();
            nike3.aadi = "Nike";
            nike3.marka = "Air Max 1723-15426-156";
            nike3.oncekiFiyat = 959;
            nike3.indirimFiyat = 599;

            Ayakkabi[] ayakkabiler = new Ayakkabi[] { nike1, nike2, nike3 };

            foreach (var ayakkabi in ayakkabiler)
            {
                Console.WriteLine(ayakkabi.aadi + " " + ayakkabi.marka + " : " + ayakkabi.oncekiFiyat + " TL");
            }
        }
        class Ayakkabi
        {
            public string marka { get; set; }
            public string aadi { get; set; }
            public int oncekiFiyat { get; set; }
            public int indirimFiyat { get; set; }
        }
    }
}
