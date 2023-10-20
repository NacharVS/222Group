using System;

namespace UnitsDrafts
{
    class Test
    {
        public static int Training_show = 0;
        public static string How_To_Duel =
            "Чтобы успешно провести дуэль (или как минимум не умереть) нужно знание того по каким правилам работает дуэль в этом месте." +
            "\r\nЕсть два варианта того как закончить дуэль " +
            "\r\n1)Избей своего врага до смерти " +
            "\r\n2)Если победить не удастся то рекомендую свалить пока не поздно." +
            "\r\n  Учитывай что при побеге важна твоя ловкость";
        public static void How_to_Duel()
        {
            if (Training_show == 0)
            {
                Console.WriteLine("==================================================================================\n\r" +
                    "\n\r" +
                    How_To_Duel +
                    "\n\r" +
                    "\n\r==================================================================================");
                Console.WriteLine("Нажмите 1 чтобы не показывать обучение снова");
                int choise = Convert.ToInt32(Console.ReadLine());
                if (choise == 1)
                {
                    Training_show++;
                    Console.WriteLine("Обучение больше не покажется");
                }
            }
        }
    }
}
