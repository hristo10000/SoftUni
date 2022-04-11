using System;
using System.Collections.Generic;

namespace PhoneShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(',');
            List<string> phones = new List<string>();

            for(int i = 0; i < inputSplit.Length; i++)
            {
                phones.Add(inputSplit[i].Trim());
            }

            string command = string.Empty;
            string currentPhone = string.Empty;

            while (command != "End")
            {
                command = Console.ReadLine();
                if (command == "End") { break; }
                currentPhone = command.Split('-')[1].Trim();
                switch (command.Split('-')[0].Trim())
                {
                    case "Add":
                        if (!phones.Contains(currentPhone))
                        {
                            phones.Add(currentPhone);
                        }
                        break;
                    case "Remove":
                        if (phones.Contains(currentPhone))
                        {
                            phones.Remove(currentPhone);
                        }
                        break;
                    case "Bonus phone":
                        if (phones.Contains(currentPhone.Split(':')[0])){
                            phones.Insert((phones.IndexOf(currentPhone.Split(':')[0]) + 1), currentPhone.Split(':')[1]);              
                        }
                        break;
                    case "Last":
                        if (phones.Contains(currentPhone))
                        {
                            phones.Remove(currentPhone);
                            phones.Add(currentPhone);
                        }
                        break;
                }
            }
            string output = string.Empty;
            foreach(string phone in phones)
            {
                output += phone + ", ";
            }
            Console.WriteLine(output.Trim().Trim(','));
        }
    }
}
