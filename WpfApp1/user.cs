using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Age { get; set; }

        public User(string name, string surname, string email, string password, string age)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            Age = age;
        }

        public static List<string> getsimplelist()
        {
            List<string> list = new List<string>();
            list.Add("name");
            list.Add("gay");
            return list;
        }
    }
}
