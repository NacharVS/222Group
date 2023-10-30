using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{
    internal class Sorting
    {
        public static void gnome()
        {
            Console.WriteLine("Гномья сортировка");

            Sword sword = new Sword();
            Bow bow = new Bow();
            Scepter scepter = new Scepter();
            var array = new Weapon[3] { sword, bow, scepter };
            var denis = GnomeSort(array);
            foreach (Weapon weapon in denis)
            {
                Console.WriteLine(weapon.WepName + " " + weapon.MinDamage);
            }

            static void Swap(ref Weapon item1, ref Weapon item2)
            {
                var temp = item1;
                item1 = item2;
                item2 = temp;
            }

            static Weapon[] GnomeSort(Weapon[] unsortedArray)
            {
                var index = 1;
                var nextIndex = index + 1;

                while (index < unsortedArray.Length)
                {
                    if (unsortedArray[index - 1].MinDamage < unsortedArray[index].MinDamage)
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                    else
                    {
                        Swap(ref unsortedArray[index - 1], ref unsortedArray[index]);
                        index--;
                        if (index == 0)
                        {
                            index = nextIndex;
                            nextIndex++;
                        }
                    }
                }

                return unsortedArray;
            }

        }
    }
}
