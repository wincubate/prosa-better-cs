using CleanCode.Domain;

namespace CleanCode.Application;

class OrderHandler
{
    private const int MaxNumberOfItems = 8;

    public void Process(Order? order)
    {
        if (!IsProcessable(order))
        {
            return;
        }

        if (HasTooManyItems(order!))
        {
            throw new Exception($"The order {order!.Id} has too many items");
        }

        if (order!.OrderStatus != OrderStatus.ReadyForProcessing)
        {
            throw new Exception($"The order {order.Id} isn't ready for processing");
        }

        order.IsProcessed = true;
    }

    private static bool HasTooManyItems(Order order)
    {
        int itemCount = order.OrderLines
            .Sum(orderLine => orderLine.Count);
        bool hasTooManyItems = itemCount > MaxNumberOfItems;

        return hasTooManyItems;
    }

    private static bool IsProcessable(Order? order) =>
        order is
        {
            IsVerified: true,
            OrderLines.Count: > 0
        };
}
