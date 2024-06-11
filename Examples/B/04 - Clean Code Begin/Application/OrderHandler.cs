using CleanCode.Domain;

namespace CleanCode.Application;

class OrderHandler
{
    public void Process(Order order)
    {
        if (order != null)
        {
            if (order.Unverified == false)
            {
                if (order.OrderLines.Count > 0)
                {

                    int a = 0;
                    foreach (OrderLine line in order.OrderLines)
                    {
                        a += line.Count;
                    }

                    if (a > 8)
                    {
                        throw new Exception(
                            "The order " + order.Id + " has too many items");
                    }

                    if (order.OrderStatus != "ReadyForProcessing")
                    {
                        throw new Exception(
                            "The order " + order.Id + " isn't ready for processing");
                    }

                    order.Processed = true;
                }
            }
        }
    }
}
