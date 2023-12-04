using System.Collections;

namespace TestLibrary
{
    public class Person : IEnumerable
    {
        public string[] listOfPersons = { "Bob", "Sam", "Jeff", "Rob" };
        IEnumerator IEnumerable.GetEnumerator() => listOfPersons.GetEnumerator();


        public static void ForeachTipo(IEnumerator enumerator)
        {
            
            if (enumerator.MoveNext())
            {
                enumerator.MoveNext();
                Console.WriteLine(enumerator.Current);
            }
        }

    }
}