using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.Generics.UI
{
    public class MyDataStructure<T> : IMyDataStructure<T>
    {
        readonly IList<T> list = new List<T>();

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Remove(T item)
        {
            list.Remove(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public T Peek()
        {
           return list.Last<T>(); 
        }

        public int Count()
        {
            return (int)list.Count;
        }

        public void Display()
        {
            if(list.Count > 0)
            {
                foreach(T item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
