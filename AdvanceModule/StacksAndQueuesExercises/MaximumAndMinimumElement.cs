using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StacksAndQueuesExercises
{
    class MaximumAndMinimumElement
    {
        static void MaxMin()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            while(inputNumber > 0)
            {
                List<string>enteredOperations = Console.ReadLine().Split(' ').ToList();

                if(int.Parse(enteredOperations[0]) == 1)
                {
                    stack.Push(int.Parse(enteredOperations[1]));
                }
                else if (int.Parse(enteredOperations[0]) == 2)
                {
                    if(stack.Count == 0)
                    {
                        inputNumber--;
                        continue;                       
                    }
                    else
                    {
                        stack.Pop();
                    }
                    
                }
                else if (int.Parse(enteredOperations[0]) == 3)
                {
                    if (stack.Count == 0)
                    {
                        inputNumber--;
                        continue;
                    } 
                    else
                    {
                        Console.WriteLine(stack.Max());
                    }                   
                }
                else if (int.Parse(enteredOperations[0]) == 4)
                {
                    if (stack.Count == 0)
                    {
                        inputNumber--;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(stack.Min());
                    }                       
                }
                inputNumber--;
                enteredOperations.Clear();
            }

            int index = stack.Count;
            for (int i = 0; i < index; i++)
            {
                if (stack.Count == 1)
                {
                    Console.WriteLine(stack.Pop());
                } 
                else
                {
                    Console.Write($"{stack.Pop()}, ");
                }
            }

        }
    }
}
