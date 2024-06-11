namespace CleanCode.Domain;

enum OrderStatus
{
    Initial = 0,
    ReadyForProcessing = 1,
    Completed = 2
}

class Order
{    
    public required int Id { get; init; }
    public required List<OrderLine> OrderLines { get; init; }

    public bool IsVerified { get; set; } = true;
    public bool IsProcessed { get; set; } = false;

    public OrderStatus OrderStatus { get; set; } = OrderStatus.ReadyForProcessing;
}
