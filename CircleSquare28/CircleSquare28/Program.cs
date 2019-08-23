using System;

namespace CircleSquare28
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split(' ');
                double num1 = double.Parse(space[0]);
                double num2 = double.Parse(space[1]);
                double Dm = num2 * num2;
                double Dv = Dm / 2;
                double Dc = Math.Sqrt(Dv);
                double Sc = Math.Round(Dc, 2);
                if (Sc == num1)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}