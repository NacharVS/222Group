using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsDrafts;

namespace UnitsDrafts
{
    internal class Equipment
    {
        internal static int Length;

        public static string Name { get; set; }
        public static int Damage { get; set; }

        public Equipment (string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
    }

public static class GnomeSort
{
    public static void Main(string[] args)
        {
            Equipment[] equipments =
                {
            new Equipment("меч", 10),
            new Equipment("топор", 8),
            new Equipment("лук", 5),
            new Equipment("булава", 12),
            new Equipment("копье", 6)
        };

            Console.WriteLine("Исходный порядок оружия:");
            PrintArray(equipments);

            GnomeSortEquipments(equipments);

            Console.WriteLine("\nОтсортированный порядок оружия по минимальному урону:");
            PrintArray(equipments);
        }

        public static void GnomeSortEquipments(Equipment[] equipment)
        {
            int n = UnitsDrafts.Equipment.Length;
            int i = 1;

            while (i < n)
            {
                if (i == 0 || equipment[i - 1].Damage <= equipment[i].Damage)
                {
                    i++;
                }
                else
                {
                    Swap(equipment, i - 1, i);
                    i--;
                }
            }
        }

        public static void Swap(Equipment[] equipment, int i, int j)
        {
        Equipment temp = equipment[i];
        equipment[i] = equipment[j];
        equipment[j] = temp;
        }

        public static void PrintArray(Equipment[] equipment)
        {
            foreach (Equipment equipments in equipment)
            {
                Console.WriteLine($"{Equipment.Name}: {Equipment.Damage}");
            }
        }
    }
}
