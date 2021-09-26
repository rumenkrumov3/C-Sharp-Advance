using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetsAndDictionaries
{
    class TheV_Logger
    {
        static void Main()
        {

            var vlogger = new Dictionary<string, Vlogger>();

            string commands = Console.ReadLine();

            while (commands != "Statistics")
            {
                var inputArgs = commands.Split();
                var user = inputArgs[0];
                var command = inputArgs[1];
                var star = inputArgs[2];

                if(command == "joined" && !vlogger.ContainsKey(user))
                {
                    vlogger[user] = new Vlogger();
                }
                else if (command == "followed" && vlogger.ContainsKey(user) && vlogger.ContainsKey(star) && user != star)
                {
                    vlogger[user].Following.Add(star);
                    vlogger[star].Followers.Add(user);
                }

                commands = Console.ReadLine();
            }

            var sortedList = vlogger.OrderByDescending(x => x.Value.Followers.Count).ThenBy(y => y.Value.Following.Count);

            int counter = 1;
            Console.WriteLine($"The V-Logger has a total of {vlogger.Count} vloggers in its logs.");
            foreach (var item in sortedList)
            {
                Console.WriteLine($"{counter}. {item.Key} : {item.Value.Followers.Count} followers, {item.Value.Following.Count} following");
                if(counter == 1)
                {
                    foreach (var item2 in item.Value.Followers.OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {item2}");
                    }
                }
                counter++;
            }
        }
        public class Vlogger
        {
            public Vlogger()
            {
                Followers = new HashSet<string>();
                Following = new HashSet<string>();
            }
            public HashSet<string> Followers { get; set; }
            public HashSet<string> Following { get; set; }
        }
    }

}

