namespace CleanCode.Domain;

sealed class HasTooManyItemsException(Order order)
    : Exception($"The order {order!.Id} has too many items")
{
    public int OrderId { get; set; } = order.Id;
}
