using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StacksAndQueuesLab
{
    class StackSum
    {
        static void StackSums()
        {
            string input = Console.ReadLine();
            string[] integers = input.Split(' ');
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < integers.Length; i++)
            {
                numbers.Push(int.Parse(integers[i]));
            }

            while(true)
            {
                input = Console.ReadLine().ToLower();
                string[] inputs = input.Split(' ');
                if (inputs[0] == "add")
                {
                    numbers.Push(int.Parse(inputs[1]));
                    numbers.Push(int.Parse(inputs[2]));
                }
                else if (inputs[0] == "remove")
                {
                    if(numbers.Count < int.Parse(inputs[1]))
                    {
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < int.Parse(inputs[1]); i++)
                        {
                            numbers.Pop();
                        }
                    }                   
                }
                else if(inputs[0] == "end")
                {
                    Console.WriteLine($"Sum: {numbers.Sum()}");
                    break;
                }
            }
        }
    }
}
