using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit.items;

namespace UnitsDrafts
{
    internal class Stat
    {
        public static int BishopQuant = 0;
        public static int PeasantQuant = 0;
        public static int FootmanQuant = 0;
        public static int ArcherQuant = 0;

        public static int StunCount = 0;

        public static void ShowInfo()
        {
            Console.WriteLine($"{FootmanQuant} пехотинцев");
            Console.WriteLine($"{PeasantQuant} крестьян");
            Console.WriteLine($"{BishopQuant} магов");
            Console.WriteLine($"{ArcherQuant} лучников");
        }

        public static void StatusCheck(Unit unit)
        {
            StunCheck(unit);
            BloodCheck(unit);
        }
        public static void Stun(Unit unit)
        {
            StunCount = Fight.FightCount + 2;
            unit.Stun = true;
            Console.WriteLine("Оглушение");
        }
        public static void StunCheck(Unit unit)
        {
            if (Fight.FightCount >= StunCount)
            {
                unit.Stun = false;
            }
        }

        public static void BloodCheck(Unit unit)
        {
            if (unit.BloodLoss)
            {
                unit.Health -= 1;
                Console.WriteLine("Кровотечение");
            }
        }
    }
}
