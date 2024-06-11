readonly record struct ProductId(int Id);

class Product
{
    public required ProductId Id { get; init; }
    public required string Name { get; init; }
    public required VendorId VendorId { get; init; } 
    
    public decimal Price { get; init; } 
}
