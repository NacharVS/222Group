namespace UnitsDrafts
{
    internal class WatchingTower : Archer
    {
        public int ArcherInWT = 3;
        public void Garrison()
        {
            Archer archer1 = new Archer();
            List<Unit> units = new List<Unit>();
            units.Add(archer1);
            units.Add(archer1);
            units.Add(archer1);

            foreach (Archer unit in units)
            {
                unit.BaseInfo();
            }
            Console.WriteLine("Если хочешь улучшить башню нажми 1");
            for (int i = 1; i < 8; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    units.Add(archer1);
                    foreach (Archer unit in units)
                    {
                        unit.BaseInfo();
                    }
                    Console.WriteLine($"Башня улучшена. Число Лучников: {ArcherInWT + i} ");
                    Console.WriteLine($"Ваша башня прокачена до {i + 1} уровня");
                    Console.WriteLine("Для улучшения Башни нажмите 1");
                }


            }
            Console.WriteLine("Максимальное улучшение");

        }

        int damage = 10;
        public void DamageWT(Unit unit)
        {
            Console.WriteLine("Если хотите нанести урон башней нажмите 1");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                int DamageWT = damage * ArcherInWT;
                unit.Health = unit.Health - DamageWT;
                Console.WriteLine($"Вашему герою нанесено {DamageWT} урона");

            }

        }

    }
}