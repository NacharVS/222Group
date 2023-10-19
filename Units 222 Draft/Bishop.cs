﻿using System.Xml.Linq;

namespace UnitsDrafts
{
    internal class Bishop : Unit
    {
        private int _mana;
        private int _maxmana;

        public Bishop(string name, int maxHealth, int defense, int damage, int speed, int mana,int maxmana)
            : base(name, maxHealth,defense,damage, speed)
        {
            _mana = mana;
            _maxmana = maxmana;
        }

        public Bishop() : base("Bishop", 60,7,10,10)
        {
            _maxmana = 100;
            _mana = _maxmana;
        }
        public int MaxMana
        {
            get;
            set;
        }
        public int Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }
        public void Healing(Unit unit)
        { if (Alive)
            {
                if (_mana >= 10)
                {
                    if (unit.Health < unit.MaxHealth)
                    {
                        unit.Health = unit.Health + 20;
                        if (unit.Health > unit.MaxHealth)
                        {
                            unit.Health = unit.MaxHealth;
                        }
                        _mana = _mana - 10;
                        Console.WriteLine($"У юнита осталось {_mana} / {_maxmana} маны");
                        Console.WriteLine($"Юнит {unit.Name} вылечил 20 HP");
                        Console.WriteLine($"Текущее HP {unit.Health} / {unit.MaxHealth}");
                    }
                    else
                    {
                        Console.WriteLine("Юниту не нужен хил");
                    }
                }
                else
                {
                    Console.WriteLine("У вас недостаточно маны!");
                    Mp_cheak();

                }
            }
            else
            {
                Console.WriteLine("Мертвый юнит не может хилять");
            }
        }
        public void Mp_cheak()
        {
            if (Alive)
            {
                Console.WriteLine($"Маны {_mana} / {_maxmana}");
            }
            else 
            { 
                Console.WriteLine("юнит сдох, манны в трупе не так уж и много"); 
            }
        }
    }
}