using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionalProgramming
{
    class ListOfPredicates
    {
        static void ListOfPredicatess()
        {
            var number = int.Parse(Console.ReadLine());
            var divide = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int counter = 0;

            Func<int, int, bool> predicate = Number;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 0; j < divide.Length; j++)
                {
                    if (predicate(i, divide[j]))
                    {
                        if(counter == divide.Length)
                        {
                            Console.Write($"{i} ");
                        }
                        else
                        {
                            counter++;
                            if (counter == divide.Length)
                            {
                                Console.Write($"{i} ");
                            }
                        }                    
                    }
                }
                counter = 0;
            }
        }

        private static bool Number(int a, int b)
        {
            return a % b == 0;
        }
    }
    
}
