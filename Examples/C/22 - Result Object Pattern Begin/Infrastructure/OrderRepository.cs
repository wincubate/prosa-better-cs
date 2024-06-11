using CleanCode.Application;
using CleanCode.Domain;

namespace CleanCode.Infrastructure;

class OrderRepository : IOrderRepository
{
    public List<Order> GetAll() =>
    [
        new Order
        {
            Id = 1,
            OrderLines =
            [
                new()
                {
                    Count = 2,
                    Product = new()
                    {
                        Id = 87,
                        Name = "Clean Code by Robert C. Martin",
                        VendorId = 33
                    }
                }
            ],
            IsVerified = true
        },
        new Order
        {
            Id = 1,
            OrderLines =
            [
                new()
                {
                    Count = 666,
                    Product = new()
                    {
                        Id = 112,
                        Name = "Spaghetti Code 101",
                        VendorId = 33
                    }
                }
            ],
            IsVerified = true
        },
    ];
}
