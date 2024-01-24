using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    internal class Member
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public Member(string login, string name, string surname, string age)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
