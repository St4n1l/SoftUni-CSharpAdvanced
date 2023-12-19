using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfInteger
{
    public class Box<T>
    {

        public Box()
        {
            Items = new List<T>();
        }

        public List<T> Items { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Items)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString();
        }
    }
}