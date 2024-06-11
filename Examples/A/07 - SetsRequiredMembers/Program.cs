using System.Diagnostics.CodeAnalysis;

var person = new Person("Shigeru", "Miyamoto");

Console.WriteLine(person.FirstName);

record Person
{
    public required string FirstName { get; init; }
    public string? MiddleName { get; init; }
    public required string LastName { get; init; }

    [SetsRequiredMembers]
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
