using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        // variables
        Musteri[] musteriler;
        int index = 0;
        // constructor
        public MusteriManager(int kisiSayisi)
        {
            musteriler = new Musteri[kisiSayisi];
        }
        // methods
        public void Ekle(Musteri musteri)
        {
            
            if (index < musteriler.Length)
            {
                musteriler[index] = musteri;
                index++;
                Console.WriteLine(musteri.AdSoyad + " isimli müşteri sisteme eklenmiştir.");
            }
            else
            {
                Console.WriteLine("Limit aşıldığı için eklenemez.");
            }                        
        }

        public void Cikar(Musteri musteri)
        {
            bool bulunduMu = false;
            for(int i = 0; i < musteriler.Length; i++)
            {
                if(musteriler[i] == musteri)
                {
                    bulunduMu = true;
                    
                }
                else if(bulunduMu == true) {
                    musteriler[i - 1] = musteriler[i];
                }
            }

            if (bulunduMu == true)
            {
                musteriler[musteriler.Length - 1] = null;
                index--;
                Console.WriteLine(musteri.AdSoyad + " isimli müşteri sistemden çıkartılmıştır.");
            }
            else
            {
                Console.WriteLine("Listede böyle bir müşteri yok.");
            }
            
        }

        public void Listele()
        {
            for(int i = 0; i < musteriler.Length; i++)
            {
                if (musteriler[i] != null)
                {
                    Console.WriteLine(musteriler[i].AdSoyad + " " + musteriler[i].Yas);
                }
            }
        }
    }
}
