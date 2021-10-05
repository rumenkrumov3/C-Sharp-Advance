using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;

namespace FunctionalProgramming
{
    class FindEvensOrOdds
    {
        static void FindEvensOrOddss()
        {
            var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            Predicate<int> predicate = number => number % 2 == 0;

            for (int i = numbers[0]; i <= numbers[1]; i++)
            {
                if(command == "odd" && !predicate(i))
                {
                    Console.Write($"{i} ");
                }
                else if (command == "even" && predicate(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
