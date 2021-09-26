using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileAndStreams.cs
{
    class WordCount
    {
        static void Word()
        {
            using StreamReader sr = new StreamReader(@"..\..\..\..\Files\words.txt");
            {
                using StreamReader sr2 = new StreamReader(@"..\..\..\..\Files\text.txt");
                {
                    using StreamWriter sw = new StreamWriter(@"..\..\..\..\Files\expectedResult.txt");
                    {
                        Dictionary<string, int> words = new Dictionary<string, int>();
                        while (!sr.EndOfStream)
                        {
                            string word = sr.ReadLine();
                            words.Add($"{word}", 0);
                        }

                        while (!sr2.EndOfStream)
                        {
                            string input = sr2.ReadLine();
                            List<string> words2 = input.Split(' ', '-', '!', '?', '.', ',', '\'').ToList();

                            for (int i = 0; i < words2.Count; i++)
                            {
                                if (words.ContainsKey(words2[i].ToLower()))
                                {
                                    words[words2[i].ToLower()]++;
                                }
                            }
                        }

                        foreach (var item in words.OrderByDescending(x => x.Value))
                        {
                            sw.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
        }
    }
}

                
