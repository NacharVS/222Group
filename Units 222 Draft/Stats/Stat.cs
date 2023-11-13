using System;
using Units_222_Draft.units;
using Units_222_Draft.items;
using UnitsDrafts;

namespace Units_222_Draft.Stats
{
    internal class Stat
    {
        public static int BishopQuantity = 0;
        public static int PeasantQuantity = 0;
        public static int FootmanQuantity = 0;
        public static int ArcherQuantity = 0;
        public static int CorpseQuantity = 0;
        public static int AliveQuantity = 0;
        public static List<Unit> units = new List<Unit>();
        public static int StunCount = 0;
        public static void ShowInfo()
        {
            Console.WriteLine($"{FootmanQuantity} Пехотинцов");
            Console.WriteLine($"{ArcherQuantity} Лучников");
            Console.WriteLine($"{BishopQuantity} Магов");
            Console.WriteLine($"{PeasantQuantity} Крестьян");
            Console.WriteLine($"{AliveQuantity - CorpseQuantity} Живо");
            Console.WriteLine($"{CorpseQuantity} Убито");
        }
        
        public static void StatusCheck(Unit unit)
        {
            StunCheck(unit);
            BloodLoss(unit);
            //тут идет чек всех статутсов из разряда стана и кровотека -  
            //если они вышли за рамки количества ходов - остановить
            // статус чек идет перед каждым действием , раньше проверки  if (alive)
        }
        static void MethodVar1(Unit unit)
        {
            Stat.BloodLoss(unit); 
        }
        public static void Stun(Unit unit)
        {
            StunCount = Fight.fight_count + 2;
            unit.Stunned = true;
            Console.WriteLine("ОГЛУШИЛ");
        }
        public static void StunCheck(Unit unit)
        {
            if (Fight.fight_count>= StunCount)
            {
                unit.Stunned = false;
            }
        }
        public static void BloodLoss(Unit unit)
        {
            if (unit.BloodLoss)
            {
                unit.Health -= 1;
                Console.WriteLine($"Кровотечение нанесло ");
            }
        }
    }
}
