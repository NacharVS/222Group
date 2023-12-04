namespace UnitsDrafts
{
    internal class ANKETA
    {
        public string Surname;
        public string Name;
        public string Description;
        public int Age;

        public ANKETA(string surname, string name, string description, int age)
        {
            Surname = surname;
            Name = name;
            Description = description;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Surname} {Name} {Description} {Age}");
        }

    }
}
