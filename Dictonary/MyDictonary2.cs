using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
    class MyDictonary2<T, T2>
    {
                           //LİST KULLANARAK EKLEME İŞLEMİ
        List<T> Keys;
        List<T2> Value;

        public MyDictonary2()
        {

            Keys = new List<T>();
            Value = new List<T2>();
        }

        public void Add(T item, T2 item2)
        {
            Keys.Add(item);
            Value.Add(item2);

        }

        public int Count
        {
            get
            {
                return Keys.Count;
            }

        }

        public T2 Values
        {
            get { return Value[Value.Count - 1]; }
        }

        public T Key
        {
            get { return Keys[Keys.Count - 1]; }
        }
    }
}
