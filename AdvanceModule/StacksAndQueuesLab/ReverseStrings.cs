using System;
using System.Collections;
using System.Collections.Generic;

namespace StacksAndQueuesLab
{
    public class ReverseStrings
    {
        static void Reverse()
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var ch in input)
            {
                stack.Push(ch);
            }

            while(stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
