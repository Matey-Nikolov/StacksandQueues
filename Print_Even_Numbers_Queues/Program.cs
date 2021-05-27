namespace Print_Even_Numbers_Queues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Queue<int> nums = new Queue<int>();
            
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int num = numbers[i];

                if (num % 2 == 0)
                {
                    nums.Enqueue(num);
                }
            }
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}