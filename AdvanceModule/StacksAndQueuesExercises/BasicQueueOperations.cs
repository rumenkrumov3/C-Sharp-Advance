using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueuesExercises
{
    class BasicQueueOperations
    {
        static void QueueOperations()
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] numbers = Console.ReadLine().Split(' ');
            Queue<int> elements = new Queue<int>();

            foreach (var item in numbers)
            {
                elements.Enqueue(int.Parse(item));
            }

            for (int i = 0; i < int.Parse(input[1]); i++)
            {
                elements.Dequeue();
            }

            var ItIsTrue = elements.Contains(int.Parse(input[2])) ? true : false;
            if (elements.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (ItIsTrue)
            {
                Console.WriteLine("true");
            }
            else
            {
                long min = int.MaxValue;
                foreach (var item2 in elements)
                {
                    if (item2 < min)
                    {
                        min = item2;
                    }
                }
                Console.WriteLine(min);
            }
        }
    }
}
