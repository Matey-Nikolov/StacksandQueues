namespace MatchingBrackets
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Stack<int> indexStack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == '(')
                {
                    indexStack.Push(i);
                }
                else if (currentChar == ')')
                {
                    int startIndex = indexStack.Pop();
                    string bracketsNums = input
                        .Substring(startIndex, i - startIndex + 1);

                    Console.WriteLine(bracketsNums);
                }
            }
        }
    }
}
