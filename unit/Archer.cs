using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using unit.Items;

namespace unit
{
    internal class Archer : Unit
    {

        private int _armor;
        public delegate void InflictDamageDelegate(Unit unit);
        public InflictDamageDelegate inflictDamage;
        public Archer(string name, int maxHealth, int speed, int damage, int defence, int armor)
             : base(name, maxHealth, speed, defence)
        {
            _armor = armor;
        }


        public Archer() : base("Archer", 50, 15, 4)
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
        //public  int Health
        //{
        //    get { return Health; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            Health = 0;
        //        }
        //        else if (Health > 0)
        //        {
        //            Health += _defence;
        //        }

        //        else
        //            Health = value;
        //    }
        //}
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
                            unit.Health = unit.Health - Damage;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{Name} сделал выстрел, здоровье противника: {unit.Health}/{unit.MaxHealth} ");


                            Console.ResetColor();

                        }


                        if (unit.Health <= 0)
                        {
                            Console.WriteLine("Вы не можете больше стрелять так как противник мертв");
                            Stat.KilledQuant++;
                            unit.Alive = false;

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
        public void InflictDamage(Unit unit)
        {
            inflictDamage = InflictDamageMethod;
            inflictDamage(unit);
        }
        public override void BaseInfo()
        {
            if (Health < MaxHealth * 0.4)
            {
                Speed += 4;
                Speed = 15;
            }
            else
                Speed = 11;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Name:{Name} Health: {Health}/{MaxHealth} Damage: {Damage} Defence : {Defence} Speed: {Speed} Armor : {Armor}");
            Console.ResetColor();
        }

    }
}


