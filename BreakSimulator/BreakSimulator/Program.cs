using System;

namespace BreakSimulator
{


    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            Double v, t, n;

            for (int i = 0; i < T; i++)
            {
                string first = Console.ReadLine();

                string[] array = first.Split();

                v = Double.Parse(array[0]);

                t = Double.Parse(array[1]);

                n = -(v / t);

                Console.WriteLine($"{n:F2}");

            }
        }
    }
}