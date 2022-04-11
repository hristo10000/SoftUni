using System;
using System.Collections.Generic;
using System.Linq;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> type = new List<string>();
            List<int> years = new List<int>();
            List<int> kilometers = new List<int>();
            string[] inputs = new string[100];
            List<string[]> inputsSplit = new List<string[]>();
            string input = Console.ReadLine();
            inputs = input.Split('>');
            for (int i = 0; i < inputs.Length; i++)
            {
                inputsSplit.Add(inputs[i].Split(' '));
            }

            for(int i = 0; i < inputsSplit.Count; i++)
            {
                if (inputsSplit[i].Length > 1)
                {
                    type.Add(inputsSplit[i][0]);
                    years.Add(int.Parse(inputsSplit[i][1]));
                    kilometers.Add(int.Parse(inputsSplit[i][2]));
                }
            }

            double tax, taxSum = 0;

            for(int i = 0; i < type.Count; i++)
            {
                switch (type[i])
                {
                    case "family":
                        tax = kilometers[i] / 3000 * 12 + (50 - years[i] * 5);
                        break;
                    case "heavyDuty":
                        tax = kilometers[i] / 9000 * 14 + (80 - years[i] * 8);
                        break;
                    case "sports":
                        tax = kilometers[i] / 2000 * 18 + (100 - years[i] * 9);
                        break;
                    default:
                        Console.WriteLine("Invalid car type.");
                        continue;
                }
                Console.WriteLine($"A {type[i]} car will pay {tax:F2} euros in taxes.");
                taxSum += tax;
            }
            Console.WriteLine($"The National Revenue Agency will collect {taxSum:F2} euros in taxes.");
        }
    }
}
