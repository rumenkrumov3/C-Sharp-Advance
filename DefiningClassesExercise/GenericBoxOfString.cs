using System;
using System.Collections.Generic;

namespace DefiningClassesExercise
{
    public class GenericBoxOfString
    {
        static void Mainnn()
        {
            Box<string> box = new Box<string>();
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string text = Console.ReadLine();
                box.Items.Add(text);
            }

            Console.WriteLine(box);
        }
    }    
}
