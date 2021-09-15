using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueuesLab
{
    class MatchingBrackets
    {
        static void Brackets()
        {
            string input = Console.ReadLine();
            Stack<int> indices = new Stack<int>();

            foreach (var ch in input)
            {

            }
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '(')
                {
                    indices.Push(i);
                } 
                else if (input[i] == ')')
                {
                    int startingIndex = indices.Peek();
                    Console.WriteLine(input.Substring(startingIndex, i - indices.Pop() + 1));
                }
            }
        }
    }
}
