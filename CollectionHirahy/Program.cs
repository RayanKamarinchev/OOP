using System;
using System.Collections.Generic;

namespace CollectionHirahy
{
    class Program
    {
        static void Main(string[] args)
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList list = new MyList();
            string[] items = Console.ReadLine().Split();
            List<int> outputAdd = new List<int>();
            List<int> outputAddRemove = new List<int>();
            List<int> outputList = new List<int>();

            foreach (var item in items)
            {
                outputAdd.Add(addCollection.Add(item));
                outputAddRemove.Add(addRemoveCollection.Add(item));
                outputList.Add(list.Add(item));
            }
            Console.WriteLine(string.Join(" ", outputAdd));
            Console.WriteLine(string.Join(" ", outputAddRemove));
            Console.WriteLine(string.Join(" ", outputList));
            int n = int.Parse(Console.ReadLine());
            List<string> outputRemovedItems = new List<string>();
            List<string> outputListRemovedItems = new List<string>();
            for (int i = 0; i < n; i++)
            {
                outputRemovedItems.Add(addRemoveCollection.Remove());
                outputListRemovedItems.Add(list.Remove());
            }
            Console.WriteLine(string.Join(" ",outputRemovedItems));
            Console.WriteLine(string.Join(" ",outputListRemovedItems));
        }
    }
}
