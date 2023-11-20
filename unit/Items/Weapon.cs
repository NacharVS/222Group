using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit.units;

namespace unit.Items
{
    internal class Weapon
    {
        public string WeaponName;
        public int MinDamage;
        public int MaxDamage;
        public int AttackSpeed;
        public int Accuracy;
        public int Durability;
        public bool Alive = true;

        public int Level=0;
        public Weapon(string Name, int minDamage, int maxDamage, int attackSpeed, int accuracy, int durability)
        {
            WeaponName = Name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            AttackSpeed = attackSpeed;
            Accuracy = accuracy;
            Durability = durability;
           
        }


        public double DurabilityQuality()
        {
            
            if (Durability >= (Durability * 70) / 100)
            {
                return 1;
            }
            else if (Durability >=  (Durability * 40) / 100)
            {
                return 0.7;
            }
            else if (Durability > 0)
            {
                return 0.4;
            }
            
            else
            {
                Durability = 0;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Оружие сломалось, его следует починить");
                Console.ResetColor();
                return 0;

            }
        }
        public virtual double Hit(Unit unit)
        {
            Durability = Durability -2;
            if (Durability > 0)
            {
                
                int x = new Random().Next(1, 101);
                if (x <= Accuracy)
                {
                     double Damage = new Random().Next(MinDamage, MaxDamage+1);
                    Damage += Level * 5;
                    return Damage * DurabilityQuality();
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Оружие сломано");
                return 0;
            }

        }
        public void ShowWeaponInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"Текущие характеристики {WeaponName}: MaxDamage: {MaxDamage}, MinDamage:{MinDamage}, Accuracy : {Accuracy}, Durability:{Durability}");
            Console.ResetColor();

        }
        public void LevelUp()
        {
            if (Level < 10)
            {
                Level += 1;
                MaxDamage += 3;
                MinDamage += 2;
                Accuracy += 3;
                Durability += 20;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"Вы повысили уровень {WeaponName}, теперь его лвл: {Level}") ;
                Console.WriteLine($"у {WeaponName} увеличился max damage до {MaxDamage}, min damage до {MinDamage}, accuracy до {Accuracy} и durability до {Durability}");
                Console.ResetColor();

            }
            else
            {
                Console.WriteLine($"У {WeaponName} Максимальный уровень улучшения");
            }
        }
        
    }
}
