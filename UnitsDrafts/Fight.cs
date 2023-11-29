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

            while(zak.Health > 0 && graves.Health > 0) 
            {
                Console.WriteLine("Выберите: 1.Мечник 2.Лучник");
                var vibor1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Выберите действие\n 1.Нанести урон\n 2.Сдаться\n 3.Самоубийство(показать возможности)");
                var vibor2 = Convert.ToInt32(Console.ReadLine());

                switch (vibor1)
                {
                    case 1:
                        Console.WriteLine($"Ваш воин готов к битве и его имя{zak.Name}");
                        switch (vibor2)
                        {
                            case 1:
                                zak.Weapon.attackSS(graves);
                                if (zak.Health != 0 || graves.Health != 0)
                                {
                                    Arenavoins();
                                }
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine($"Ваш воин готов к битве и его имя{graves.Name}");
                        switch (vibor2)
                        {
                            case 1:
                                graves.Weapon.attackSS(zak);
                                if (zak.Health != 0 || graves.Health != 0)
                                {
                                    Arenavoins();
                                }                             
                                break;
                        }
                        break;
                }
            }
            if (zak.Health > graves.Health)
            {
                Console.WriteLine("Zak  победитель!!!");
            }
            else
            if (graves.Health > zak.Health)
            {
                Console.WriteLine("Graves победитель!!!");
            }
            else
            {
                Console.WriteLine("Победителя нету");
            }
        }

    }
}
