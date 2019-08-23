using System;

namespace DCP_483_Mr.Typical
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "never be so happy when you are happy and never be so sad when you are sad";
            string givenWord;
            string search;
            while ((givenWord = Console.ReadLine()) != null)
            {
                string[] line = givenWord.Split('\n');
                search = line[0];
                string pattern = string.Format(@"\b{0}\b", search);
                if (Regex.IsMatch(str, pattern))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
