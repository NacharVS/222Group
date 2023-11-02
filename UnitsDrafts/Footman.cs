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

        private Weapon _weapon;

        public Footman() : base("Footman", 30, 10, 10, 30, 3)
        {
        }
        public virtual void Damage(Unit unit)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("Игрок Footman");
            Console.WriteLine("===========================================");
            Console.WriteLine("Выберите оружие:");
            Console.WriteLine("1.Sword");
            Console.WriteLine("2.Axe");
            Console.WriteLine("3.Mace");
            Console.WriteLine("4.Bow");
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
            if(f == 4) 
            {
                _weapon = new Bow();
            }
            double damage = _weapon.Hit();
            if (damage <= 0)
            {
                Console.WriteLine("miss");
            }
            else
            {
                unit.Health -= damage;
            }
        }
        public void InflictDamage(Unit unit)
        {
            double _Damage = _weapon.Hit();
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
            

       