using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClassesExercise
{
    public class GenericCountMethodDouble
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < input; i++)
            {
                double digit = double.Parse(Console.ReadLine());
                box.Items.Add(digit);
            }

            double argument = double.Parse(Console.ReadLine());

            int number = box.CountGreaterThan(argument);

            Console.WriteLine(number);
        }
    }
}
