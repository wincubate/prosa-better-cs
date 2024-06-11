namespace CleanCode.Domain;

class Order
{    
    public int Id { get; set; }
    public List<OrderLine> OrderLines { get; set; }

    public bool Unverified { get; set; }
    public bool Processed { get; set; }

    public string OrderStatus { get; set; } = "ReadyForProcessing";

    public Order()
    {        
    }

    public Order(int id, IEnumerable<OrderLine> orderLines)
    {
        Id = id;
        OrderLines = orderLines.ToList();
        OrderStatus = "ReadyForProcessing";
    }

    public Order(int id, IEnumerable<OrderLine> orderLines, bool unverified)
        : this(id, orderLines)
    {
        Unverified = unverified;
    }
}
