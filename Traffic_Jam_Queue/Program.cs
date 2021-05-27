namespace Traffic_Jam_Queue
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Queue<string> cars = new Queue<string>();
            int count = 0;

            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count == 0)
                            break;

                        string currentCar = cars.Dequeue();
                        Console.WriteLine($"{currentCar} passed!");
                        count++;
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}