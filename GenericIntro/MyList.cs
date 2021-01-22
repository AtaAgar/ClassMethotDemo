using System;
using System.Collections.Generic;
using System.Text;

namespace GenericIntro
{
    class MyList<T>
        //generic sınıf  New'lediğimizde hangi veri tipini verirsek "T" o tipe bürünür.
    {
        T[] items;

        //CONSTRUCTOR
        public MyList()
        {
            items = new T[0]; 
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];

            for(int i=0; i<tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

        public int Count
        {
            get { return items.Length; }
        }

        public T Kisi
        {
            get { return items[items.Length-1]; }
        }
    }
}
