using System.Collections;

namespace TestLibrary
{
    public class Person : IEnumerable
    {
        string[] listOfPersons = { "Bob", "Sam", "Jeff", "Rob" };
        IEnumerator IEnumerable.GetEnumerator() => listOfPersons.GetEnumerator();

    }
}