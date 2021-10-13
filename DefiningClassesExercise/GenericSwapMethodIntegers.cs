using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClassesExercise
{
    class GenericSwapMethodIntegers
    {
        static void Mainnnnnn()
        {
            int number = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            for (int i = 0; i < number; i++)
            {
                int text = int.Parse(Console.ReadLine());
                box.Items.Add(text);
            }

            string[] indexes = Console.ReadLine().Split();
            int index1 = int.Parse(indexes[0]);
            int index2 = int.Parse(indexes[1]);

            SwapMethod<int>(index1, index2, box.Items);

        }

        public static void SwapMethod<T>(int index1, int index2, List<T> list)
        {
            T variable = list[index2];
            list[index2] = list[index1];
            list[index1] = variable;

            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
    }
}
