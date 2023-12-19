using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class ListyIterator<T> : IEnumerable<T>
    {
        private int index = 0;
        private List<T> items;
        public ListyIterator(List<T> items)
        {
            this.items = items;

        }

        public bool Move()
        {
            if (index + 1 < items.Count)
            {
                index++;
                return true;
            }
            return false;

        }

        public bool HasNext()
        {
            return index < items.Count - 1;
        }

        public void Print()
        {
            if (items.Count > 0)
            {
                Console.WriteLine(items[index]);
            }
            else
            {
                throw new InvalidOperationException($"Invalid Operation!");
            }
        }

        public void PrintAll()
        {
            if (items.Count > 0)
            {
                Console.WriteLine(string.Join(' ',items));
            }
            else
            {
                throw new InvalidOperationException($"Invalid Operation!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
