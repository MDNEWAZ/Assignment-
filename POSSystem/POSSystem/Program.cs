using System;

namespace POSSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            uint T = uint.Parse(Console.ReadLine());
            for (uint t = 1; t <= T; t++)
            {
                uint itemsPurchased = uint.Parse(Console.ReadLine());
                double totalPrice = 0.0;
                for (uint i = 0; i < itemsPurchased; i++)
                {
                    string input = Console.ReadLine();
                    var goodsWithMoney = input.Split(' ');
                    double unitPriceItem = double.Parse(goodsWithMoney[0]);
                    uint quantity = uint.Parse(goodsWithMoney[1]);
                    totalPrice += (unitPriceItem * quantity);
                }
                uint givenMoney = uint.Parse(Console.ReadLine());
                double returnMoney = Math.Truncate(givenMoney - totalPrice);
                Console.WriteLine($"Case {t}: {returnMoney}");
            }
        }
    }
}
