using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int dispalayCount = 0;
            double total = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCount++;
                }
                if (i % 3 == 0)
                {
                    mouseCount++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCount++;
                    if (keyboardCount % 2 == 0)
                    {
                        dispalayCount++;
                    }
                }
            }
            total = headsetPrice * headsetCount + displayPrice * dispalayCount + keyboardPrice * keyboardCount + mousePrice * mouseCount;
            Console.WriteLine($"Rage expenses: {total:f2} lv.");



        }
    }
}
