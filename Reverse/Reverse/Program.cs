using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; ++i)
            {
                string str = "", reverse = "";
                int length = 0;
                str = Console.ReadLine();
                length = str.Length - 1;
                while (length >= 0)
                {
                    reverse = reverse + str[length];
                    length--;
                }
                Console.WriteLine($"{reverse}");
            }
        }
    }
}