class ProductShipper
{
    public static void Ship(Customer customer, Product product)
    {
        decimal price = ComputePrice(customer, product);

        SendTrackingToCustomer(
            customer.PhoneNumber,
            $"""
            Shipping your "{product.Name}" at a price of DKK {price:f2}
            """
        );
    }

    private static decimal ComputePrice(Customer customer, Product product)
    {
        if (customer.IsClubMember)
        {
            return 0.9m * product.Price;
        }
        else
        {
            return product.Price;
        }
    }

    private static void SendTrackingToCustomer(
        string phoneNumber,
        string trackingMessage
    )
    {
        // Validate phone number
        if (phoneNumber.Any(c => !char.IsDigit(c)))
        {
            throw new PhoneNumberException(phoneNumber);
        }

        // Physically send SMS
        // ...
        Console.WriteLine(trackingMessage);
    }
}
