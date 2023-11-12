using unit.Items;

namespace unit
{
    internal class Duel
    {

        internal static void Fighting(Unit unit1, Unit unit2)
        {
            Console.WriteLine($"Выберите того,кто будет первым атаковать:\n" +
                $"1.{unit1.Name}\n" +
                $"2.{unit2.Name}");
            Console.WriteLine();
            int choice = int.Parse( Console.ReadLine());
            Console.WriteLine(); 
            Console.WriteLine($"{unit1.Name}, Выберите оружие атаковать:\n" +
                $"1. Axe\n" +
                $"2. Sword\n" +
                $"3. Mace\n" +
                $"4. Bow");
            Console.WriteLine();
            int GunChoice = int.Parse(Console.ReadLine());
            switch (GunChoice) 
            {
                case 1:
                    {
                        unit1.Weapon = new Axe();
                        unit1.Weapon.ShowWeaponInfo();
                    }
                    break;
                case 2:
                    {
                        unit1.Weapon = new Sword();
                        unit1.Weapon.ShowWeaponInfo();
                    }
                    break;

                case 3:
                    {
                        unit1.Weapon = new Mace();
                        unit1.Weapon.ShowWeaponInfo();
                    }
                    break;

                case 4:
                    {
                        unit1.Weapon = new Bow();
                        unit1.Weapon.ShowWeaponInfo();
                    }
                    break;
            }
            Console.WriteLine();
            Console.WriteLine($"{unit2.Name}, Выберите оружие атаковать:\n" +
                $"1. Axe\n" +
                $"2. Sword\n" +
                $"3. Mace\n" +
                $"4. Bow");
            Console.WriteLine();
            int GunChoice1 = int.Parse(Console.ReadLine());
            switch (GunChoice1)
            {
                case 1:
                    {
                        unit1.Weapon = new Axe();
                        unit1.Weapon.ShowWeaponInfo();
                    }
                    break;
                case 2:
                    {
                        unit1.Weapon = new Sword();
                        unit1.Weapon.ShowWeaponInfo();
                    }
                    break;

                case 3:
                    {
                        unit1.Weapon = new Mace();
                        unit1.Weapon.ShowWeaponInfo();
                    }
                    break;

                case 4:
                    {
                        unit1.Weapon = new Bow();
                        unit1.Weapon.ShowWeaponInfo();
                    }
                    break;
            }
            switch (choice)
            {
                case 1:

                    Console.WriteLine($"Сейчас вы наблюдаете сражение между {unit1.Name} и {unit2.Name}");
                    Console.WriteLine($" Первым атакует {unit1.Name} ");
                    unit1.BaseInfo();
                    unit2.BaseInfo();
                    while (unit1.Alive && unit2.Alive)
                    {
                        unit1.InflictDamage(unit2);
                        unit2.InflictDamage(unit1);
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
                    Stat.FootmanQuant--;
                    Stat.LiveQuant--;
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
 
                        unit2.InflictDamage(unit1);
                        unit1.InflictDamage(unit2);
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
                    Stat.FootmanQuant--;
                    Stat.LiveQuant--;
                    break;
            }

            

        }
    }
}
