using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueuesExercises
{
    class BasicStackOperations
    {
        static void StackOperations(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] numbers = Console.ReadLine().Split(' ');
            Stack<int> elements = new Stack<int>();

            foreach (var item in numbers)
            {
                elements.Push(int.Parse(item));
            }

            for (int i = 0; i < int.Parse(input[1]); i++)
            {
                elements.Pop();
            }
         
            var ItIsTrue = elements.Contains(int.Parse(input[2]))? true : false;
            if (elements.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (ItIsTrue)
            {
                Console.WriteLine("true");
            } else
            {
                long min = int.MaxValue;
                foreach (var item2 in elements)
                {                  
                        if(item2 < min)
                    {
                        min = item2;
                    }
                }
                Console.WriteLine(min);
            }           
        }
    }
}
