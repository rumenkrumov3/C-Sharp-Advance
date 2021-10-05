using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalProgramming
{
    class Training
    {
        static void Trainingg()
        {
            int input = int.Parse(Console.ReadLine());
            Dictionary<string, int> dict = new Dictionary<string, int>();
            
            for (int i = 0; i < input; i++)
            {
                string[] names = Console.ReadLine().Split(", ").ToArray();
                dict[names[0]] = int.Parse(names[1]);
            }

            string condition = Console.ReadLine();
            int ageCondition = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<int, bool> checkAges = testAge(ageCondition, condition);
            Action<KeyValuePair<string, int>> print = Printing(format);
            foreach (var item in dict.OrderBy(x => x.Value))
            {
                if (checkAges(item.Value))
                {
                    print(item);
                }
            }


        }

        private static Func<int,bool> testAge(int ages, string condition)
        {
            switch (condition)
            {
                case "younger": return x => x < ages;
                case "older": return x => x >= ages;
                default: return null;
            }
        }
        private static Action<KeyValuePair<string,int>> Printing (string format)
        {
            switch (format)
            {
                case "name": return person => Console.WriteLine($"{person.Key}");
                case "name age": return person => Console.WriteLine($"{person.Key} - {person.Value}");
                case "age": return person => Console.WriteLine($"{person.Value}");
                default: return null;
            }
            
        }
    }
}
