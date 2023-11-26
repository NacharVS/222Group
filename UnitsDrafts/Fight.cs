using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsDrafts.Items;

namespace UnitsDrafts
{
    internal class Fight
    {
        public Bow bow = new Bow();
        public Sword sword= new Sword();
        public Archer Bogdan = new Archer();
        public Footman Arkadiy = new Footman();

        public void Bitvaalkashei()
        {
            Bogdan.weapon = bow;
            Arkadiy.weapon = sword;

            Console.WriteLine("Выберите: 1.Мечник 2.Лучник");
            var vibor1 = Convert.ToInt32(Console.ReadLine());
            if (vibor1 == 1)
            {
                Console.WriteLine($"Юнит готов {Bogdan.Name}");
            }
            else
            if (vibor1 == 2)
            {
                Console.WriteLine($"Юнит готов {Arkadiy.Name}");
            }
            else
            {
                Console.WriteLine("Такого юнита нет");
            }

            Battle();
            void Battle()
            {
                Console.WriteLine("Выберите действие\n 1.Нанести урон\n 2.Сдаться\n 3.Самоубийство(показать возможности)");
                var vibor2 = Convert.ToInt32(Console.ReadLine());
                if (vibor2 == 1 && vibor1 == 1)
                {
                    Bogdan.weapon.AttackSpeed(Arkadiy);
                    Console.WriteLine("Вас атакует Лучник!");
                    Arkadiy.weapon.AttackSpeed(Bogdan);
                    if (Bogdan.Health != 0 || Arkadiy.Health != 0)
                    {
                        Battle();
                    }
                    else
                    if (Bogdan.Health == 0 || Arkadiy.Health == 0)
                    {
                        return;
                    }
                }
                else
                if (vibor2 == 1 && vibor1 == 2)
                {
                    Arkadiy.weapon.AttackSpeed(Bogdan);
                    Console.WriteLine("Вас атакует мечник!");
                    Bogdan.weapon.AttackSpeed(Arkadiy);
                    if (Bogdan.Health != 0 || Arkadiy.Health != 0)
                    {
                        Battle();
                    }
                    else
                    if (Bogdan.Health == 0 || Arkadiy.Health == 0)
                    {
                        return;
                    }
                }

                else
                if (vibor2 == 2 && vibor1 == 2)
                {
                    Console.WriteLine("Vac");
                }

                else
                if (vibor2 == 2 && vibor1 == 1)
                {
                    Console.WriteLine("Ban");
                }
                else
                {
                    return;
                }
            }




        }
    }
}
