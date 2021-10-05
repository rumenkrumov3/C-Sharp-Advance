using System;
using System.Linq;

namespace MultidimensionArrays
{
    class DiagonalDifference
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;
            int entireSum;

              for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    int[] parameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = parameters[j];
                    }
                }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    firstDiagonalSum += matrix[i, j];                   
                    i++;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    secondDiagonalSum += matrix[i, j];                   
                    i++;
                }
            }

            entireSum = firstDiagonalSum - secondDiagonalSum;
            if(entireSum < 0)
            {
                Console.WriteLine(entireSum*(-1));
            }
            else
            {
                Console.WriteLine(entireSum);
            }
        }
    }
}
