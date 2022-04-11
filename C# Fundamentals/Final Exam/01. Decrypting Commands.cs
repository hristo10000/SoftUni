using System;

namespace Decryptig_Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command = string.Empty;
            string substring = string.Empty;
            int sum = 0;
            while (command != "Finish")
            {
                command = Console.ReadLine();
                if (command == "Finish")
                    continue;
                switch (command.Split(" ")[0])
                {
                    case "Replace":
                        for(int i = 0; i < text.Length; i++)
                        {
                            if (text[i] == command.Split(" ")[1].ToCharArray()[0])
                            {
                                text = text.Remove(i, 1);
                                text = text.Insert(i, command.Split(" ")[2]);
                            }
                        }
                        Console.WriteLine(text);
                        break;

                    case "Cut":
                        if (int.Parse(command.Split(" ")[1]) >= 0 && int.Parse(command.Split(" ")[2]) < text.Length)
                        {
                            text = text.Remove(int.Parse(command.Split(" ")[1]), int.Parse(command.Split(" ")[2]) - int.Parse(command.Split(" ")[1]) + 1);
                            Console.WriteLine(text);
                        }
                        else
                            Console.WriteLine("Invalid indices!");
                        break;

                    case "Make":
                        if (command.Split(" ")[1] == "Upper")
                            text = text.ToUpper();
                        else
                            text = text.ToLower();
                        Console.WriteLine(text);
                        break;

                    case "Check":
                        if(text.Contains(command.Split(" ")[1]))
                            Console.WriteLine($"Message contains {command.Split(" ")[1]}");
                        else
                            Console.WriteLine($"Message doesn't contain {command.Split(" ")[1]}");
                            break;

                    case "Sum":
                        if(int.Parse(command.Split(" ")[1]) >= 0 && int.Parse(command.Split(" ")[2]) < text.Length)
                        {
                            substring = text.Substring(int.Parse(command.Split(" ")[1]), int.Parse(command.Split(" ")[2]) - int.Parse(command.Split(" ")[1]) + 1);
                            for(int i = 0; i< substring.Length; i++)
                            {
                                sum += substring[i];
                            }
                            Console.WriteLine(sum);
                        }
                        else
                            Console.WriteLine("Invalid indices!");
                        break;
                }
            }
        }
    }
}
