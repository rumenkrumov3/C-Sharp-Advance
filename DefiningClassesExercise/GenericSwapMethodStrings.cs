using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClassesExercise
{
    class GenericSwapMethodStrings
    {
        static void Mainun()
        {
            int number = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string text = Console.ReadLine();
                list.Add(text);
            }

            string[] indexes = Console.ReadLine().Split();
            int index1 = int.Parse(indexes[0]);
            int index2 = int.Parse(indexes[1]);

            GenericMethod<string>(index1, index2, list);

        }

        public static void GenericMethod<T>(int index1, int index2, List<T> list)
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
