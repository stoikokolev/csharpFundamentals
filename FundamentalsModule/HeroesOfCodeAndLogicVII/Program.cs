using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int players = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();
            for (int i = 0; i < players; i++)
            {
                string input = Console.ReadLine();

                string name = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];
                int mana = int.Parse(input.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2]);
                if (mana > 200)
                {
                    mana = 200;
                }

                int hp = int.Parse(input.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
                if (hp > 100)
                {
                    hp = 100;
                }

                Hero hero = new Hero { HP = hp, Mana = mana, Name = name };
                heroes.Add(name, hero);
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arr = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string name = arr[1];
                switch (arr[0])
                {
                    case "CastSpell":
                        if (heroes[name].Mana >= int.Parse(arr[2]))
                        {
                            heroes[name].Mana -= int.Parse(arr[2]);
                            Console.WriteLine($"{name} has successfully cast {arr[3]} and now has {heroes[name].Mana} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} does not have enough MP to cast {arr[3]}!");
                        }
                        break;
                    case "TakeDamage":
                        if (heroes[name].HP > int.Parse(arr[2]))
                        {
                            heroes[name].HP -= int.Parse(arr[2]);
                            Console.WriteLine($"{name} was hit for {arr[2]} HP by {arr[3]} and now has {heroes[name].HP} HP left!");
                        }
                        else
                        {
                            heroes.Remove(name);
                            Console.WriteLine($"{name} has been killed by {arr[3]}!");
                        }
                        break;
                    case "Recharge":
                        int recharged = int.Parse(arr[2]);
                        if (heroes[name].Mana + recharged > 200)
                        {
                            recharged = 200 - heroes[name].Mana;
                            heroes[name].Mana += recharged;
                        }
                        else
                        {
                            heroes[name].Mana += recharged;
                        }

                        Console.WriteLine($"{name} recharged for {recharged} MP!");
                        break;
                    case "Heal":
                        int healed = int.Parse(arr[2]);
                        if (heroes[name].HP + healed > 100)
                        {
                            healed = 100 - heroes[name].HP;
                            heroes[name].HP += healed;
                        }
                        else
                        {
                            heroes[name].HP += healed;
                        }

                        Console.WriteLine($"{name} healed for {healed} HP!");
                        break;
                }

            }

            foreach (var hero in heroes.OrderByDescending(x => x.Value.HP).ThenBy(x => x.Key))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(hero.Key);
                //Console.WriteLine($"{hero.Key}");
                sb.AppendLine($"  HP: {hero.Value.HP}");
                //Console.WriteLine($"  HP: {hero.Value.HP}");
                sb.AppendLine($"  MP: {hero.Value.Mana}");
                //Console.WriteLine($"  MP: {hero.Value.Mana}");
                Console.Write(sb);
            }

        }
        public class Hero
        {
            public int Mana { get; set; }
            public int HP { get; set; }
            public string Name { get; set; }
        }
    }
}
