using System;
using System.Collections.Generic;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            int popedElement = stack.Pop(); // Remove and return last element.
            int peekElement = stack.Peek(); // Return last element without removing

            Console.WriteLine(popedElement);
            Console.WriteLine(peekElement);
            Console.WriteLine("*************");
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
