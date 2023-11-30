using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Fight
    {
        public Sword sword = new Sword();
        public Bow bow = new Bow();
        public Archer archer = new Archer("Bob", 40, 11);
        public Footman footman = new Footman("Pop", 50, 20, 10, 2);

        public void Figt()
        {
            archer._weapon = bow;
            footman._weapon = sword;
            while(true)
            if (footman.Health > 0 && archer.Health > 0)
            {
                Console.WriteLine("Выберите своего героя: 1.Мечник 2.Лучник 3.Топорист 4.Буловист");
                var shag1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Выберите действие: 1.Ударить 2.Убежать");
                var shag2 = Convert.ToInt32(Console.ReadLine());
                switch (shag1)
                {
                    case 1:
                        Console.WriteLine($"Ваш воин готов к битве и его имя{footman.Name}");
                        switch (shag1)
                        {
                            case 1:
                                footman._weapon.Metodataki(archer);
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine($"Ваш воин готов к битве и его имя{archer.Name}");
                        switch (shag2)
                        {
                            case 1:
                                archer._weapon.Metodataki(footman);
                                break;
                        }
                        break;
                }
            }
            else
            {
                Win();
                break;
            }
        }
        public void Win()
        {
            if (archer.Health > footman.Health)
            {
                Console.WriteLine("archer  победид");
            }
            else
         if (footman.Health > archer.Health)
            {
                Console.WriteLine("footman победил");
            }
            else
            {
                Console.WriteLine("Победителя нет");
            }
        }
    }
}
