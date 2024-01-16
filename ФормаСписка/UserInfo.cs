using System.Collections.Generic;

namespace ФормаСписка
{
    internal class UserInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public UserInfo (string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
