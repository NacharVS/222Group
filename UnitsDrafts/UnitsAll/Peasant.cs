using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsDrafts.UnitsAll
{
    internal class Peasant : Unit
    {
        public Peasant() : base("Peasant", 30, 5, 0, 0, null)
        {

        }
        public override void BaseInfo()
        {

            if (Health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Name: {Name} |");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Health: Юнит мертв!");
                Console.ResetColor();
                Console.Write("|");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Name: {Name} |");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Health: {Health}/{MaxHealth}");
                Console.ResetColor();
                Console.Write(" | ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Speed: {Speed}");
                Console.ResetColor();
                Console.WriteLine(" | ");
            }
        }
    }
}