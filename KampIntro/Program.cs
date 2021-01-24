using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            String kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDun < dolarBugun) 
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
