using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionalProgramming
{
    class PredicateParty
    {
        static void PredicatePartyy()
        {
            var participants = Console.ReadLine().Split(" ").ToList();
            List<string> list = new List<string>();
            Func<string, string, string, bool> checkName = CheckNames;

            foreach (var item in participants)
            {
                list.Add(item);
            }
            
            while (true)
            {
                var input = Console.ReadLine().Split(" ").ToArray();
                if(list.Count != participants.Count)
                {
                    participants.Clear();
                    foreach (var item in list)
                    {
                        participants.Add(item);
                    }
                }
                if(input[0] == "Double")
                {
                    if(input[1] == "StartsWith")
                    {
                        for (int i = 0; i < participants.Count; i++)
                        {
                            if(checkName(participants[i], input[2], input[1]))
                            {
                                list.Add(participants[i]);
                            }
                        }
                    }
                    else if(input[1] == "EndsWith")
                    {
                        for (int i = 0; i < participants.Count; i++)
                        {
                            if(checkName(participants[i], input[2], input[1]))
                            {
                                list.Add(participants[i]);
                            }
                        }
                    } 
                    else if (input[1] == "Length")
                    {
                        for (int i = 0; i < participants.Count; i++)
                        {
                            if(participants[i].Length == int.Parse(input[2]))
                            {
                                list.Add(participants[i]);
                            }
                        }
                    }
                }
                else if (input[0] == "Remove")
                {
                    if (input[1] == "StartsWith")
                    {
                        for (int i = 0; i < participants.Count; i++)
                        {
                            if (checkName(participants[i], input[2], input[1]))
                            {
                                list.Remove(participants[i]);
                            }
                        }
                    }
                    else if (input[1] == "EndsWith")
                    {
                        for (int i = 0; i < participants.Count; i++)
                        {
                            if (checkName(participants[i], input[2], input[1]))
                            {
                                list.Remove(participants[i]);
                            }
                        }
                    }
                    else if (input[1] == "Length")
                    {
                        for (int i = 0; i < participants.Count; i++)
                        {
                            if (participants[i].Length == int.Parse(input[2]))
                            {
                                list.Remove(participants[i]);
                            }
                        }
                    }
                }
                else if (input[0] == "Party!")
                {
                    break;
                }
            }
            var orderedParticipants = participants.OrderBy(x => x).ToList();
            if(orderedParticipants.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                for (int i = 0; i < orderedParticipants.Count; i++)
                {
                    if (i == list.Count - 1)
                    {
                        Console.Write($"{orderedParticipants[i]} are going to the party!");
                    }
                    else
                    {
                        Console.Write($"{orderedParticipants[i]}, ");
                    }                   
                }
            }
        }

        private static bool CheckNames(string name, string param, string condition)
        {
            string variable = string.Empty;
            int counter = 0;
            bool flag = false;
            if(condition == "StartsWith")
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] == param[i])
                    {
                        counter++;
                        if (param.Length == counter)
                        {
                            flag = true;
                            break;
                        }
                    }
                }
            }
            else if (condition == "EndsWith")
            {
                int index = param.Length - 1;
                for (int i = name.Length - 1; i >= 0; i--)
                {
                    if(param.Length != name.Length)
                    {
                        if (name[i] == param[index])
                        {
                            counter++;
                            index--;
                            if (param.Length == counter)
                            {
                                flag = true;
                                break;
                            }
                        }
                    }
                    else if (name[i] == param[i])
                    {
                        counter++;
                        if (param.Length == counter)
                        {
                            flag = true;
                            break;
                        }
                    }
                }
            }       
            return flag;
        }
    }
}


/*
Peter Misha Stephen
Remove StartsWith P
Double Length 5
Party!
*/