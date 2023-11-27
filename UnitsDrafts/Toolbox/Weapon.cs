using System;
using System.Threading.Tasks;
using System.Xml.Linq;
using UnitsDrafts.UnitsAll;
using static UnitsDrafts.Weapon;

namespace UnitsDrafts
{
    internal class Weapon
    {//fdsjfduhfdskkkk

        public Weapon(string name, int minDamage, int maxDamage, int attackSpeed, int accuracy, int durability, bool Bleed, int stunchance)
        {
            WepName = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            AttackSpeed = attackSpeed;
            Accuracy = accuracy;
            Durability = durability;
            Bleede = Bleed;
            Stunchance = stunchance;
            WeaponDropped = false;
        }

        public string WepName { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int AttackSpeed { get; set; }
        public int Accuracy { get; set; }
        public int Durability { get; set; }
        public bool Bleede { get; set; } = false;
        public int Stunchance { get; set; }
        public bool WeaponDropped { get; set; }

        public int attack(Unit unit)
        {
            if (AttackSpeed < 5)
            {
                Console.Clear();
                Console.WriteLine("Вы замахнулись оружием");
                Thread.Sleep(3000);
                var x = new Random().Next(0, 100);
                var z = new Random().Next(0, 100);
                if (x <= Accuracy && Durability != 0 && WeaponDropped == false)
                {
                    Durability = Durability - 50;
                    unit.Health = unit.Health - new Random().Next(MinDamage, MaxDamage + 1);
                    Console.WriteLine("Вы попали");
                    if (z <= Stunchance)
                    {
                        unit.Weapon.WeaponDropped = true;
                        Console.WriteLine("Чела застанили!");
                    }

                    unit.BaseInfo();


                }
                else if (x <= Accuracy && Durability != 0 && WeaponDropped == false)
                {
                    Durability = Durability - 50;
                    unit.Health = unit.Health - new Random().Next(MinDamage, MaxDamage + 1);
                    Console.WriteLine("Вы попали");
                    if (z <= Stunchance)
                    {
                        unit.Weapon.WeaponDropped = true;
                        Console.WriteLine("Чел застанился!");
                    }
                    unit.BaseInfo();
                }
                else if (WeaponDropped == true)
                {
                    Console.WriteLine("Вы оглушены");
                    WeaponDropped = false;
                }
                else if (Durability == 0)
                {
                    Console.WriteLine("Оружие сломана");
                    return 0;
                }
                else
                {
                    Console.WriteLine("Вы промахнулись");
                    return 0;
                }

            }
            else if (AttackSpeed < 100000 && AttackSpeed >= 5)
            {
                Console.Clear();
                Console.WriteLine("Вы замахнулись оружием");
                Thread.Sleep(1500);
                var x = new Random().Next(0, 100);
                var z = new Random().Next(0, 100);
                if (x <= Accuracy && Durability != 0 && WeaponDropped == false)
                {
                    Durability = Durability - 50;
                    unit.Health = unit.Health - new Random().Next(MinDamage, MaxDamage + 1);
                    Console.WriteLine("Вы попали");
                    if (z <= Stunchance)
                    {
                        unit.Weapon.WeaponDropped = true;
                        Console.WriteLine("Чела застанили!");
                    }
                    unit.BaseInfo();

                }
                else if (x <= Accuracy && Durability != 0 && WeaponDropped == false)
                {
                    Durability = Durability - 50;
                    unit.Health = unit.Health - new Random().Next(MinDamage, MaxDamage + 1);
                    Console.WriteLine("Вы попали");
                    if (z <= Stunchance)
                    {
                        unit.Weapon.WeaponDropped = true;
                        Console.WriteLine("Чела застанили!");
                    }
                    unit.BaseInfo();
                }
                else if (WeaponDropped == true)
                {
                    Console.WriteLine("Вы оглушены");
                    WeaponDropped = false;

                }
                else if (Durability == 0)
                {
                    Console.WriteLine("Оружие сломана");
                    return 0;
                }
                else
                {
                    Console.WriteLine("Вы промахнулись");
                    return 0;
                }
            }
            return 0;

        }
    }
}