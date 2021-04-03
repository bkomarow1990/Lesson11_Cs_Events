using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            AList<int> list = new AList<int>(2, 5, 7, 4, 3, 2);
            list.Insert(3, 111);
            Console.WriteLine($"Index of 111: {list.IndexOf(111)}");
            Console.WriteLine(list);
            Console.WriteLine("Removing at index 2: ");
            list.RemoveAt(2);
            Console.WriteLine(list);
            Console.WriteLine($"Elem with index 3 - {list[3]}");
            Console.WriteLine($"List contains 2: {list.Contains(2)}");
            Console.WriteLine("Add 228 in end");
            list.Add(228);
            Console.WriteLine(list);
            Console.WriteLine("Removing 2: ");
            list.Remove(2);
            //int[] arr = new int[5]{1, 2, 3, 4, 5};
            Console.WriteLine($"Find Element (5): {list.Find(e=> e== 5)}");
            Console.WriteLine(list);
        }
    }
}
