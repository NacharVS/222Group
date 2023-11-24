using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Fight
     
    {
        public Bow bowforgraves = new Bow();
        public Sword swordforzak = new Sword();
        public Archer zak = new Archer("zak", 40, 11, false);
        public Footman graves = new Footman("graves", 60, 10, true);


        public void Arenavoins()
        {
            graves.Weapon = bowforgraves;
            zak.Weapon = swordforzak;

            Console.WriteLine("Выберите: 1.Мечник 2.Лучник");
            var vibor1 = Convert.ToInt32(Console.ReadLine());
            if (vibor1 == 1)
            {
                Console.WriteLine($"Ваш воин готов к битве и его имя{zak.Name}");
            }
            else 
            if (vibor1 == 2)
            {
                Console.WriteLine($"Ваш воин готов к битве и его имя{graves.Name}");
            }
            else
            {
                Console.WriteLine("Такого нет");
            }
            Battle();
            void Battle()
            {
                Console.WriteLine("Выберите действие\n 1.Нанести урон\n 2.Сдаться\n 3.Самоубийство(показать возможности)");
                var vibor2 = Convert.ToInt32(Console.ReadLine());
                if (vibor2 == 1 && vibor1 == 1)
                {
                    zak.Weapon.attackSS(graves);
                    Console.WriteLine("Вас атакует Лучник!!!");
                    graves.Weapon.attackSS(zak);
                    if (zak.Health != 0 || graves.Health != 0)
                    {
                        Battle();
                    }
                    else
                    if (zak.Health == 0 || graves.Health == 0)
                    {
                        return;
                    }
                }
                else
                if (vibor2 == 1 && vibor1 == 2)
                {
                    graves.Weapon.attackSS(zak);
                    Console.WriteLine("Вас атакует мечник!!!");
                    zak.Weapon.attackSS(graves);
                    if (zak.Health != 0 || graves.Health != 0)
                    {
                        Battle();
                    }
                    else
                    if (zak.Health == 0 || graves.Health == 0)
                    {
                        return;
                    }
                }

                else
                if (vibor2 == 2 && vibor1 == 2)
                {
                    Console.WriteLine("Адк руина");
                }

                else
                if (vibor2 == 2 && vibor1 == 1)
                {
                    Console.WriteLine("Гарен мусор");
                }
                else
                {
                    return;
                }
            }
                
            //if (vibor2 == 1 && vibor1 == 1)
            //{
            //    zak.Weapon.attackSS(graves);
            //    Console.WriteLine("Вы нанесли урон, zak!");
            //    graves.BaseInfo();
            //    graves.Weapon.attackSS(zak);
            //    Console.WriteLine("Вас атаковали в ответ!");
            //    zak.BaseInfo();
            //}
            //else
            //if (vibor2 == 1 && vibor1 == 2)
            //{
            //    graves.Weapon.attackSS(zak);
            //    Console.WriteLine("Вы нанесли урон, graves!");
            //    zak.Weapon.attackSS(graves);
            //}
            //else
            //if (vibor2 == 2)
            //{
            //    Console.WriteLine("FF15");
            //}
            //else
            //{
            //    return;
            //}



        }
        
    }
}
