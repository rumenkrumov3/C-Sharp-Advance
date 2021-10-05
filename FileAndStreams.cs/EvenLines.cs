using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileAndStreams.cs
{
    class EvenLines
    {
        static void Even()
        {
            using StreamReader sr = new StreamReader(@"..\..\..\..\Files\text.txt");
            int counter = 0;
            while (!sr.EndOfStream)
            {
                if (counter % 2 == 0)
                {
                    string input = sr.ReadLine();
                    List<string> line = input.Split(' ').Reverse().ToList();
                    char[] charArray = new char[input.Length];
                    int index = 0;
                    for (int i = 0; i < line.Count; i++)
                    {
                        for (int j = 0; j < line[i].Length; j++)
                        {
                            if (line[i][j] == '-' || line[i][j] == ',' || line[i][j] == '.' || line[i][j] == '!' || line[i][j] == '?')
                            {
                                charArray[index] = '@';
                                index++;
                            }
                            else
                            {
                                charArray[index] = line[i][j];
                                index++;
                            }

                        }

                        if (index < input.Length)
                        {
                            charArray[index] = ' ';
                            index++;
                        }


                    }

                    for (int i = 0; i < charArray.Length; i++)
                    {
                        if (i == charArray.Length - 1)
                        {
                            Console.WriteLine(charArray[i]);
                        }
                        else
                        {
                            Console.Write(charArray[i]);
                        }
                    }

                }
                else
                {
                    string input = sr.ReadLine();
                }
                counter++;
                

            }
        }
    }
}
  