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
            if (AttSp < 3)
            {
                Thread.Sleep(2000);
                Console.WriteLine("Вы натянули тетеву");
                Thread.Sleep(6000);
                Console.WriteLine("Выстрел!!!");    
                var x = new Random().Next(1, 101);
                if (x <= Acc && Dura != 0)
                {
                    Console.WriteLine("Вы попали в цель");
                    Dura -= 8;
                    // возможно стоит добавить макс дура
                    unit.Health = unit.Health - new Random().Next(MinDam, MaxDam + 1);
                    unit.ShowInfo();
                    //Нужно сделать урон по юнита
                    // + точность
                }
                else
                {
                    Console.WriteLine("Вы промахнулись");
                    Dura -= 8;
                    unit.ShowInfo();
                    //- точность
                }
            }
            else if (AttSp < 6 && AttSp > 2)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Вы замахнулись буловой");
                Thread.Sleep(4500);
                var x = new Random().Next(1, 101);
                if (x <= Acc && Dura != 0)
                {
                    Console.WriteLine("Вы ударили по цели");
                    Dura -= 15;
                    unit.Health = unit.Health - new Random().Next(MinDam, MaxDam + 1);
                    unit.ShowInfo();
                }
                else
                {
                    Console.WriteLine("Вы не смогли ударить по цели");
                    unit.ShowInfo();
                    return 0;

                }
            }
            else if (AttSp > 5 && AttSp < 8)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Вы замахнулись топором");
                Thread.Sleep(3000);
                var x = new Random().Next(1, 101);
                if (x <= Acc && Dura != 0)
                {
                    Console.WriteLine("Вы ударили по цели");
                    Dura -= 10;
                    unit.Health = unit.Health - new Random().Next(MinDam, MaxDam + 1);
                    unit.ShowInfo();
                }
                else
                {
                    Console.WriteLine("Вы не смогли ударить по цели");
                    unit.ShowInfo();
                    return 0;
                }
            }
            else if (AttSp < 10 && AttSp < 7)
            {
                Console.WriteLine("Вы замахнулись мечом");
                Thread.Sleep(1000);
                var x = new Random().Next(1, 101);
                if (x <= Acc && Dura != 0)
                {
                    Console.WriteLine("Вы ударили по цели");
                    Dura -= 5;
                    unit.Health = unit.Health - new Random().Next(MinDam, MaxDam + 1);
                    unit.ShowInfo();
                }
                else
                {
                    Console.WriteLine("Вы не смогли ударить по цели");
                    unit.ShowInfo();
                    return 0;
                }
            }
            return 0;
        }  
 

                //// сделать кровотечение  for (int i = 5; i >= 0; i--)
                //{
                //    Thread.Sleep(1000);
                //    unit.Health = unit.Health - new Random().Next(1, 5);
                //    добавить инфу от юнито при каждом действии unit.BaseInfo();   
    }
}
    
   