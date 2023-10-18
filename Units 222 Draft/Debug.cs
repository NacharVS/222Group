using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    class Test
    {
        public static void Debug()
        {
            Barracs bar1 = new Barracs();
            Townhall th1 = new Townhall();
            var ft1 = bar1.SpawnFootman();
            var ps1 = th1.SpawnPeasant();
            var ac1 = bar1.SpawnArcher();
            var bp1 = th1.SpawnBishop();
            while (true)
            {
                Console.WriteLine("1)Перейти к списку");
                Console.WriteLine("2) Статистика");
                Console.WriteLine("0) Остановить Дебаг");
                int choise = Convert.ToInt32(Console.ReadLine());
                if (choise == 0)
                {
                    break;
                }
                switch (choise)
                {
                    case (1):
                        while (true)
                        {

                            Console.WriteLine("1) Убить юнита ");
                            Console.WriteLine("2) Ударить лучника");
                            Console.WriteLine("3) Привести мечника в ярость");
                            Console.WriteLine("0) Вернуться в меню");
                            choise = Convert.ToInt32(Console.ReadLine());
                            if (choise == 0)
                            {
                                break;
                            }
                            switch (choise)
                            {

                                case (1):
                                    ft1.Alive = false;
                                    ft1.BaseInfo();
                                    break;
                                case (2):
                                    ft1.DealDamage(ac1);
                                    break;
                                case (3):
                                    ft1.Health = ft1.MaxHealth * 0.39;
                                    break;
                            }
                        }

                        break;
                    case 2:
                        Stat.ShowInfo();
                        break;
                }
            }
        }
        public static void How_to_Duel()
        {
            Console.WriteLine("Чтобы успешно провести дуэль (или как минимум не умереть) нужно знание того по каким правилам работает дуэль в этом месте. /r/n Есть два варианта закончитьь дуэль 1) Один из участников умрет - просто забей своего врага руками 2) Какой то из участников сбежит - если победить не удасться то рекомендую свалить пока не поздно, прожимай кнопку побега и, в зависимости от своей ловкости, сбежишь");
        }
    }
}
