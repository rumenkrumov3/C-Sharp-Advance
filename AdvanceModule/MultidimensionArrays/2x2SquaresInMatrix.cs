using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MultidimensionArrays
{
    class _2x2SquaresInMatrix
    {
        static void matrix()
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[,] matrix = new char[sizes[0], sizes[1]];
            int counter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] parameters = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = parameters[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if((matrix[i,j] == matrix[i,j+1]) && matrix[i, j]  == matrix[i+1,j] && matrix[i, j] == matrix[i+1,j+1])
                    {
                        counter++;
                    }
                    
                }

            }

            Console.WriteLine(counter);
        }
    }
}
