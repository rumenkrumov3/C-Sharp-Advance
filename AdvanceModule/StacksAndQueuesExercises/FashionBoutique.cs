using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StacksAndQueuesExercises
{
    class FashionBoutique
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            Stack<int> stack = new Stack<int>();
            int sum = 0;
            int variable = 0;
            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;

            foreach (var item in input)
            {
                stack.Push(int.Parse(item));
            }

            while(stack.Count > 0)
            {
                variable = stack.Pop();

                if(variable + sum < capacity)
                {
                    sum += variable;
                } 
                else if (variable + sum == capacity)
                {
                    sum += variable;
                    sum = 0;
                    racks++;
                }
                else if (variable + sum > capacity)
                {
                    sum = 0;
                    racks++;
                    sum += variable;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
