using System;

namespace static_void_Main_string___args_
{
    class Program
    {
        public static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 1; t <= T; t++)
            {
                int[] c = new int[(int)char.MaxValue];
                string s = Console.ReadLine();
                foreach (char l in s)
                {
                    c[(int)l]++;
                }
                Console.WriteLine($"Case {t}:");
                for (int i = 0; i < (int)char.MaxValue; i++)
                {
                    if (c[i] > 0)
                    {
                        Console.WriteLine("{0} {1}",
                            (char)i,
                            c[i]);
                    }
                }
            }
        }
    }
}
