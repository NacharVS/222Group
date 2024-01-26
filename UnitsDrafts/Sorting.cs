using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts
{



    //public class Weapon
    // {
    //  public string Name { get; set; }
    //  public int Damage { get; set; }

    //  public Weapon(string name, int damage)
    //   {
    //       Name = name;
    //      Damage = damage;
    //  }
    // }

    internal class Sorting
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public Sorting(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }

        public static void Sorter()
        {
            List<Sorting> weapons = new List<Sorting>
        {
            new Sorting("Sword", 15),
            new Sorting("Axe", 20),
            new Sorting("Dagger", 5),
            new Sorting("Bow", 10)
        };

            Console.WriteLine("Weapons (unsorted):");
            foreach (Sorting weapon in weapons)
            {
                Console.WriteLine($"Name: {weapon.Name}, Damage: {weapon.Damage}");
            }

            weapons.Sort((w1, w2) => w1.Damage.CompareTo(w2.Damage));

            Console.WriteLine("\nWeapons (sorted by minimum damage):");
            foreach (Sorting weapon in weapons)
            {
                Console.WriteLine($"Name: {weapon.Name}, Damage: {weapon.Damage}");
            }
        }
    }
}
