using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetsAndDictionaries
{
    class Wardrobe
    {
        static void Wardrob()
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = Console.ReadLine().Split(',',' ');

                if (!dict.ContainsKey(input[0]))
                {
                    dict[input[0]] = new Dictionary<string, int>();

                    for (int j = 2; j < input.Length; j++)
                    {
                        if (!dict[input[0]].ContainsKey(input[j]))
                        {
                            dict[input[0]][input[j]] = 1;
                        }
                        else
                        {
                            dict[input[0]][input[j]]++;
                        }
                    }
                }
                else
                {
                    for (int j = 2; j < input.Length; j++)
                    {
                        if (!dict[input[0]].ContainsKey(input[j]))
                        {
                            dict[input[0]][input[j]] = 1;
                        }
                        else
                        {
                            dict[input[0]][input[j]]++;
                        }
                    }
                }
            }

            List<string> wantedClothes = Console.ReadLine().Split(' ',',').ToList();
            SortedSet<string> set = new SortedSet<string>();

            for (int i = 1; i < wantedClothes.Count; i++)
            {
                set.Add(wantedClothes[i]);
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var item2 in item.Value)
                {                  
                        if (set.Contains(item2.Key) && item.Key == wantedClothes[0])
                        {
                            Console.WriteLine($"* {item2.Key} - {item2.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {item2.Key} - {item2.Value}");
                        }
                                      
                    
                }
            }
        }
    }
}
