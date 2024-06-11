Employee employee = new()
{
    FirstName = "Shigeru",
    LastName = "Miyamoto"
};
employee.PrintFullName();

class Employee
{
    public EmployeeLevel Level { get; init; } = EmployeeLevel.Junior;
    public required string FirstName { get; init; }
    public required string LastName { get; init; }

    public string FullName => $"{FirstName} {LastName}";

    public void PrintFullName()
    {
        A.Print(FullName);
    }
}

enum EmployeeLevel
{
    Junior = 0,
    Senior = 1,
    Lead = 2,
    Chief = 3
}

class A
{
    public static void Print(string s) => Console.WriteLine(s);
}
