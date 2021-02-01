using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Yeni müşteri eklendi!: " + musteri.MusteriAdi + " " +musteri.MusteriSoyadi);
        }

        public void MusteriCikar(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId + " Id'ye Sahip Müşteri Çıkarıldı." );
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId+" "+musteri.MusteriAdi+" "+musteri.MusteriSoyadi );
        }

    }
}
