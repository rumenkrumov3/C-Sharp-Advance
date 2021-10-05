using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionalProgramming
{
    class KnightsOfHonor
    {
        static void KnightsOfHonorr()
        {
            var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Func<List<int>, int> func = number => number.Min();
            Console.WriteLine(func(numbers));
        }
    }
}
