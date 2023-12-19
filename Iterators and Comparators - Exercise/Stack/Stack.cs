using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Stack<T> : IEnumerable<T>
    {
        private List<T> stack;

        public Stack()
        {
            stack = new List<T>();
        }


        public void Push(T el)
        {
            stack.Insert(0,el);
        }
        public T Pop()
        {
            if (stack.Count == 0)
            {
               throw new InvalidOperationException("No elements");
            }
            else
            {
                T firstElement = stack[0];
                stack.RemoveAt(0); 
                return firstElement;
            }
        }

        public T Peek()
        {
            return stack[0];
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var el in stack)
            {
                yield return el;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
