using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using unit.items;
using UnitsDrafts;
using UnitsDrafts.unit.items;

namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        public delegate void InflictDamageDelegate(Unit unit);

        public InflictDamageDelegate inflictDamage;

        private int _damage;

        public Weapon _weapon;

        public Footman() : base("Footman", 30, 10, 10, 30, 3) 
        {
            _weapon = new Sword();
        }
        public override void GiveDamage(Unit unit)
        {
            dealDamage = DealDamageMethod1;
            dealDamage(unit);
        }
        public void InflictDamageMethod(Unit unit)
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

        public void InflictDamage(Unit unit) 
        {
            inflictDamage = InflictDamageMethod;
            inflictDamage(unit);
        }
    }
}
            

       