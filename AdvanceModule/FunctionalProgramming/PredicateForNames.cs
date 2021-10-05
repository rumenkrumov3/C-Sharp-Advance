using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class PredicateForNames
    {
        static void PredicateForNamess()
        {
            int input = int.Parse(Console.ReadLine());
            Func<string, int, bool> func = Lenght;
            var names = Console.ReadLine().Split(" ");
            for (int i = 0; i < names.Length; i++)
            {
                if (func(names[i], input))
                {
                    Console.WriteLine(names[i]);
                }
            }
        }

        private static bool Lenght(string name, int lenght)
        {
            return name.Length <= lenght;
        }
    }
}
