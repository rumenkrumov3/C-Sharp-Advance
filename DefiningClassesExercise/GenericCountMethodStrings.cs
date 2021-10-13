using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClassesExercise
{
    class GenericCountMethodStrings
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < input; i++)
            {
                string text = Console.ReadLine();              
                box.Items.Add(text);
            }

            string argument = Console.ReadLine();

            int number = box.CountGreaterThan(argument);

            Console.WriteLine(number);
        }        
    }
}
