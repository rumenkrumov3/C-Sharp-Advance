using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultidimensionArrays
{
    class MatrixShuffling
    {
        static void MatrixShuff()
        {
            List<string> commands = new List<string>();
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[,] matrix = new string[sizes[0], sizes[1]];
            int count = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] parameters = Console.ReadLine().Split(' ').ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = parameters[j];
                }
            }

            commands = Console.ReadLine().Split(' ').ToList();

            while (commands[0].ToLower() != "end")
            {
                if(count > 1)
                {
                    commands = Console.ReadLine().Split(' ').ToList();
                }
                if(commands[0].ToLower() == "end")
                {
                    break;
                }
                if (commands[0].ToLower() == "swap")
                {
                    if (int.Parse(commands[1]) > matrix.GetLength(0) || int.Parse(commands[2]) > matrix.GetLength(0) || int.Parse(commands[3]) > matrix.GetLength(1) || int.Parse(commands[4]) > matrix.GetLength(1))
                    {
                        Console.WriteLine("Invalid input!");
                        count++;
                    }
                    else
                    {
                        string firstValue = matrix[int.Parse(commands[1]), int.Parse(commands[2])];
                        string secondValue = matrix[int.Parse(commands[3]), int.Parse(commands[4])];
                        matrix[int.Parse(commands[1]), int.Parse(commands[2])] = secondValue;
                        matrix[int.Parse(commands[3]), int.Parse(commands[4])] = firstValue;
                        printMatrix(matrix);
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    count++;
                }
            }
        }

        private static void printMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == matrix.GetLength(1) - 1)
                    {
                        Console.WriteLine($"{matrix[i, j]} ");
                    }
                    else
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }
                }
            }
        }
    }
}
