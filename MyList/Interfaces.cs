using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public interface IMyList<T>
    {
        int IndexOf(T item);
        void Insert(int index, T item);
        void RemoveAt(int index);
        T this[int index] { get; set; }
    }
    public interface IMyCollection<T>
    {
        public int Count { get; }
        public int Capacity { get; }
        void Clear();
        bool Contains(T item);
        bool Remove(T item);
        void Add(T element);

    }
}
