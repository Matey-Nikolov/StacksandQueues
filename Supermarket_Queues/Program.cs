namespace Supermarket_Queues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Queue<string> names = new Queue<string>();

            string customerName = Console.ReadLine();

            while (customerName != "End")
            {

                if (customerName == "Paid")
                {
                    while (names.Count != 0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }

                }
                else
                {
                    names.Enqueue(customerName);
                }
                customerName = Console.ReadLine();
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}