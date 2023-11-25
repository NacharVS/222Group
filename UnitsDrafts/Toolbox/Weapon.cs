using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using UnitsDrafts.UnitsAll;
using static System.Net.Mime.MediaTypeNames;

namespace UnitsDrafts.Toolbox
{
    internal class Weapon
    {
        public Weapon(string weaponName, int minDamage, int maxDamage, double attackSpeed, double accuracy, float maxsolidity, int critChanse)
        {
            WeaponName = weaponName;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            AttackSpeed = attackSpeed;
            Accuracy = accuracy;
            MaxSolidity = maxsolidity;
            CritChanse = critChanse;
        }

        public string WeaponName { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public double AttackSpeed { get; set; }
        public double Accuracy { get; set; }
        public double CurSolidity { get; set; }
        public double MaxSolidity { get; set; }

        public int CritChanse { get; set; }

        public bool isWork = true;

        public virtual double Hit(Unit unit)
        {
            CurSolidity--;
            if (!isWork)
            {
                return 0;
            }
            else
            {
                float CritChance = 20;
                float CritDamage = 1;
                int x = new Random().Next(1, 100);
                if (x >= Accuracy)
                {
                    return 0;
                }
                else
                {
                    double Damage = new Random().Next(MinDamage, MaxDamage);
                    x = new Random().Next(1, 100);
                    if (x <= CritChance)
                    {
                        Damage += Damage * CritDamage;
                    }
                    return Damage * Solidity_control();
                }
            }

        }

        public virtual int Hit()
        {
            var x = new Random().Next(0, 100);
            if (x <= Accuracy)
            {
                return new Random().Next(MinDamage, MaxDamage + 1);
            }
            else
            {
                return 0;
            }

            x = new Random().Next(0, 100);
            if (x <= CritChanse)
            {
                //Damage = MaxDamage;
                Console.WriteLine("Был нанесен критический удар");

            }
        }

        public double Solidity_control()
        {
            //CurSolidity = Math.Sqrt(CurSolidity) * 0.3;

            //CurSolidity = Math.Pow(CurSolidity, 2) * 0.0019;
            

            switch (CurSolidity)
            {
                case > 1:
                    CurSolidity = Math.Pow(CurSolidity, 2) * 0.0019;
                    Console.WriteLine($"Прочность {CurSolidity}");
                    return CurSolidity;

                default:
                    CurSolidity = Math.Pow(CurSolidity, 2) * 0.0019;
                    Console.WriteLine($"Оружие сломалось {CurSolidity}.");
                    isWork = false;
                    Console.WriteLine("Оружие сломалось");
                    return 0;
            }

            //if (CurSolidity >= 60)
            //{
            //    return 1;   
            //}
            //else if (CurSolidity >= 40)
            //{
            //    return 0.69f;
            //}
            //else if (CurSolidity > 0)
            //{
            //    return 0.39f;
            //}
            //else
            //{
            //    isWork = false;
            //    Console.WriteLine("Оружие сломалось");
            //    return 0;

            //}
        }
    }
}
