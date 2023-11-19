using System;
using Units_222_Draft.items;

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
//public static void gnome()
//{
//    //Выводит список всего оружия с сотрировкой от меньшего мин урона до большего
//    Console.WriteLine("Гномья сортировка");

//    Sword sword = new Sword(); Axe axe = new Axe(); Bow bow = new Bow(); Mace mace = new Mace();
//    var array = new Weapon[4] { sword, axe, bow, mace };
//    var ildar = GnomeSort(array);

//    foreach (Weapon weapon in ildar)
//    {
//        Console.WriteLine(weapon.Name + " " + weapon.MinDamage);
//    }

//    static void Swap(ref Weapon item1, ref Weapon item2)
//    {
//        var temp = item1;
//        item1 = item2;
//        item2 = temp;
//    }

//    //Гномья сортировка
//    static Weapon[] GnomeSort(Weapon[] unsortedArray)
//    {
//        var index = 1;
//        var nextIndex = index + 1;

//        while (index < unsortedArray.Length)
//        {
//            if (unsortedArray[index - 1].MinDamage < unsortedArray[index].MinDamage)
//            {
//                index = nextIndex;
//                nextIndex++;
//            }
//            else
//            {
//                Swap(ref unsortedArray[index - 1], ref unsortedArray[index]);
//                index--;
//                if (index == 0)
//                {
//                    index = nextIndex;
//                    nextIndex++;
//                }
//            }
//        }

//        return unsortedArray;
//    }
//}
