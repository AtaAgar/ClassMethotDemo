using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethotDemo
{
   public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }


    }


    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("  MÜŞTERİ EKLEME");
            Console.WriteLine("********************");
            Console.WriteLine(musteri.Ad +" "+ musteri.Soyad+" "+musteri.Id+" "+ "eklendi");
            Console.WriteLine();
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("  MÜŞTERİ SİLME");
            Console.WriteLine("********************");
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad+" "+"adlı" + " " + musteri.Id+" "+ "id'sine sahip müşteri silindi" );
            Console.WriteLine();
        }
        public void Listele(List<Musteri> musteriler)
        {
            Console.WriteLine("  MÜŞTERİ LİSTESİ");
            Console.WriteLine("********************");
            Console.WriteLine();
            foreach (Musteri m in musteriler)
            {
                Console.WriteLine("Müşteri Ad Soyad:"+" "+m.Ad+" "+ m.Soyad+" "+" Müşteri Id:"+" "+m.Id);
              
            }
           
        }

    }
}
