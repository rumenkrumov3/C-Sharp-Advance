using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileAndStreams.cs
{
    class LineNumbers
    {
        static void Line()
        {
            using StreamReader sr = new StreamReader(@"..\..\..\..\Files\text.txt");
            {
                using StreamWriter sw = new StreamWriter(@"..\..\..\..\Files\output.txt");
                {
                    int index = 1;
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        int letters = 0;
                        int punctuation = 0;
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (line[i] == '-' || line[i] == ',' || line[i] == '.' || line[i] == '?' || line[i] == '!' || line[i] == '\'')
                            {
                                punctuation++;
                            }
                            else if (line[i] == ' ')
                            {
                                continue;
                            }
                            else
                            {
                                letters++;
                            }
                        }
                        sw.WriteLine($"Line {index}: {line} ({letters})({punctuation})");
                        index++;
                    }
                }              
            }
        }
    }
}
