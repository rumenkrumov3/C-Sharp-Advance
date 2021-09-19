using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MultidimensionArrays
{
    class MaximalSum
    {
        static void MaxSum()
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            int[,] variableMatrix = new int[3, 3];
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                int[] parameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = parameters[j];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    if (matrix.Length == 9)
                    {
                        sumMatrix(matrix);
                        printMatrix(matrix);
                        break;
                    }
                    int variableSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] +
                        matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] +
                        matrix[row + 2, col + 2];
                    if (sum < variableSum)
                    {
                        sum = variableSum;
                        int[,] vvariableMatrix = {
                                         { matrix[row, col], matrix[row, col + 1], matrix[row, col + 2]},
                                         { matrix[row + 1, col], matrix[row + 1, col + 1], matrix[row + 1, col + 2]},
                                         { matrix[row + 2, col], matrix[row + 2, col + 1],matrix[row + 2, col + 2] }
                        };
                        variableMatrix = vvariableMatrix;
                    }
                }
            }
            if (matrix.Length > 9)
            {
                Console.WriteLine($"Sum = {sum}");
                printMatrix(variableMatrix);
            }




            /* 4 5
            1 5 5 2 4
            2 1 4 14 3
            3 7 11 2 8
            4 8 12 16 4 */
        }

        private static void printMatrix(int[,] matrix)
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

        private static void sumMatrix(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
