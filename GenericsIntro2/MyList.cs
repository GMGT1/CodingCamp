using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro2
{
    class MyList<T>
    {
        T[] items;
        
        //constructor 
        //Bir class newlendiğinde çalışan bloğa contructor denir. newlemek bellekte referans oluştur demektir. 
        public MyList()
        {
            items = new T[0];  
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

        public void Show()
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

    }   

}
