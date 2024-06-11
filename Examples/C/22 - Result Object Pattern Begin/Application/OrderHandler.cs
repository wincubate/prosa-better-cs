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
            throw new HasTooManyItemsException(order!);
        }

        if (order!.OrderStatus != OrderStatus.ReadyForProcessing)
        {
            throw new NotReadyForProcessingException(order);
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
