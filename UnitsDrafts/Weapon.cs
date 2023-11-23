using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Weapon
    {
        public Weapon(string name, int maxDamage, int mindamage, int accuracy, int durability, int attackspeed, bool Krovotok)
        {
            Wepname = name;
            MaxDam = maxDamage;
            MinDam = mindamage;
            Acc = accuracy;
            Dura = durability;
            AttSp = attackspeed;
            Krovyaka = Krovotok;
        }
        public string Wepname { get; set; }
        public int MaxDam { get; set; }
        public int MinDam { get; set; }
        public int Acc { get; set; }
        public int Dura { get; set; }
        public int AttSp { get; set; }

        public bool Krovyaka { get; set; } = false; 
        public int Metodataki(Unit unit)
        {
            if (AttSp < 4)
            {
                Console.WriteLine("Вы натянули тетеву");
                Thread.Sleep(5000);
                var x = new Random().Next(1, 101);
                if (x <= Acc && Dura != 0)
                {
                    Console.W
                }

            }
        }


    }
}
    
   