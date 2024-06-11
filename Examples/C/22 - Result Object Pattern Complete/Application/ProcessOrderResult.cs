using CleanCode.Domain;

namespace CleanCode.Application;

record ProcessOrderResult
{
    public ProcessOrderResultKind Kind { get; }
    public int? OrderId { get; }
    public string Message { get; }

    private ProcessOrderResult(
        ProcessOrderResultKind kind,
        Order? order = default,
        string message = "")
    {
        Kind = kind;
        Message = message;
        OrderId = order?.Id;
    }

    public static ProcessOrderResult Success(Order order) => new(
        ProcessOrderResultKind.Success,
        order
    );

    public static ProcessOrderResult NotProcessable() => new(
        ProcessOrderResultKind.NotProcessable
    );

    public static ProcessOrderResult HasTooManyItems(Order order) => new(
        ProcessOrderResultKind.HasTooManyItems,
        order,
        $"The order {order.Id} has too many items"
    );

    public static ProcessOrderResult NotReadyForProcessing(Order order) => new(
        ProcessOrderResultKind.NotReadyForProcessing,
        order,
        $"The order {order.Id} isn't ready for processing"
    );
}
