using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    class Box<T>
    {
        private T input;

        public Box(T input)
        {
            InputToString = input.ToString();
        }

        public string InputToString { get; set; }

        public override string ToString()
        {
            string result = $"{InputToString.GetType()}: {InputToString}";
            return result;
        }
    }
}
