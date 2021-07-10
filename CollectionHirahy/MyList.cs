using System.Collections.Generic;

namespace CollectionHirahy
{
    class MyList : IAddable, IRemoveable, IUseable
    {
        public Stack<string> Collection { get; set; }
        public int Count { get ; set ; }

        public MyList()
        {
            Collection = new Stack<string>();
            Count = 0;
        }

        public int Add(string item)
        {
            Count++;
            Collection.Push(item);
            return 0;
        }

        public string Remove()
        {
            Count--;
            return Collection.Pop();
        }
    }
}
