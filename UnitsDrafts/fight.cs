using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using unit.items;
using UnitsDrafts.unit.items;

namespace UnitsDrafts
{
    internal class Fight
    {
        public static int FightCount = 0;
        public static void Duel(Unit unit1, Unit unit2)
        {
            List<Weapon> weapons = new List<Weapon>() { new Sword(), new Axe(), new Mace(), new Bow() };
            List<Weapon> weaponss = new List<Weapon>() { new Sword(), new Axe(), new Mace(), new Bow() };
            if (unit1.Alive && unit2.Alive)
            {
                FightCount = 0;
                while (true)
                {
                    if (unit1.Alive && unit2.Alive)
                    {
                        Stat.StatusCheck(unit1);
                        Stat.StatusCheck(unit2);
                        Console.WriteLine($"{FightCount} ход");
                        for (int i = 0; i < 2; i++)
                        {
                            
                            Console.WriteLine("====================================");
                            Console.WriteLine($"Ход {unit1.Name}");
                            Console.WriteLine("====================================");
                            Console.WriteLine("Выберите оружие:");
                            Console.WriteLine("1.Sword");
                            Console.WriteLine("2.Axe");
                            Console.WriteLine("3.Mace");
                            Console.WriteLine("4.Bow");
                            int f = Convert.ToInt32(Console.ReadLine());
                            if (f == 1)
                            {
                                unit1._weapon = weapons[0];
                            }
                            if (f == 2)
                            {
                                unit1._weapon = weapons[1];
                            }
                            if (f == 3)
                            {
                                unit1._weapon = weapons[2];
                            }
                            if (f == 4)
                            {
                                unit1._weapon = weapons[3];
                            }
                            unit1.GiveDamage(unit2);
                            FightCount++;
                            Console.WriteLine("====================================");
                            Console.WriteLine($"Ход {unit2.Name}");
                            Console.WriteLine("====================================");
                            Console.WriteLine("Выберите оружие:");
                            Console.WriteLine("1.Sword");
                            Console.WriteLine("2.Axe");
                            Console.WriteLine("3.Mace");
                            Console.WriteLine("4.Bow");
                            f = Convert.ToInt32(Console.ReadLine());
                            if (f == 1)
                            {
                                unit2._weapon = weaponss[0];
                            }
                            if (f == 2)
                            {
                                unit2._weapon = weaponss[1];
                            }
                            if (f == 3)
                            {
                                unit2._weapon = weaponss[2];
                            }
                            if (f == 4)
                            {
                                unit2._weapon = weaponss[3];
                            }
                            unit2.GiveDamage(unit1);
                            FightCount++;
                        }
                    }
                    else
                    {
                        break;   
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("бой невозможен");
            }
        }
    }
}
