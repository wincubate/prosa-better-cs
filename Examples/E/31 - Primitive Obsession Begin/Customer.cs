class Customer
{
    public required Guid Id { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public string? Email { get; set; }
    public required string PhoneNumber { get; init; }

    public bool IsClubMember { get; set; }
}
