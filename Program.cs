using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal_quests
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> quests = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while (command != "Retire!")
            {
                var  tokens = command.Split(new string [] {" - "}, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (tokens[0] == "Start")
                {
                        if (!quests.Contains(tokens[1]))
                        {
                            quests.Add(tokens[1]);
                        }
                        
                }
                if (tokens[0]=="Complete")
                {
                    if (quests.Contains(tokens[1]))
                    {
                        quests.Remove(tokens[1]);
                    }
                }
                if (tokens[0]=="Renew")
                {
                    if (quests.Contains(tokens[1]))
                    {
                        quests.Remove(tokens[1]);
                        quests.Add(tokens[1]);

                    }
                }
                if (tokens[0]=="Side Quest")
                {
                    var list = tokens[1].Split(':').ToList();
                    if (quests.Contains(list[0]))
                    { if(!quests.Contains(list[1]))
                    	{var index = quests.FindIndex(x => x == list[0]);
                        quests.Insert(index+1,list[1]);}

                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",quests));
        }
    }
}
