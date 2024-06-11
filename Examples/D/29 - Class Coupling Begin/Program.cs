Employee employee = new()
{
    FirstName = "Shigeru",
    LastName = "Miyamoto"
};

class Employee
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }

    public string FullName => $"{FirstName} {LastName}";
}
