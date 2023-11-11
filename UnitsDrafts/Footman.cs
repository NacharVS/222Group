using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using unit.items;
using UnitsDrafts;
using UnitsDrafts.unit.items;

namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        private int _defence;

        private int _damage;

        public Weapon _weapon;

        public Footman() : base("Footman", 30, 10, 10, 30, 3) 
        {

        }
        //public void Damage(Unit unit)
        //{
        //    Console.WriteLine("===========================================");
        //    Console.WriteLine("Игрок Footman");
        //    Console.WriteLine("===========================================");
        //    Console.WriteLine("Выберите оружие:");
        //    Console.WriteLine("1.Sword");
        //    Console.WriteLine("2.Axe");
        //    Console.WriteLine("3.Mace");
        //    Console.WriteLine("4.Bow");
        //    int f = Convert.ToInt32(Console.ReadLine());            
        //    if (f == 1)
        //    {
        //        _weapon = new Sword(); 
        //    }
        //    if (f == 2)
        //    {
        //        _weapon = new Axe();            
        //    }
        //    if (f == 3) 
        //    {
        //        _weapon = new Mace();
        //    }
        //    if(f == 4) 
        //    {
        //        _weapon = new Bow();
        //    }
        //    double damage = _weapon.Hit(unit);
        //    if (Stun)
        //    {
        //        damage = 0;
        //    }
        //    else
        //    {
        //        unit.Health -= damage;
        //    }
        //}
        public override void DealDamage(Unit unit)
        {
            int f = Convert.ToInt32(Console.ReadLine());
            if (f == 1)
            {
                _weapon = new Sword();
            }
            if (f == 2)
            {
                _weapon = new Axe();
            }
            if (f == 3)
            {
                _weapon = new Mace();
            }
            if (f == 4)
            {
                _weapon = new Bow();
            }
            double damage = _weapon.Hit(unit);
            if (Stun)
            {
                damage = 0;
            }
            if (Alive)
            {
                if (Stun)
                {
                    Console.WriteLine("Юнит оглушен - он не может атаковать. Damage = 0");
                }
                else
                {
                    if (unit.Alive)
                    {
                        Console.WriteLine($"{Name} нанес {damage} урона");
                        unit.Health = unit.Health - damage;

                        if (unit.Health <= 0)
                        {
                            Console.WriteLine($"{unit.Name} убит");
                            unit.Alive = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("зачем ты атакуешь труп?");
                    }
                }

            }
            else { Console.WriteLine("Юнит не может атаковать - он мертв"); }
        }
        public void InflictDamage(Unit unit)
        {
            if (Health < 24)
            {
                _damage = _damage + _damage / 2;
                unit.Health = unit.Health - _damage;
                Console.WriteLine($"Вашему герою нанесено {_damage} урона");
                _damage = 15;
            }
            else if (Health >= 24)
            {
                _damage = 15;
                unit.Health -= _damage;
                Console.WriteLine($"Вашему герою нанесено {_damage} урона");
                if (unit.Health < 0)
                {
                    _damage = 0;
                    Console.WriteLine("Юнит убит");
                }
            }
        }
    }
}
            

       