using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registration
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }

        public Person(string name, string surname, string login)
        {
            Name = name;
            Surname = surname;
            Login = login;
        }
    }
}
