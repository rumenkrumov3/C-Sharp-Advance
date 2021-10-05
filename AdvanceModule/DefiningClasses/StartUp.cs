using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {        
        static void Main()
        {
            //2
            int input = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < input; i++)
            {
                var credentials = Console.ReadLine().Split();
                Person person = new Person();
                person.Name = credentials[0];
                person.Age = int.Parse(credentials[1]);
                family.AddMember(person);
            }

            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
