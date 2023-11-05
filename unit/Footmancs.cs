﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using unit.Items;

namespace unit
{
    internal class Footman : Unit
    {

        private int _armor;
        private Weapon _weapon;
        public Footman(string name, int maxHealth, int speed, int damage, int defence, int armor)
            : base(name, maxHealth, speed, damage, defence)
        {
            _armor = armor;
            _weapon = new Sword();
        }

        public Footman() : base("Footman", 50, 11, 10, 7)
        {
            _armor = 3;
            

        }


        public int Armor
        {
            get { return _armor; }
            set
            {
                _armor = value;
            }
        }


        public override void InflictDamage(Unit unit)
        {
            if (Alive)
            {
                if (Stun)
                {
                    Console.WriteLine("Противник оглушен");
                }
                else
                {
                    if (unit.Alive)
                    {
                        if(Weapon.Alive)
                        {
                            if (unit.Health > 0)
                            {
                                double Damage = Weapon.Hit(unit);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{Name} сделал выстрел, здоровье противника: {unit.Health}/{unit.MaxHealth} ");


                                Console.ResetColor();

                            }
                            if (Health < MaxHealth * 0.4)
                            {
                                Damage = Damage + 5;
                                Damage = 15;
                            }
                            if (unit.Health <= 0)
                            {
                                Console.WriteLine("Вы не можете больше стрелять так как противник мертв");

                            }
                        }


                    }
                    else
                    {
                        Console.WriteLine("Юнит мертв");
                    }
                }
            }
            else
            {
                Console.WriteLine($"{Name} не может атаковать , он мертв");
            }



        }

        public virtual void ArmorTake(int armor)
        {
            armor = Armor;
            int takedarmor = Damage - armor;

            if(takedarmor >= Damage)
            {
                Health += 0;
            }
            Health += armor;
            Armor -= 1;
        }
    //    defence = Defence;
    //        int takedDamage = Damage - defence;
    //        if (takedDamage >= Damage)
    //        {
    //            Health += 0;

    //        }
    //Health += takedDamage;
        public override void BaseInfo()
        {
            if (Health <= 0)
            {
                Console.WriteLine($"Name:{Name} Статус: Мертв");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Damage: {Damage} Defence : {Defence} Armor : {Armor} Статус: Жив");
                Console.ResetColor();
            }
        }
        
    }
}

//if (Defence > Damage)
//{
//    Defence = Damage;
//    unit.Health = unit.Health + (Damage - Defence);
//    Console.ForegroundColor = ConsoleColor.Red;
//    //Console.WriteLine($"Вы сделали выстрел, здоровье противника: {unit.Health}/{unit.MaxHealth} ");
//    Console.ResetColor();
//}
//else
//    unit.Health = unit.Health + (Damage - Defence);
//Console.ForegroundColor = ConsoleColor.Red;
//Console.WriteLine($"Вы сделали выстрел, здоровье противника: {unit.Health}/{unit.MaxHealth} ");
//Console.ResetColor();
