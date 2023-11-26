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
        public Weapon(string name, int maxDamage, int minDamage, int accuracy, int durability, int attackspeed, int Krovotok, int crit)
        {
            Wepname = name;
            MaxDam = maxDamage;
            MinDam = minDamage;
            Acc = accuracy;
            Dura = durability;
            AttSp = attackspeed;
            Nua = crit;
            Krovyaka = Krovotok;
        }
        public string Wepname { get; set; }
        public int MaxDam { get; set; }
        public int MinDam { get; set; }
        public int Acc { get; set; }
        public int Dura { get; set; }
        public int AttSp { get; set; }
        public int Nua { get; set; }
        public int Krovyaka { get; set; }





        //Может стоит написать
        //метод кровяки
        //и вызывать его внутри
        //метода






        public int Metodataki(Unit unit)
        {
            if (AttSp < 3 )
            {
                if (Dura != 0)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Вы натянули тетеву");
                    Thread.Sleep(6000);
                    Console.WriteLine("Выстрел!!!");
                    var x = new Random().Next(1, 101);
                    if (x <= Acc)
                    {
                        Console.WriteLine("Вы попали в цель");
                        Dura -= 8;
                        // возможно стоит добавить макс дура
                        if (y <= Nua)
                        {
                            unit.Health = unit.Health - new Random().Next(MinDam, MaxDam + 1) * 300 / 100;
                            unit.ShowInfo();
                            Console.WriteLine("Херанул критом");
                        }
                        else
                        {
                            unit.Health = unit.Health - new Random().Next(MinDam, MaxDam + 1);
                            Console.WriteLine("Крит не херанул");
                            unit.ShowInfo();
                        }
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
                else
                {
                    Console.WriteLine("Ваш лук сломан");

                }
            }
            else if (AttSp < 6 && AttSp > 2 )
            {
               if (Dura != 0)
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
                    }
                }
                else
                {
                    Console.WriteLine("Ваша булава сломана");

                }            
            }
            else if (AttSp > 5 && AttSp < 8)
            {
                if(Dura != 0)
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
                        var y = new Random().Next(1, 101);
                        if (y <= Krovyaka)
                        {
                            for (int i = 5; i >= 0; i--)
                            {
                                Thread.Sleep(1000);
                                unit.Health = unit.Health - 10;
                            }
                            Console.WriteLine("Пошла кровъ");
                        }    
                        unit.ShowInfo();
                    }
                    else
                    {
                        Console.WriteLine("Вы не смогли ударить по цели");
                        unit.ShowInfo();
                    }
                }
                else
                {
                    Console.WriteLine("Ваш топор сломан");
                }
            }
            else if (AttSp < 10 && AttSp > 7)
            {
                if (Dura != 0)
                {
                    Console.WriteLine("Вы замахнулись мечом");
                    Thread.Sleep(1000);
                    var x = new Random().Next(1, 101);
                    if (x <= Acc && Dura != 0)
                    {
                        Console.WriteLine("Вы ударили по цели");
                        Dura -= 5;
                        var y = new Random().Next(1, 101);
                        if (y <= Nua )
                        {
                            unit.Health = unit.Health - new Random().Next(MinDam, MaxDam + 1) * 150 / 100;
                            unit.ShowInfo();
                            Console.WriteLine("Херанул критом");
                        }
                        else
                        {
                            unit.Health = unit.Health - new Random().Next(MinDam, MaxDam + 1);
                            Console.WriteLine("Крит не херанул");
                            unit.ShowInfo();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы не смогли ударить по цели");
                        unit.ShowInfo();
                    }
                }
                else
                {
                    Console.WriteLine("Ваш меч сломан");
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
    
   