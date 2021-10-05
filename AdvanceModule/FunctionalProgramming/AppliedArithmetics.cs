using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FunctionalProgramming
{
    class AppliedArithmetics
    {
        static void AppliedArithmeticss()
        {
            var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Action<List<int>> addFunction = Add;
            Action<List<int>> subtractFunction = Subtract;
            Action<List<int>> multiplyFunction = Multiply;
            Action<List<int>> printFunction = Print;

            while (true)
            {
                string command = Console.ReadLine();
                if(command == "add")
                {
                    addFunction(numbers);
                }
                else if (command == "subtract")
                {
                    subtractFunction(numbers);
                }
                else if (command == "multiply")
                {
                    multiplyFunction(numbers);
                }
                else if (command == "print")
                {
                    Print(numbers);
                }
                else if(command == "end")
                {
                    break;
                }
                else
                {

                }
            }
        }

        private static void Add(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += 1;
            }
        }

        private static void Subtract(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] -= 1;
            }
        }

        private static void Multiply(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] *= 2;
            }
        }

        private static void Print(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();
        }
    }
}
