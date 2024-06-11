using CleanCode.Domain;

namespace CleanCode.Application;

interface IOrderRepository
{
    List<Order> GetAll();
}