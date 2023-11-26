using unit.Items;
using unit.units;

namespace unit
{
    internal class Duel
    {
        public static int FightCount=0;
        internal static void Fighting(Unit unit1, Unit unit2)
        {
            Console.WriteLine($"Выберите того,кто будет первым атаковать:\n" +
                $"1.{unit1.Name}\n" +
                $"2.{unit2.Name}");
            Console.WriteLine();
            int choice = int.Parse( Console.ReadLine());
            unit1.WeaponChoose(unit1);
            unit2.WeaponChoose(unit2);
            
            switch (choice)
            {
                case 1:
                    
                    Console.WriteLine($"Сейчас вы наблюдаете сражение между {unit1.Name} и {unit2.Name}");
                    Console.WriteLine($" Первым атакует {unit1.Name} ");
                    unit1.BaseInfo();
                    unit2.BaseInfo();
                    
                    while (unit1.Alive && unit2.Alive) 
                    {
                        Stat.StunCheck(unit1);
                        Stat.StunCheck(unit2);
                        Stat.BloodLossCheck(unit1);
                        Stat.BloodLossCheck(unit2);
                        Console.WriteLine($"раунд {FightCount + 1}");
                        unit1.InflictDamage(unit2);
                        unit2.InflictDamage(unit1);

                        FightCount++;
                        if (unit1.Health > 0 && unit2.Health <= 0)
                        {

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{unit1.Name} победил {unit2.Name}, дуэль закончилась");
                            Console.ResetColor();
                        }
                        if (unit2.Health > 0 && unit1.Health <= 0)
                        {

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{unit2.Name} победил {unit1.Name}, дуэль закончилась");
                            Console.ResetColor();
                        }

                    }
                    
                    break;
                    
                case 2:

                    Console.WriteLine();
                    Console.WriteLine($"Сейчас вы наблюдаете сражение между {unit2.Name} и {unit1.Name}");
                    Console.WriteLine($" Первым атакует {unit2.Name} ");
                    Console.WriteLine();
                    unit2.BaseInfo();
                    unit1.BaseInfo();

                    while (unit1.Alive && unit2.Alive)
                    {
                        Stat.StunCheck(unit1);
                        Stat.StunCheck(unit2);
                        Stat.BloodLossCheck(unit1);
                        Stat.BloodLossCheck(unit2);
                        

                        Console.WriteLine($"раунд {FightCount + 1}");
                        unit2.InflictDamage(unit1);
                        unit1.InflictDamage(unit2);
                        FightCount++;
                        if (unit1.Health > 0 && unit2.Health <= 0)
                        {

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{unit1.Name} победил {unit2.Name}, дуэль закончилась");
                            Console.ResetColor();
                        }
                        if (unit2.Health > 0 && unit1.Health <= 0)
                        {

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{unit2.Name} победил {unit1.Name}, дуэль закончилась");
                            Console.ResetColor();
                        }

                    }
                    
                    break;
            }

            Stat.FootmanQuant--;
            

        }
    }
}
