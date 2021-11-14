using System;
using System.Collections;
using System.Collections.Generic;

namespace ListyIterator
{
    public class StartUp : IEnumerable
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            string command = input[0];
            List<string> list = new List<string>();
            var enumerator = new ListyOperator<string>(list);

            while (command != "END")
            {
                if (command == "Create")
                {
                    for (int i = 1; i < input.Length; i++)
                    {
                        list.Add(input[i]);
                    }
                enumerator = new ListyOperator<string>(list);
                }
                else if (command == "HasNext")
                {
                    if (enumerator.HasNext())
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Move")
                {
                    if (enumerator.MoveNext())
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Print")
                {
                    if(list.Count == 0)
                    {
                        Console.WriteLine("Invalid Operation!");
                    }
                    else
                    {
                        enumerator.Print();
                    }                
                }
                else if (command == "PrintAll")
                {
                    enumerator.PrintAll();
                }

                input = Console.ReadLine().Split();
                command = input[0];
            }           
        }

        public IEnumerator GetEnumerator(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return GetEnumerator(); ;
        }
    }
}
