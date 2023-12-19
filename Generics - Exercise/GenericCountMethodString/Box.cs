using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodString
{
    public class Box<T> where T : IComparable
    {
        public Box()
        {
            Item = new List<T>();
        }
        public List<T> Item { get; set; }

        public int Count(T comparedValue)
        {
            int counter = 0;

            foreach (var item in Item)
            {
                if (item.CompareTo(comparedValue)>0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
