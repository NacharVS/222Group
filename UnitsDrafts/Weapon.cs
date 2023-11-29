using System;
using System.Threading.Tasks;
using System.Xml.Linq;
using static UnitsDrafts.Weapon;

namespace UnitsDrafts
{
    internal class Weapon
    {
        //делегат
        //делегат делегат
        //метод в который закидываешь метод
        // и в завистимости от ситуации подставляешь разные методы в делегат
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
        //public delegate void DamageDeligate(Unit unit, Weapon weapon);
        //DamageDeligate damage;
        public string WepName { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int AttackSpeed { get; set; }
        public int Accuracy { get; set; }
        public int Durability { get; set; }
        public bool Bleede { get; set; } = false;
        public int Stunchance { get; set; }
        public bool WeaponDropped { get; set; }



        //public virtual int Hit(Unit unit)
        //{
        //    var x = new Random().Next(1, 101);
        //    if (Bleede = true && x <= Accuracy && Durability != 0)
        //    {
        //        return new Random().Next(MinDamage, MaxDamage + 1);
        //        Thread.Sleep(10000);
        //        for (int i = 5; i >= 0; i--)
        //        {
        //            return unit.Health = unit.Health - new Random().Next(1, 5);

        //        }

        //    }
        //    if (x <= Accuracy && Durability != 0)
        //    {
        //        Durability = Durability - 50;
        //        return unit.Health = unit.Health - new Random().Next(MinDamage, MaxDamage + 1);
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
        public int attackSS(Unit unit)
        {
            if (AttackSpeed < 5)
            {
                Console.WriteLine("Вы замахнулись оружием");
                Thread.Sleep(3000);               
                var x = new Random().Next(1, 101);
                var z = new Random().Next(1, 101);
                if (Bleede == true && x <= Accuracy && Durability != 0 && WeaponDropped == false)
                {
                    Durability = Durability - 50;
                    unit.Health = unit.Health - new Random().Next(MinDamage, MaxDamage + 1);
                    Console.WriteLine("Вы попали");
                    if (z <= Stunchance)
                    {
                        unit.Weapon.WeaponDropped = true;
                        Console.WriteLine("Stun applied!");
                    }
                    
                    unit.BaseInfo();
                    Thread.Sleep(3000);
                    Console.WriteLine("У врага началось кровотечение");
                    for (int i = 5; i >= 0; i--)
                    {
                        Thread.Sleep(1000);
                        unit.Health = unit.Health - new Random().Next(1, 5);
                        unit.BaseInfo();
                    }

                }
                else
                if (x <= Accuracy && Durability != 0 && WeaponDropped == false)
                {
                    Durability = Durability - 50;
                    unit.Health = unit.Health - new Random().Next(MinDamage, MaxDamage + 1);
                    Console.WriteLine("Вы попали");
                    if (z <= Stunchance)
                    {
                        unit.Weapon.WeaponDropped = true;
                        Console.WriteLine("Stun applied!");
                    }
                    unit.BaseInfo();
                }
                else
                if (WeaponDropped == true)
                {
                    Console.WriteLine("Вы оглушены");
                    WeaponDropped = false;
                }
                else
                if (Durability == 0)
                {
                    Console.WriteLine("Оружие сломана");
                    return 0;
                }
                else
                {
                    Console.WriteLine("Вы промохнулись");
                    return 0;
                }

            }
            else
            if (AttackSpeed < 30 && AttackSpeed >= 5)
            {
                Console.WriteLine("Вы замохнулись оружием");
                Thread.Sleep(1500);
                var x = new Random().Next(1, 101);
                var z = new Random().Next(1, 101);
                if (Bleede == true && x <= Accuracy && Durability != 0 && WeaponDropped == false)
                {
                    Durability = Durability - 50;
                    unit.Health = unit.Health - new Random().Next(MinDamage, MaxDamage + 1);
                    Console.WriteLine("Вы попали");
                    if (z <= Stunchance)
                    {
                        unit.Weapon.WeaponDropped = true;
                        Console.WriteLine("Stun applied!");
                    }
                    unit.BaseInfo();
                    Thread.Sleep(1500);
                    Console.WriteLine("У врага началось кровотечение");
                    for (int i = 5; i >= 0; i--)
                    {
                        Thread.Sleep(1000);
                        unit.Health = unit.Health - new Random().Next(1, 5);
                        unit.BaseInfo();
                    }
                }
                else
                if (x <= Accuracy && Durability != 0 && WeaponDropped == false)
                {
                    Durability = Durability - 50;
                    unit.Health = unit.Health - new Random().Next(MinDamage, MaxDamage + 1);
                    Console.WriteLine("Вы попали");
                    if (z <= Stunchance)
                    {
                        unit.Weapon.WeaponDropped = true;
                        Console.WriteLine("Stun applied!");
                    }
                    unit.BaseInfo();
                }
                else
                if (WeaponDropped == true)
                {
                    Console.WriteLine("Вы оглушены");
                    WeaponDropped = false;
                    
                }
                else
                if (Durability == 0)
                {
                    Console.WriteLine("Оружие сломана");
                    return 0;
                }
                else
                {
                    Console.WriteLine("Вы промохнулись");
                    return 0;
                }
            }
            return 0;
        }
    }
}
