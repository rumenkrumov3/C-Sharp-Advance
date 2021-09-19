using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueuesExercises
{
    class BalancedParentheses
    {
        static void BalancedParenthese()
        {
            string input = Console.ReadLine();
            List<char> element = new List<char>();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if(stack.Count == 0)
                {
                    stack.Push((char)input[i]);
                    continue;
                }
                else
                {
                    int sign = stack.Peek();
                    if(sign == 40 && (int)input[i] == 41)
                    {
                        stack.Pop();
                    }
                    else if (sign == 91 && (int)input[i] == 93)
                    {
                        stack.Pop();
                    }
                    else if (sign == 123 && (int)input[i] == 125)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push((char)input[i]);
                    }
                }
            }
            
            if(stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


        }
    }
}
