namespace StackSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(nums);              

            while (true)
            {
                string command = Console.ReadLine().ToLower();

                if (command == "end")
                {
                    break;
                }

                string[] commandArguments = command
                    .Split();

                string currentCommand = commandArguments[0];

                switch (currentCommand)
                {
                    case "add":
                        stack.Push(int.Parse(commandArguments[1]));
                        stack.Push(int.Parse(commandArguments[2]));
                        break;

                    case "remove":
                        if (stack.Count < int.Parse(commandArguments[1]))
                        {
                            continue;
                        }

                        for (int i = 0; i < int.Parse(commandArguments[1]); i++)
                        {
                            stack.Pop();
                        }
                        break;
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
