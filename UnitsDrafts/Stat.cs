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
            BloodLoss(unit);
        }
        public static void Stun(Unit unit)
        {
            StunCount = Fight.fight_count + 2;
            unit.Stun = true;
            Console.WriteLine("ОГЛУШИЛ");
        }
        public static void StunCheck(Unit unit)
        {
            if (Fight.fight_count >= StunCount)
            {
                unit.Stun = false;
            }
        }

        public static void BloodLoss(Unit unit)
        {
            if (unit.BloodLoss)
            {
                unit.Health -= 1;
                Console.WriteLine("Кровотечение");
            }
        }
    }
}
