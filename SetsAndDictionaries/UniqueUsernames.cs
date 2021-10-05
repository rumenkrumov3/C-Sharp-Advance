using System;
using System.Collections.Generic;

namespace SetsAndDictionaries
{
    class UniqueUsernames
    {
        static void Usernames()
        {
            int size = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < size; i++)
            {
                var name = Console.ReadLine();
                set.Add(name);
            }

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
