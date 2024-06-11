interface IMembership
{
    decimal ApplyDiscount(decimal price);
}

class ClubMembership : IMembership
{
    public decimal ApplyDiscount(decimal price)
    {
        return 0.9m * price;
    }
}

class NotMember : IMembership
{
    public decimal ApplyDiscount(decimal price) => price;
}