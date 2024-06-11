using System;
using System.Collections.Generic;
using System.Linq;

namespace Wincubate.CS10.Slide05;

class Person
{
    public string FirstName { get; }   
    public string MiddleName { get; }  
    public string LastName { get; }

    public string MiddleInitial => MiddleName?.Substring(0, 1);

    public int NameLength =>
        FirstName.Length +
        LastName.Length;

    public int ExpandedNameLength =>
        FirstName.Length +
        MiddleName.Length +
        LastName.Length;

    public Person( string firstName)
    {
        FirstName = firstName;
    }

    public Person( string firstName, string middleName, string lastName)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IEnumerable<Person> persons = new List<Person>
        {
            new Person( "Casper", "Højer", "Nielsen"),
            new Person( "Bruce", null, "Campbell"),
            new Person( "Shigeru", null, "Miyamoto"),
            new Person( "Jesper", "Gulmann", "Henriksen")
        };

        var personsWithMiddleNames = persons
            .Where(p => string.IsNullOrWhiteSpace(p.MiddleName) == false)
            ;
        foreach (var person in personsWithMiddleNames)
        {
            Console.WriteLine( person.ExpandedNameLength);
        }
    }
}
