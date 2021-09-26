using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetsAndDictionaries
{
    class SetsOfElements
    {
        static void SetsElements()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < input[0]; i++)
            {
                var number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }
            for (int i = 0; i < input[1]; i++)
            {
                var number2 = int.Parse(Console.ReadLine());
                secondSet.Add(number2);
            }

            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
