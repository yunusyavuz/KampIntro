using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Urun urun1= new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 19;
            urun2.Aciklama = "meşhur";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
            }


            Console.WriteLine("----------Metotlar------------");
            SepetManager sepetManager= new SepetManager();
            sepetManager.Ekle(urun1);

            sepetManager.Ekle2("beyaz elma", "tatli", 12);
        }
    }
}
