using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultidimensionArrays
{
    class SnakeMoves
    {
        static void Snake()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string stringInput = Console.ReadLine();
            char[,] matrix = new char[input[0], input[1]];
            char[,] finalMatrix = new char[input[0], input[1]];
            int multiply = input[0] * input[1];
            Queue<char> q = new Queue<char>();
            StringBuilder sb = new StringBuilder();
            int counter = 0;
            int index = 0;

            for (int i = 0; i < multiply; i++)
            {
                if(q.Count == multiply)
                {
                    break;
                }
                q.Enqueue(stringInput[i]);
                if(i == stringInput.Length - 1)
                {
                    i = -1;
                }
            }
        start:;
            if(counter % 2 == 0)
            {
                if(q.Count == 0)
                {
                    goto end;
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = q.Dequeue();
                        finalMatrix[index, j] = matrix[i, j];
                    }
                    counter++;
                    index++;
                    goto start;
                }               
            }
            else if (counter % 2 == 1)
            {
                if(q.Count == 0)
                {
                    goto end;
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {
                        matrix[i, j] = q.Dequeue();
                        finalMatrix[index, j] = matrix[i, j];
                    }
                    counter++;
                    index++;
                    goto start;
                }
            }

            
        end:;
            printMatrix(finalMatrix);

        }
        private static void printMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == matrix.GetLength(1) - 1)
                    {
                        Console.WriteLine($"{matrix[i, j]}");
                    }
                    else
                    {
                        Console.Write($"{matrix[i, j]}");
                    }
                }
            }
        }
    }
}
