var person = new Person
{
    FirstName = "Shigeru",
    LastName = "Miyamoto"
};

Console.WriteLine(person.FirstName);

record Person
{
    public required string FirstName { get; init; }
    public string? MiddleName { get; init; }
    public required string LastName { get; init; }
}
