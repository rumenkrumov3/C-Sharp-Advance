using System;
using System.Collections.Generic;
using System.Text;

namespace MultidimensionArrays
{
    class JaggedArray
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int[][] array = new int[input][];
            int index = 0;
            for (int i = 0; i < input; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                array[i] = new int[data.Length];
                for (int j = 0; j < data.Length; j++)
                {                    
                    array[i][j] = int.Parse(data[j]);
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if(i == array.Length - 1)
                {
                    break;
                }
                if(array[i].Length == array[i + 1].Length)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        array[i][j] *= 2;
                    }
                    for (int k = 0; k < array[i+1].Length; k++)
                    {
                        array[i+1][k] *= 2;
                    }
                }
                else if (array[i].Length != array[i + 1].Length)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        array[i][j] /= 2;
                    }
                    for (int k = 0; k < array[i + 1].Length; k++)
                    {
                        array[i + 1][k] /= 2;
                    }
                }

            }

            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ');

                if(commands[0] == "End")
                {
                    break;
                }
                else if (commands[0] == "Add")
                {
                    if (int.Parse(commands[1]) < 0)
                    {
                        continue;

                    }
                    else if (int.Parse(commands[2]) < 0)
                    {
                        continue;
                    }
                    else if (int.Parse(commands[1]) <= array.GetLength(0)
                       && int.Parse(commands[2]) <= array[int.Parse(commands[1])].Length)
                    {
                        array[int.Parse(commands[1])][int.Parse(commands[2])] += int.Parse(commands[3]);
                    }
                }
                else if (commands[0] == "Subtract")
                {
                    if(int.Parse(commands[1]) < 0)
                    {
                        continue;

                    } else if (int.Parse(commands[2]) < 0)
                    {
                        continue;
                    }        
                    else if (int.Parse(commands[1]) <= array.GetLength(0)
                       && int.Parse(commands[2]) <= array[int.Parse(commands[1])].Length)
                    {
                        array[int.Parse(commands[1])][int.Parse(commands[2])] -= int.Parse(commands[3]);
                    }
                }
                
            }
            printMatrix(array);
        }
        private static void printMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (j == matrix[i].Length - 1)
                    {
                        Console.WriteLine($"{matrix[i][j]} ");
                    }
                    else
                    {
                        Console.Write($"{matrix[i][j]} ");
                    }
                }
            }
        }
    }
}
