using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class AList<T> : IMyList<T>, IMyCollection<T>
    { 
            T[] arr = new T[0];

        public int Count => arr.Length;

        public int Capacity => arr.Length;

        private bool IsCorrectIndex(int index)
            {
                if (index < 0 || index >= arr.Length)
                {
                    return false;
                }
                return true;
            }

        public int IndexOf(T item) // return -1 if coldn`t find element
        {
            return Array.FindIndex(arr, e =>  e.Equals(item) );
        }
        public AList(params T []elems)
        {
            arr = elems;
        }
        public AList()
        {

        }
        public void Insert(int index, T item)
        {
            if (!IsCorrectIndex(index))
            {
                throw new Exception("Incorrect index");
            }
            T[] tmp = (T[])arr.Clone();
            arr = new T[tmp.Length+1];
            for (int i = 0, j = 0 ; i < arr.Length; i++, j++)
            {
                if (index == i )
                {
                    arr[i] = item;
                    j = i - 1;
                }
                else {
                    arr[i] = tmp[j];
                }
                
            }
        }

        public void RemoveAt(int index)
        {
            if (!IsCorrectIndex(index))
            {
                throw new Exception("Incorrect index");
            }
            T[] tmp = (T[])arr.Clone();
            arr = new T[arr.Length-1];
            for (int i = 0,j=0; i < arr.Length; ++i,++j)
            {
                if (index == i)
                {
                    ++j;
                }
                arr[i] = tmp[j];
            }
        }
        public override string ToString()
        {
            return $"List: {String.Join(" ", arr)}"; 
        }

        public void Clear()
        {
            Array.Clear(arr,0,arr.Length);
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index == -1)
            {
                return false;
            }
            RemoveAt(index);
            return true;
        }

        public void Add(T element)
        {
            
            T[] tmp = new T[arr.Length];
            arr.CopyTo(tmp, 0);
            arr = new T[tmp.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    arr[i] = element;
                }
                else {
                    arr[i] = tmp[i];
                }
                
                
            }
        }
        public int LastIndexOf(T elem)
        {
            return Array.LastIndexOf(arr, elem);
        }
        List<T> FindAll(Predicate<T> match)
        {
            List<T> list = new List<T>();
            foreach (T item in arr)
            {
                if (match(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
        public T Find(Predicate<T> match)
        {
           
            foreach (T item in arr)
            {
                if (match(item))
                {
                    return item;
                    
                }
            }
            return default(T);

        }
        public T this[int index]
            {
                get
                {
                    if (IsCorrectIndex(index))
                    {
                        return arr[index];
                    }
                    throw new Exception("Incorrect index");
                }
                set
                {
                    if (IsCorrectIndex(index))
                    {
                        this.arr[index] = value;
                    }
                }
            }
        }
    }