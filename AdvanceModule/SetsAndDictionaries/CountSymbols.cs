using System;
using System.Collections.Generic;
using System.Text;

namespace SetsAndDictionaries
{
    class CountSymbols
    {
        static void CountSymbol()
        {
            string input = Console.ReadLine();
            List<char> list = new List<char>();
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                list.Add(input[i]);
            }

            foreach (var item in list)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item] = 1;
                }
                else
                {
                    dict[item]++;
                }
            }

            foreach (var item2 in dict)
            {
                Console.WriteLine($"{item2.Key}: {item2.Value} time/s");
            }


        }
    }
}
