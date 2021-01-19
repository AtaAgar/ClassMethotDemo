using System;
using System.Collections.Generic;

namespace ClassMethotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Musteri musteri = new Musteri();

            musteri.Ad = "Mine";
            musteri.Soyad = "Akgül";
            musteri.Id = 1;


            Musteri musteri2 = new Musteri();

            musteri2.Ad = "Büşra";
            musteri2.Soyad = "Aksoy";
            musteri2.Id = 2;

            Musteri musteri3 = new Musteri();

            musteri3.Ad = "Binnaz";
            musteri3.Soyad = "Çabuk";
            musteri3.Id = 3;

            Musteri musteri4 = new Musteri();

            musteri4.Ad = "Yiğit";
            musteri4.Soyad = "Çabuk";
            musteri4.Id = 4;

            List<Musteri> musteriler = new List<Musteri>();

            musteriler.Add(musteri);
            musteriler.Add(musteri2);
            musteriler.Add(musteri3);
            musteriler.Add(musteri4);


            MusteriManager manager = new MusteriManager();

            manager.Ekle(musteri);
            manager.Sil(musteri);
            manager.Listele(musteriler);
        }
    }
}
