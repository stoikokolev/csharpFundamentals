using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double lightsaberTotal = Math.Ceiling(1.1 * students) * lightsaberPrice;
            double robeTotal = 1.0 * students * robePrice;
            double beltTotal = (students - (students / 6)) * beltPrice;
            double total = lightsaberTotal + robeTotal + beltTotal;
            if (total <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {total - money:f2}lv more.");
            }





        }
    }
}
