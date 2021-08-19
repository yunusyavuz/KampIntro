using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Yunus";
            musteri1.SoyAdi = "Yavuz";
            musteri1.TcNo = "12345678901";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12345678";
            musteri2.SirketAdi = "YAVUZ INC.";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new Musteri();   
            Musteri musteri4 = new TuzelMusteri();   

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);




        }
    }
}
