using System;

namespace DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            double stepInCentimeters = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            distance *= 100;
            double travelledDistance = (stepInCentimeters * steps) - ((steps / 5) * stepInCentimeters * 0.3);
            double final = travelledDistance / distance * 100;
            Console.WriteLine($"You travelled {final:f2}% of the distance!");



        }
    }
}
