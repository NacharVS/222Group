using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.items
{
    internal class GnomeSort
    {
        public static void GnomeSortWeapons(Weapon[] weapons)
        {
            int index = 1;
            int nextIndex = index + 1;

            while (index < weapons.Length)
            {
                if (weapons[index - 1].MinDamage < weapons[index].MinDamage)
                {
                    index = nextIndex;
                    nextIndex++;
                }
                else
                {
                    Swap(weapons, index - 1, index);
                    index--;
                    if (index == 0)
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                }
            }
        }

        private static void Swap(Weapon[] weapons, int i, int j)
        {
            Weapon temp = weapons[i];
            weapons[i] = weapons[j];
            weapons[j] = temp;
        }
    }
}
