using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfOperations = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> allTexts = new Stack<string>();
            for (int i = 0; i < numOfOperations; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "1")
                {
                    text.Append(command[1]);
                    allTexts.Push(text.ToString());
                }
                else if (command[0] == "2")
                {
                    text.Remove(text.Length - int.Parse(command[1]), int.Parse(command[1]));
                    allTexts.Push(text.ToString());
                }
                else if (command[0] == "3")
                {
                    Console.WriteLine(text.ToString()[int.Parse(command[1]) - 1]);
                }
                else if (command[0] == "4")
                {
                    if (allTexts.Count > 1)
                    {
                        allTexts.Pop();
                        string newText = allTexts.Peek();
                        text.Clear();
                        for (int j = 0; j < newText.Length; j++)
                        {
                            text = text.Append(newText[j]);
                        }
                    }
                    else
                    {
                        allTexts.Pop();
                        text.Clear();
                    }

                }
            }
        }
    }
}
