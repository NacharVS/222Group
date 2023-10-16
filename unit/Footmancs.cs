using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace unit
{
    internal class Footman : Unit
    {

        private int _armor;
        public Footman(string name, int maxHealth, int speed, int damage, int defence, int armor)
            : base(name, maxHealth, speed, damage, defence)
        {
            _armor = armor;
        }

        public Footman() : base("Footman", 50, 11, 10, 7)
        {
            _armor = 4;

        }


        public int Armor
        {
            get { return _armor; }
            set
            {
                _armor = value;
            }
        }


        public void FootmanDamage(Unit unit)
        {
            if (unit.Health > 0)
            {
                unit.Health = unit.Health - Damage;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Вы сделали выстрел, здоровье противника: {unit.Health}/{unit.MaxHealth} ");


                Console.ResetColor();
                Stat.LiveQuant += 1;
            }
            //if (unit.Damage <= unit.Defence)
            ////{
            ////    Console.WriteLine("Вы сделали выстрел, но ваше оружие не смогло пробить противника"); 

            ////}
            if (Health < MaxHealth * 0.4)
            {
                Damage = Damage + 5;
                Damage = 15;
            }
            if(unit.Health <= 0 )
            {
                Console.WriteLine("Вы не можете больше стрелять так как противник мертв");
                Stat.KilledQuant += 1;
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
        }
        
        public virtual void ArmorTake(int armor)
        {
            armor = Armor;
            int takedarmor = Damage - armor;

            if(takedarmor >= Damage)
            {
                Health += 0;
            }
            Health += 1;
            armor -= 1;
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Damage: {Damage} Defence : {Defence} Armor : {Armor}" );
            Console.ResetColor();
        }
        
    }
}

