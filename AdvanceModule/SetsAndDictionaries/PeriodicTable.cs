using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetsAndDictionaries
{
    class PeriodicTable
    {
        static void Periodic()
        {
            var number = int.Parse(Console.ReadLine());
            SortedSet<string> set = new SortedSet<string>();

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split(' ');
                for (int j = 0; j < input.Length; j++)
                {
                    set.Add(input[j]);
                }
            }

            foreach (var item in set)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
