using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace unit
{
    internal class Archer : Unit
    {

        private int _armor;

        public Archer(string name, int maxHealth, int speed, int damage, int defence, int armor)
             : base(name, maxHealth, speed, damage, defence)
        {
            _armor = armor;
        }
        
            
        public Archer() : base("Archer", 50, 15, 9, 4)
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
        public  void ArcherDamage(Unit unit)
        {
            if (unit.Health >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                unit.Health = unit.Health - Damage;
                Console.Write($"Вы сделали выстрел, здоровье противника: {unit.HealthAfterDamage()} ");
                Console.ResetColor();
            }
            if (unit.Health <= 0)
            {
                Console.WriteLine("Вы не можете больше стрелять так как персонаж мертв");
            }
        
        }
        //public void Move(Archer archer)
        //{
        //    if (Health < MaxHealth *40/100)
        //    {
        //        Speed += 4;
        //    }
        //}
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


