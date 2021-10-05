using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueuesLab
{
    class SuperMarket
    {
        static void Market()
        {
            Queue<string> persons = new Queue<string>();

            while(true)
            {
                string input = Console.ReadLine();
                if(input.ToLower() == "paid")
                {
                    while(persons.Count > 0)
                    {
                        Console.WriteLine(persons.Dequeue());
                    }
                }
                else if (input.ToLower() == "end")
                {
                    Console.WriteLine($"{persons.Count} people remaining.");
                }
                else
                {
                    persons.Enqueue(input);
                }               
            }
        }
    }
}
