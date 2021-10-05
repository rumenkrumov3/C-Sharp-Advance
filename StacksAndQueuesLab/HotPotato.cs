using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueuesLab
{
    class HotPotato
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            List<string> originalNames = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                originalNames.Add(input[i]);
            }
            int originalNamesNumber = originalNames.Count;
            List<string> namesInList = new List<string>();
            int originalCount = int.Parse(Console.ReadLine());
            Queue<string> nameOfPlayers = new Queue<string>();

            for (int i = 0; i < originalNamesNumber - 1; i++)
            {
                while (namesInList.Count < originalCount)
                {
                    for (int j = 0; j < originalNames.Count; j++)
                    {
                        namesInList.Add(originalNames[j]);
                    }
                }
                nameOfPlayers.Enqueue(namesInList[originalCount - 1]);
                originalNames.Remove(namesInList[originalCount - 1]);
                namesInList.Clear();


            }

            while (nameOfPlayers.Count > 0)
            {
                Console.WriteLine($"Removed {nameOfPlayers.Dequeue()}");
            }

            Console.WriteLine($"Last is {originalNames[0]}");

        }
    }
}