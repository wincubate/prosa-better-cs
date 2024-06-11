var person = new Person("Shigeru", "Miyamoto");
Console.WriteLine(person.FirstName);

record Person
{
    public string FirstName { get; init; }
    public string? MiddleName { get; init; }
    public string LastName { get; init; }

    public Person(string firstName, string lastName) : this(firstName, null, lastName)
    {
    }

    public Person(string firstName, string? middleName, string lastName)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }
}