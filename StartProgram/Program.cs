using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StartProgram
{
    public class Program : IEnumerable
    {
        public static void Main()
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            var input = Console.ReadLine().Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = input[0];
            var list = new List<string>();
            var enumerator = new StackIterator<string>(list);

            while(command != "END")
            {
                if(command == "Push")
                {                   
                    for (int i = 1; i < input.Count; i++)
                    {
                        enumerator.Push(input[i]);
                    }                 
                }
                else if (command == "Pop")
                {
                    if(enumerator.Count() == 0)
                    {
                        Console.WriteLine("No elements");
                    }
                    else
                    {
                        enumerator.Pop();
                    }                 
                }

                input = Console.ReadLine().Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries).ToList();
                command = input[0];
            }

            enumerator.PrintTwice();
        }

        public IEnumerator GetEnumerator(List<string> list)
        {
            return new StackIterator<string>(list);
        }

        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
