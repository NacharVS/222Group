using System.Collections;

namespace TestLibrary
{
    public class Person : IEnumerable
    {
        public string[] listOfPersons = { "Bob", "Sam", "Jeff", "Rob" };
        IEnumerator IEnumerable.GetEnumerator() => listOfPersons.GetEnumerator();


        public static void ForeachTipo(IEnumerator enumerator)
        {
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

        }

    }
}