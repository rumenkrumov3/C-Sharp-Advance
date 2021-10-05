using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionalProgramming
{
    class ReverseAndExclude
    {
        static void ReverseAndExcluded()
        {
            var numbersAsString = Console.ReadLine().Split(" ").Select(int.Parse).Reverse().ToList();
            int divide = int.Parse(Console.ReadLine());
            Func<int, int, bool> predicate = (num,div) => num % div == 0;

            for (int i = 0; i < numbersAsString.Count; i++)
            {
                if (!predicate(numbersAsString[i], divide))
                {
                    Console.Write($"{numbersAsString[i]} ");
                }
            }
        }
    }
}
