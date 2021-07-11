using System.Collections.Generic;

namespace CollectionHirahy
{
    class AddCollection : IAddable
    {
        public List<string> Collection { get; set; }

        public AddCollection()
        {
            Collection = new List<string>();
        }

        public int Add(string item)
        {
            Collection.Add(item);
            return Collection.Count - 1;
        }
    }
}
