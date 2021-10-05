using System;
using System.Collections.Generic;
using System.Text;

namespace SetsAndDictionaries
{
    class EvenTimes
    {
        static void EvenTime()
        {
            double input = double.Parse(Console.ReadLine());
            Dictionary<double, int> dict = new Dictionary<double, int>();

            for (int i = 0; i < input; i++)
            {
                var number = double.Parse(Console.ReadLine());
                if(dict.ContainsKey(number))
                {
                    dict[number]++;
                }
                else
                {
                    dict[number] = 1;
                }
            }
            double Key = 0;
            int Value = 0;
            foreach (var item in dict)
            {              
                if(item.Value > Value)
                {
                    Value = item.Value;
                    Key = item.Key;
                }
            }

            Console.Write(Key);
        }
    }
}
