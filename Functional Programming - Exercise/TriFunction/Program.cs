using System;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Func<string, int, bool> isNameEqualToOrLargerThanSum = (n, sum) => n.Sum(ch => ch) >= sum;
            Func<Func<string, int, bool>, string[], int, string> mainFunc = (f, na, val) =>
            {
                string validName = string.Empty;

                foreach (var name in na)
                {
                    if (f(name, val))
                    {
                        validName = name;
                        break;
                    }
                }

                return validName;
            };

            Console.WriteLine(mainFunc(isNameEqualToOrLargerThanSum, names, value));
        }
    }
}
