using System;
using System.Collections.Generic;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {

          
            MyDictonary2<int, string>Ogrenci=new MyDictonary2<int, string>();

            Ogrenci.Add(123, "Binnaz");
            Ogrenci.Add(124, "Mine");
            Ogrenci.Add(125, "Büşra");

            Console.WriteLine("Boyutu:"+Ogrenci.Count);
            Console.WriteLine(Ogrenci.Values);
            Console.WriteLine(Ogrenci.Key);


            Console.WriteLine("array kullanılarak yapılan kod");
             // ARRAY KULLANARAK KAYIT YAPMAK İÇİN  MyDictonary classını kullanmak gerekli

            MyDictonary<int, string> Ogrenci2 = new MyDictonary<int, string>();

            Ogrenci2.Add(123, "Binnaz");
            Ogrenci2.Add(124, "Mine");
            Ogrenci2.Add(125, "Büşra");

            Console.WriteLine("Boyutu:" + Ogrenci2.Count);
            Console.WriteLine(Ogrenci2.Values);
            Console.WriteLine(Ogrenci2.Key);

            
        }
    }
}
