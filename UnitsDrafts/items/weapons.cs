using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UnitsDrafts.items
{
    internal class Weapons
    {
       
        public string Wname;
        public int MinDamage;
        public int MaxDamage;
        public int Accuracy;
        public int Durabulity;
        public int SpeedAttack;
        public int DamageW;



        public Weapons(string _wname,int _speedat,int _mindamage ,int _maxdamage ,int _durabulity, int _accuracy)
        {
            Random rnd = new Random();
            _wname = Wname;
            _speedat = SpeedAttack;
            _mindamage = MinDamage;
            _maxdamage = MaxDamage;
            _durabulity = Durabulity;
            _accuracy = Accuracy;
            DamageW = rnd.next(MinDamage, MaxDamage);
        }

        public void Damage(Unit unit, Weapons weapon)
        {
            if (unit._defence >= 1) //Armour
            {
                unit.Health = unit.Health - ( weapon.DamageW / unit._defence);
                Console.WriteLine($" У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");
            }
            else
            {
                unit.Health = unit.Health - weapon.DamageW;
                Console.WriteLine($" У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");
            }
        }

        public int Speed(int _speedat)
        {
            
        }

    }
}
