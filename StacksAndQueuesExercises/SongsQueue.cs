using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StacksAndQueuesExercises
{
    class SongsQueue
    {
        static void Songs()
        {
            string[] input = Console.ReadLine().Split(',');
            Queue<string> songs = new Queue<string>();

            for (int i = 0; i < input.Length; i++)
            {
                songs.Enqueue(input[i]);
            }

            while(songs.Count > 0)
            {
                List<string> choice = Console.ReadLine().Split(' ').ToList();

                if (choice[0].ToLower() == "play")
                {
                    songs.Dequeue();
                }
                else if (choice[0].ToLower() == "add")
                {
                    var sb = new StringBuilder();
                    if (choice.Count > 2)
                    {
                        for (int i = 1; i < choice.Count; i++)
                        {
                            sb.Append($"{choice[i]} ");
                        }
                        string variable = sb.ToString();

                        foreach (var item in songs)
                        {
                            if($"{item} " == variable)
                            {
                                Console.WriteLine($"{item} is already contained!");
                            }
                            else
                            {
                                songs.Enqueue(variable);
                                break;
                            }
                                                   
                        }
                    }
                    else
                    {
                        songs.Enqueue(choice[1]);
                    }
                }
                else if (choice[0].ToLower() == "show")
                {
                    printQueue(songs);
                }
                choice.Clear();

            }
            Console.WriteLine("No more songs!");
        }

        public static void printQueue(Queue<string> queue)
        {
            int index = queue.Count;
            Queue<string> insideQueue = queue;
            for (int i = 0; i < index; i++)
            {
                if(insideQueue.Count == 1)
                {
                    Console.WriteLine($"{insideQueue.Dequeue()}");
                }
                else
                {
                    Console.Write($"{insideQueue.Dequeue()}, ");
                }              
            }
        }
    }
}
