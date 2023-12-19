using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDouble
{
    class Box<T> where T : IComparable<T>
    {
        public Box()
        {
            Item = new List<T>();
        }
        public List<T> Item { get; set; }

        public int Count(T comparable)
        {
            int counter = 0;
            foreach (var item in Item)
            {
                if (item.CompareTo(comparable) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
