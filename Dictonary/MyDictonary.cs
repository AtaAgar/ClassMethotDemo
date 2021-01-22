using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
    class MyDictonary<T,T2>
    {
                                               // DİZİ KULLANARAK EKLEME İŞLEMİ
        T[] _keys ;
        T2[] _values;
      

        public MyDictonary()
        {
           
           _keys = new T[0];
           _values = new T2[0];
        }

        public void Add(T item, T2 item2)
        {
            T[] tempArray = _keys;
            T2[] tempArray2 = _values;

            _keys = new T[_keys.Length + 1];
            _values = new T2[_values.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
               _keys[i] = tempArray[i];
                
            }

            _keys[_keys.Length - 1] = item;

            for (int j = 0; j < tempArray.Length;j++)
            {
                _values[j] = tempArray2[j];
            }
            _values[_values.Length - 1] = item2;
        }

        public int Count
        {
            get { 
                return _keys.Length; }
            
        }

        public T2 Values
        {
            get { return _values[_values.Length - 1]; }
        }

        public T Key
        {
            get { return _keys[_keys.Length - 1]; }
        }
    }
   
}
