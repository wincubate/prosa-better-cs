readonly record struct CustomerId(Guid Id)
{
    public CustomerId() : this(Guid.NewGuid())
    {
    }
}

class Customer
{
    public required CustomerId Id { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public string? Email { get; set; }
    public required PhoneNumber PhoneNumber { get; init; }

    public IMembership Membership { get; set; } = new NotMember();
}
