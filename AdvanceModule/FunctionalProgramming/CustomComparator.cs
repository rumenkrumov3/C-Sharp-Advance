using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionalProgramming
{
    class CustomComparator
    {
        static void CustomComparatorr()
        {
            var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var listOfEvens = new List<int>();
            var listOfOdds = new List<int>();
            Predicate<int> isEven = number => number % 2 == 0;
            Predicate<int> isOdd = number => Math.Abs(number) % 2 == 1;
            Action<List<int>> print = Print;

            foreach (var item in numbers)
            {
                if (isEven(item))
                {
                    listOfEvens.Add(item);
                }
                else if (isOdd(item))
                {
                    listOfOdds.Add(item);
                }
            }

            var orderedListOfEvens = listOfEvens.OrderBy(x => x).ToList();
            var orderedListOfOdds = listOfOdds.OrderBy(x => x).ToList();

            print(orderedListOfEvens);
            print(orderedListOfOdds);

        }

        private static void Print(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
