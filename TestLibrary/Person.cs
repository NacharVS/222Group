using UnitsDrafts;

namespace TestLibrary
{
    public class Person 
    {
        UserGeneric<int, int> qq;
        
        void Qq()
        {
            Console.WriteLine(qq.Id);
        }
    }
}