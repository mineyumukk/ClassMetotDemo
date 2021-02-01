using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 15846;
            musteri1.MusteriAdi = "Nazlı";
            musteri1.MusteriSoyadi = "YILMAZ";
            musteri1.MusteriTcNo = "54234568123";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 58467;
            musteri2.MusteriAdi = "Yunus";
            musteri2.MusteriSoyadi = "MÜMTAZOĞLU";
            musteri2.MusteriTcNo = "26845792865";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 85694;
            musteri3.MusteriAdi = "Kayra";
            musteri3.MusteriSoyadi = "KAYA";
            musteri3.MusteriTcNo = "42657123854";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            Console.WriteLine("***********************");

            musteriManager.MusteriCikar(musteri1);
            musteriManager.MusteriCikar(musteri2);
            Console.WriteLine("***********************");

            Console.WriteLine("Müşteriler Listelendi! ");
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriListele(musteri3);
            Console.WriteLine("***********************");



            Console.ReadLine();
        }
    }
}
