using System;

namespace DCP_194_NumberFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                string input = Console.ReadLine();
                if (input.StartsWith("016") || input.StartsWith("88016"))
                {
                    if (input.StartsWith("88"))
                    {
                        Console.WriteLine($"{input} {"Airtel"}");
                    }
                    else
                    {
                        Console.WriteLine($"88{input} {"Airtel"}");
                    }
                }
                else if (input.StartsWith("018") || input.StartsWith("88018"))
                {
                    if (input.StartsWith("88"))
                    {
                        Console.WriteLine($"{input} {"Robi"}");
                    }
                    else
                    {
                        Console.WriteLine($"88{input} {"Robi"}");
                    }
                }
                else if (input.StartsWith("011") || input.StartsWith("88011"))
                {
                    if (input.StartsWith("88"))
                    {
                        Console.WriteLine($"{input} {"Citycell"}");
                    }
                    else
                    {
                        Console.WriteLine($"88{input} {"Citycell"}");
                    }
                }
                else if (input.StartsWith("015") || input.StartsWith("88015"))
                {
                    if (input.StartsWith("88"))
                    {
                        Console.WriteLine($"{input} {"Teletalk"}");
                    }
                    else
                    {
                        Console.WriteLine($"88{input} {"Teletalk"}");
                    }
                }
                else if (input.StartsWith("017") || input.StartsWith("88017"))
                {
                    if (input.StartsWith("88"))
                    {
                        Console.WriteLine($"{input} {"Grameenphone"}");
                    }
                    else
                    {
                        Console.WriteLine($"88{input} {"Grameenphone"}");
                    }
                }
                else if (input.StartsWith("019") || input.StartsWith("88019"))
                {
                    if (input.StartsWith("88"))
                    {
                        Console.WriteLine($"{input} {"Banglalink"}");
                    }
                    else
                    {
                        Console.WriteLine($"88{input} {"Banglalink"}");
                    }
                }
            }
        }
    }
}