namespace CleanCode.Domain;

sealed class NotReadyForProcessingException(Order order)
    : Exception($"The order {order.Id} isn't ready for processing")
{
    public int OrderId { get; set; } = order.Id;
}
