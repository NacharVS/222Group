using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace unit.units
{

    internal class Bishop : Unit
    {
        private int _mana;
        public delegate void HealSomebodyDelegate(Unit unit);
        public HealSomebodyDelegate healSomebody;
        public Bishop(string name, int maxHealth, int speed, int mana, int damage, int defence)
            : base(name, maxHealth, speed, defence  )
        {
            _mana = mana;
        }
        public Bishop() : base("bishop", 0, 20, 4)
        {
            _mana = 19;
        }
        public int Mana
        {
            get { return _mana; }
            set
            {
                if (value < 0)
                {
                    _mana = 0;
                }
                else
                    _mana = value;
            }
        }

        public void HealSomebodyMethod(Unit unit)
        {
            Console.WriteLine("был заюзан делегат");
            if (Alive)
            {
                if (unit.Alive)
                {
                    if (unit.Health > 0)
                    {
                        if (_mana > 1)
                        {
                            unit.Health += 8;
                            if (unit.Health >= unit.MaxHealth)
                            {
                                unit.Health = unit.MaxHealth;
                            }
                            _mana--;
                        }
                        if (unit.Health <= 0)
                        {
                            Console.WriteLine("Лечение игрока невозможно, так как он мертв");
                        }
                    }
                    else
                        Console.WriteLine("Персонаж умер, его нельзя хилить");
                }
                else
                {
                    Console.WriteLine("Юнит мертв");
                }
            }
            else
            {   
                
                Console.WriteLine("Персонаж не может хилить, он мертв");
            }


        }
        
        public void HealSomebody(Unit unit)
        {
            healSomebody = HealSomebodyMethod;
            healSomebody(unit);
        }
        
        public void ManaInfo()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"mana:{_mana}");
            Console.ResetColor();
        }
        public override void TakedDamage(int damage)
        {
            int takedDamage = damage - Defence;
            if (takedDamage < 0)
            {
                takedDamage = 0;
            }
            Health -= takedDamage;
        }
    }





}




