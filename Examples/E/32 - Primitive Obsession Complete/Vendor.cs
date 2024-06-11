readonly record struct VendorId(int Id);

record Vendor
{
    public required VendorId Id { get; init; }

    // ...
}