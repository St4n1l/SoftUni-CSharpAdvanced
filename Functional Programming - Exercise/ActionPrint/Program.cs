using System;
using System.Linq;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {

            Action<string[]> print = strings =>
                Console.WriteLine(string.Join(Environment.NewLine, strings));

            print(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
