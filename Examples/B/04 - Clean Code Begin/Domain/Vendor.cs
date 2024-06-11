namespace CleanCode.Domain;

class Vendor
{
    public required string Id { get; init; }

    private readonly string _name;
    public string Name => _name;

    public Vendor(string id, string name)
    {
        Id = id;
        _name = name;
    }
}