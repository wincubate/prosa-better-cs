namespace CleanCode.Domain;

class OrderLine
{
    public required int Count { get; init; }
    public required Product Product { get; init; }
}
