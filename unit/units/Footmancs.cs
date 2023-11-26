using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using unit.Items;

namespace unit.units
{
    internal class Footman : Unit
    {

        private int _armor;
        public delegate void InflictDamageDelegate(Unit unit);
        public InflictDamageDelegate inflictDamage;
        public Footman(string name, int maxHealth, int speed, int damage, int defence, int armor)
            : base(name, maxHealth, speed, defence)
        {
            _armor = armor;
            Weapon = new Mace();

        }
        //public Weapon Weapon
        //{
        //    get { return _weapon; }
        //    set
        //    {
        //        _weapon = value;
        //    }
        //}

        public int Armor
        {
            get { return _armor; }
            set
            {
                _armor = value;
            }
        }


        public override void InflictDamageMethod(Unit unit)
        {

            if (Alive)
            {
                if (Stun)
                {
                    Console.WriteLine($"{Name} оглушен");
                    unit.Stun = false;
                }
                else
                {
                    if (unit.Alive)
                    {

                        if (unit.Health > 0)
                        {
                            var Damage = Weapon.Hit(unit);
                            unit.Health -= Damage;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{Name} сделал выстрел, здоровье {unit.Name}: {unit.Health}/{unit.MaxHealth} ");


                            Console.ResetColor();

                        }
                        if (Health < MaxHealth * 0.4)
                        {
                            Damage = Damage + 5;
                            Damage = 15;
                        }
                        if (unit.Health <= 0)
                        {
                            unit.Alive = false;
                            Stat.KilledQuant++;
                            Stat.LiveQuant--;
                            Console.WriteLine($"{Name} не может больше стрелять так как {unit.Name} мертв");

                        }
                        
                    }
                    else
                    {
                        Console.WriteLine($"{unit.Name} мертв");
                    }
                }
            }
            else
            {
                Console.WriteLine($"{Name} не может атаковать , он мертв");
            }



        }

        public void InflictDamage(Unit unit)
        {
            inflictDamage = InflictDamageMethod;
            inflictDamage(unit);
        }


        public virtual void ArmorTake(int armor)
        {
            armor = Armor;
            int takedarmor = Damage - armor;

            if (takedarmor >= Damage)
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
                Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Defence : {Defence} Armor : {Armor} Статус: Жив");
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
