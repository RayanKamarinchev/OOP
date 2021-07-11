using System.Collections.Generic;

namespace CollectionHirahy
{
    class AddRemoveCollection : IAddable, IRemoveable
    {
        public Queue<string> Collection { get; set; }

        public AddRemoveCollection()
        {
            Collection = new Queue<string>();
        }

        public int Add(string item)
        {
            Collection.Enqueue(item);
            return 0;
        }

        public string Remove()
        {
            return Collection.Dequeue();
        }
    }
}
