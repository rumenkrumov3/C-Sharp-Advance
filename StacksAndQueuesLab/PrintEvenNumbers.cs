using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueuesLab
{
    class PrintEvenNumbers
    {
        static void evenNumbers()
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            Queue<int> evenNumbers = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if(int.Parse(numbers[i]) % 2 == 0)
                {
                    evenNumbers.Enqueue(int.Parse(numbers[i]));
                }
            }

            while(evenNumbers.Count > 0)
            {
                if(evenNumbers.Count == 1)
                {
                    Console.WriteLine($"{evenNumbers.Dequeue()}");
                }
                else
                {
                    Console.Write($"{evenNumbers.Dequeue()}, ");
                }
                
            }
        }
    }
}
