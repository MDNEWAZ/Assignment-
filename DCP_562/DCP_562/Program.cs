using System;

namespace DCP_562
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int T = int.Parse(Console.ReadLine());
                for (int i = 0; i < T; i++)
                {
                    string line = Console.ReadLine();
                    string[] space = line.Split(' ');
                    int goal1 = int.Parse(space[0]);
                    int goal2 = int.Parse(space[1]);
                    if (goal1 > goal2)
                    {
                        Console.WriteLine($"Argentina {goal1} - {goal2} Brazil");
                    }
                    else
                    {
                        Console.WriteLine($"Brazil {goal2} - {goal1} Argentina");
                    }
                }
            }
        }
    }

