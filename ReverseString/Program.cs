using System;
using System.Collections.Generic;

namespace ReverseString
{
    class Program
    {
        static void Main()
        {
            
            Stack<char> stack = new Stack<char>();
            
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                stack.Push(currentChar);
            }

            //Console.WriteLine(string.Join("", stack));
            
            while (stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}