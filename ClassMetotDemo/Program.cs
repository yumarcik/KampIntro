using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.AdSoyad = "Raja Kim";
            musteri1.Id = "RK";
            musteri1.Yas = 31;

            Musteri musteri2 = new Musteri();
            musteri2.AdSoyad = "Sasha Jones";
            musteri2.Id = "SJ";
            musteri2.Yas = 24;

            Musteri musteri3 = new Musteri();
            musteri3.AdSoyad = "Eliza Martin";
            musteri3.Id = "EM";
            musteri3.Yas = 19;

            MusteriManager manager = new MusteriManager(3);
            manager.Ekle(musteri1);
            manager.Ekle(musteri2);
            manager.Ekle(musteri3);
            manager.Listele();
            manager.Cikar(musteri2);
            manager.Listele();
           
            
        }
    }
}
