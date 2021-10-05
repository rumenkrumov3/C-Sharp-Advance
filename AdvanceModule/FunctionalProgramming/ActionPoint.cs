using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class ActionPoint
    {
        static void ActionPointt()
        {
            var names = Console.ReadLine().Split(" ");
            Action<string> print = name => Console.WriteLine(name);
            foreach (var item in names)
            {
                print(item);
            }
        }
    }
}
