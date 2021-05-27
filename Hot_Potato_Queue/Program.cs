namespace Hot_Potato_Queue
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> children = new Queue<string>(input);

            int n = int.Parse(Console.ReadLine());

            while (children.Count > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i == n)
                    {
                        string removedChild= children.Dequeue();
                        Console.WriteLine($"Removed {removedChild}");
                    }
                    else
                    {
                        string currnetChild = children.Dequeue();
                        children.Enqueue(currnetChild);
                    }
                }
            }
            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}