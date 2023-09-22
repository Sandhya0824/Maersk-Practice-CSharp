using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.Generics.UI
{
    interface IMyDataStructure<T>
    {
        void Add(T item);
        void Remove(T item);
        void Clear();
        T Peek();
        int Count();
        void Display();

    }
}
