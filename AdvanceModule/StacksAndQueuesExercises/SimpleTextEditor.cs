using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StacksAndQueuesExercises
{
    class SimpleTextEditor
    {
        static void Main()
        {
            int commands = int.Parse(Console.ReadLine());
            var text = new StringBuilder();
            List<string> input = new List<string>();
            Queue<char> chars = new Queue<char>();
            Stack<char> stack = new Stack<char>();

            while (commands > 0)
            {
                input = Console.ReadLine().Split(' ').ToList();

                if(int.Parse(input[0]) == 1)
                {
                    string input2 = input[1];
                    for (int i = 0; i < input[1].Length; i++)
                    {
                        chars.Enqueue(input2[i]);
                        stack.Push(input2[i]);
                    }
                }
                else if (int.Parse(input[0]) == 2)
                {
                    for (int i = 0; i < int.Parse(input[1]); i++)
                    {
                        chars.Dequeue();
                        stack.Pop();
                    }
                }
                else if(int.Parse(input[0]) == 3)
                {
                    if(int.Parse(input[1]) > 1)
                    {
                        Stack<char> stack2 = new Stack<char>();
                        stack2 = stack;
                        for (int i = 0; i < int.Parse(input[1]); i++)
                        {
                            if(stack2.Pop() < int.Parse(input[1]) - 1)
                            {
                                Console.WriteLine(stack2.Peek());
                            }
                            else
                            {
                                stack2.Pop();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(stack.Peek());
                    }                   
                }
                else if (int.Parse(input[0]) == 4)
                {

                }
            }
        }
    }
}
