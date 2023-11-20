using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit.units;

namespace unit
{
    internal static class Stat
    {
        public static int BishopQuant = 0;
        public static int PeasantQuant = 0;
        public static int ArcherQuant = 0;
        public static int FootmanQuant = 0;
        public static int LiveQuant = 0;
        public static int KilledQuant = 0;
        public static int Stuncount = 0;
        public static int BloodLosscount = 0;

        public static  void StatInfo()
        {
            Console.WriteLine($" Количество Bishop:{BishopQuant} \n Количество Peasant:{PeasantQuant} \n Количество Archer:{ArcherQuant} \n Количество Footman:{FootmanQuant}");
            Console.WriteLine($" Живых:{LiveQuant} \n Мертвых:{KilledQuant}");
        }
        public static void Stun(Unit unit)
        {
            Stuncount = Duel.FightCount + 2;
            unit.Stun = true;

        }
        public static void StunCheck(Unit unit)
        {
            if (Duel.FightCount >= Stuncount)
            {
                unit.Stun = false;
            }
        }
        public static void Bloodloss(Unit unit)
        {
            BloodLosscount = Duel.FightCount + 10;
            unit.Blodloss = true;
            unit.Health -= 1;
            Console.WriteLine($"bleeding, health{unit.Health}, name{unit.Name}");

        }
        public static void BloodLossCheck(Unit unit)
        {
            if (Duel.FightCount >= BloodLosscount)
            {
                unit.Blodloss = false;
            }
        }
    }
}

