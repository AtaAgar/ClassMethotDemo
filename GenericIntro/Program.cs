using System;

namespace GenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            // T string tipini alır

            isimler.Add("Engin");

            Console.WriteLine(isimler.Count);

            Console.WriteLine(isimler.Kisi);
        }
    }
}
