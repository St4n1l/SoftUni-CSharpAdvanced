using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string parenthesis = Console.ReadLine();
            Stack<char> closingParenthesis = new Stack<char>();
            for (int i = 0; i < parenthesis.Length; i++)
            {
                if (parenthesis[i] == '{' || parenthesis[i] == '(' || parenthesis[i] == '[')
                {
                    closingParenthesis.Push(parenthesis[i]);
                    continue;
                }

                if (parenthesis[i] == '}')
                {
                    if (closingParenthesis.Count == 0)
                    {
                        Console.WriteLine($"NO");
                        return;
                    }
                    else
                    {
                        if (closingParenthesis.Peek() == '{')
                        {
                            closingParenthesis.Pop();
                        }
                        else
                        {
                            Console.WriteLine($"NO");
                            return;
                        }
                    }
                }
                else if (parenthesis[i] == ']')
                {
                    if (closingParenthesis.Count == 0)
                    {
                        Console.WriteLine($"NO");
                        return;
                    }
                    else
                    {
                        if (closingParenthesis.Peek() == '[')
                        {
                            closingParenthesis.Pop();
                        }
                        else
                        {
                            Console.WriteLine($"NO");
                            return;
                        }
                    }
                }
                else if (parenthesis[i] == ')')
                {
                    if (closingParenthesis.Count == 0)
                    {
                        Console.WriteLine($"NO");
                        return;
                    }
                    else
                    {
                        if (closingParenthesis.Peek() == '(')
                        {
                            closingParenthesis.Pop();
                        }
                        else
                        {
                            Console.WriteLine($"NO");
                            return;
                        }
                    }
                }


            }

            if (closingParenthesis.Count == 0)
            {
                Console.WriteLine($"YES");
            }
            else
            {
                Console.WriteLine($"NO");
            }
        }
    }
}