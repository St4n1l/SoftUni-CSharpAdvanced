using System;

namespace RecursiveFactorial
{
    public class Program
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(num));
        }

        static long Factorial(long n)
        {
            if (n == 1) return 1;
            else return n * Factorial(n - 1);
        }
    }
}