using System;

namespace DCP_117
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                long s = 0, num;
                num = int.Parse(Console.ReadLine());
                s = (num * (num + 1) / 2);
                Console.WriteLine(s);
            }
        }
    }
}
