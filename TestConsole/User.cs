namespace TestConsole
{
    class User 
    {
      
        
        private int id;
        private string name;
        private int age;

        public User()
        {

        }
        public User(string name, int age)
        {
            id = 0;
            this.name = name;
            this.age = age;
        }

        public User(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {id} Name: {name} Age: {age}");
        }

        public void ChangeName(string newname)
        {
            name = newname;
        }
    }
}
