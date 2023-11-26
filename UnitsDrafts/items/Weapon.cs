using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UnitsDrafts
{
    internal class Weapon
    {
       
        public string Wname;
        public int MinDamage;
        public int MaxDamage;
        public int Accuracy;
        public int Durabulity;
        public int SpeedAttack;

        Random rnd = new Random();
        
        public Weapon(string _wname,int _speedat,int _mindamage ,int _maxdamage ,int _durabulity, int _accuracy)
        {
            
            _wname = Wname;
            _speedat = SpeedAttack;
            _mindamage = MinDamage;
            _maxdamage = MaxDamage;
            _durabulity = Durabulity;
            _accuracy = Accuracy;
            
        }

        public void Damage(Unit unit)
        {
            if (unit._defence >= 1) //Armour
            {
                unit.Health = unit.Health - (MinDamage / unit._defence);
                Console.WriteLine($" У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");
            }
            else
            {
                unit.Health = unit.Health - MinDamage;
                Console.WriteLine($" У {unit.Name} осталось {unit.Health} из {unit.MaxHealth}");
            }
        }

        //public int Speed(int _speedat)
        //{

        //}

    }
}
