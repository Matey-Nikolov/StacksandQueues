using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var values = input.Split(' ');

            Stack<string> stack = new Stack<string>(values.Reverse()); 

            while (stack.Count > 1)
            {
                int firstElement = int.Parse(stack.Pop()); // 2
                string operand = stack.Pop(); // + 
                int seconElement = int.Parse(stack.Pop()); // 5

                if (operand == "+")
                {
                    int result = firstElement + seconElement;
                    stack.Push(result.ToString());
                }
                else
                {
                    int result = firstElement - seconElement;
                    stack.Push(result.ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
