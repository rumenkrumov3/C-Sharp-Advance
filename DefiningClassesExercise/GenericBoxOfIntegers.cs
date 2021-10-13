using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClassesExercise
{
    class GenericBoxOfIntegers
    {
        static void Mainnnn()
        {
            Box<int> box = new Box<int>();
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                int number = int.Parse(Console.ReadLine());
                box.Items.Add(number);
            }

            Console.WriteLine(box);
        }
    }
    
}
