using System;
using System.Collections.Generic;

namespace Hero_Rec
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();
            string[] input = new string[3];
            List<string> spellbook = new List<string>();
            while (input[0] != "End")
            {
                input = Console.ReadLine().Split(" ");
                switch (input[0])
                {
                    case "End":
                        continue;
                    case "Enroll":
                        if (heroes.ContainsKey(input[1]))
                            Console.WriteLine($"{input[1]} is already enrolled.");
                        else
                            heroes.Add(input[1], new List<string>());
                        break;
                    case "Learn":
                        if (!heroes.ContainsKey(input[1]))
                        {
                            Console.WriteLine($"{input[1]} doesn't exist.");
                            break;
                        }

                        heroes.TryGetValue(input[1], out spellbook);
                        if (spellbook.Contains(input[2]))
                        {
                            Console.WriteLine($"{input[1]} has already learnt {input[2]}.");
                            break;
                        }

                        heroes.TryGetValue(input[1], out spellbook);
                        spellbook.Add(input[2]);
                        break;
                    case "Unlearn":
                        if (!heroes.ContainsKey(input[1]))
                        {
                            Console.WriteLine($"{input[1]} doesn't exist.");
                            break;
                        }

                        heroes.TryGetValue(input[1], out spellbook);
                        if (!spellbook.Contains(input[2]))
                            Console.WriteLine($"{input[1]} doesn't know {input[2]}.");

                        heroes.TryGetValue(input[1], out spellbook);
                        spellbook.Remove(input[2]);
                        break;
                }
            }
            Console.WriteLine("Heroes:");
            foreach(var hero in heroes)
            {
                Console.Write($"== {hero.Key}:");
                heroes.TryGetValue(hero.Key, out spellbook);
                for (int i = 0; i < spellbook.Count; i++)
                {
                    if (i == 0)
                        Console.Write($" {spellbook[i]}");
                    else
                        Console.Write($", {spellbook[i]}");
                }
                Console.WriteLine();
            }
        }
    }
}
