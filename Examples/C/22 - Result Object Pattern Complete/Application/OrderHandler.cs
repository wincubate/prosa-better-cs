using CleanCode.Domain;

namespace CleanCode.Application;

class OrderHandler
{
    private const int MaxNumberOfItems = 8;

    public ProcessOrderResult Process(Order? order)
    {
        if (!IsProcessable(order))
        {
            return ProcessOrderResult.NotProcessable();
        }

        if (HasTooManyItems(order!))
        {
            return ProcessOrderResult.HasTooManyItems(order!);
        }

        if (order!.OrderStatus != OrderStatus.ReadyForProcessing)
        {
            return ProcessOrderResult.NotReadyForProcessing(order);
        }

        order.IsProcessed = true;

        return ProcessOrderResult.Success(order);
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
