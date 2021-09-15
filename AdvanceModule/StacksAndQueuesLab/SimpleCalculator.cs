using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueuesLab
{
    public class SimpleCalculator
    {
        static void Calculator()
        {
            string input = Console.ReadLine();
            string[] elements = input.Split(' ');
            Stack<string> stack = new Stack<string>();
            int sum = 0;

            for (int i = elements.Length - 1; i >= 0; i--)
            {
                stack.Push(elements[i]);
            }
            
            while(stack.Count > 0)
            {
                if(stack.Peek() == "+")
                {
                    stack.Pop();
                    sum += int.Parse(stack.Pop());
                }
                else if (stack.Peek() == "-")
                {
                    stack.Pop();
                    sum -= int.Parse(stack.Pop());
                }
                else
                {
                    sum += int.Parse(stack.Pop());
                }
            }
            Console.Write(sum);
        }
    }
}
