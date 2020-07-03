using System;
using System.Collections.Generic;
using System.Linq;

namespace ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> warShip = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int maxHp = int.Parse(Console.ReadLine());
            double lowHp = 0.2 * maxHp;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Retire")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "Fire":
                        int index = int.Parse(command[1]);
                        int damage = int.Parse(command[2]);
                        if (index >= 0 && index < warShip.Count)
                        {
                            warShip[index] -= damage;
                            if (warShip[index] <= 0)
                            {
                                Console.WriteLine("You won! The enemy ship has sunken.");
                                return;
                            }

                        }

                        break;

                    case "Defend":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        int warShipDamage = int.Parse(command[3]);
                        if ((startIndex >= 0 && startIndex < pirateShip.Count) && (endIndex >= 0 && endIndex < pirateShip.Count))
                        {
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                pirateShip[i] -= warShipDamage;
                                if (pirateShip[i] <= 0)
                                {
                                    Console.WriteLine("You lost! The pirate ship has sunken.");
                                    return;
                                }

                            }

                        }
                        break;

                    case "Repair":
                        int repairIndex = int.Parse(command[1]);
                        int repairHp = int.Parse(command[2]);
                        if (repairIndex >= 0 && repairIndex < pirateShip.Count)
                        {
                            pirateShip[repairIndex] += repairHp;
                            if (maxHp < pirateShip[repairIndex])
                            {
                                pirateShip[repairIndex] = maxHp;
                            }

                        }

                        break;

                    case "Status":
                        int count = 0;
                        foreach (var item in pirateShip)
                        {
                            if (item < lowHp)
                            {
                                count++;
                            }

                        }

                        Console.WriteLine($"{count} sections need repair.");
                        break;

                }

            }
            int sumPirate = 0;
            int sumWar = 0;
            foreach (var item in pirateShip)
            {
                sumPirate += item;
            }

            foreach (var item in warShip)
            {
                sumWar += item;
            }

            Console.WriteLine($"Pirate ship status: {sumPirate}");
            Console.WriteLine($"Warship status: {sumWar}");

        }
    }
}
