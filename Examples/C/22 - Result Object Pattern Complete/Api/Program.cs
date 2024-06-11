using CleanCode.Application;
using CleanCode.Domain;
using CleanCode.Infrastructure;

IOrderRepository repository = new OrderRepository();
var orders = repository.GetAll();

var orderHandler = new OrderHandler();
foreach (Order order in orders)
{
    ProcessOrderResult result = orderHandler.Process(order);

    Console.WriteLine( result switch
    {
        { Kind: ProcessOrderResultKind.Success } => "Successfully processed",
        _ => result.Kind
    });
}

