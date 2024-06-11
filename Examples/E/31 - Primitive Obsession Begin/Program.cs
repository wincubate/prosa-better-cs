Customer customer = new()
{
    Id = Guid.NewGuid(),
    FirstName = "Keanu",
    LastName = "Reaves",
    IsClubMember = true,
    Email = "keanu@reaves.com",
    PhoneNumber = "1800666777"
};

Product product = new()
{
    Id = 1,
    Name = "Continuum Transfunctioner",
    VendorId = 87,
    Price = 42
};

ProductShipper.Ship(customer, product);
