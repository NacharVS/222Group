using System.Collections.Generic;

namespace WPFStart
{
    internal class User
    {
        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }


        public static List<string> GetSimpleList()
        {
            List<string> list = new List<string>();
            list.Add("Ivanov");
            list.Add("Petrov");
            list.Add("Sidorov");
            list.Add("Farrahov");
            list.Add("Mitrofanov");
            return list;
        }

    }
}
