class ProductShipper
{
    public static void Ship(Customer customer, Product product)
    {
        decimal price = customer.Membership.ApplyDiscount(product.Price);

        SendTrackingToCustomer(
            customer.PhoneNumber,
            $"""
            Shipping your "{product.Name}" at a price of DKK {price:f2}
            """
        );
    }

    private static void SendTrackingToCustomer(
        PhoneNumber phoneNumber,
        string trackingMessage
    )
    {
        // Physically send SMS
        // ...
        Console.WriteLine(trackingMessage);
    }
}
