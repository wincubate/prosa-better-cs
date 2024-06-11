namespace CleanCode.Domain;

class Vendor(string id, string _name)
{
    public required string Id { get; init; } = id;
    public string Name => _name;
}