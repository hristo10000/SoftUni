using System;
using System.Text.RegularExpressions;

namespace BossRush
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            string input = string.Empty;
            string name = string.Empty;
            string title = string.Empty;
            Regex validateBossInput = new Regex(@"\|[A - Z]{ 4, }\|:#[\w\s]*#");
            for (int i = 0; i < numberOfInputs; i++)
            {
                input = Console.ReadLine();
                if (validateBossInput.IsMatch(input))
                {
                    name = input.Split(':')[0].Trim('|');
                    title = input.Split(':')[1].Trim('#');
                    Console.WriteLine($"{name}, The {title} \n>> Strength: {name.Length} \n>> Armor: {title.Length}");
                }
                else
                    Console.WriteLine("Access denied!");
            }
        }
    }
}
