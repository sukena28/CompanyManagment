using Practical_Training.Models.Orders;

namespace Practical_Training.Service
{
    public interface IOrderService
    {
        IEnumerable<OrderBase> GetAll();  
        IEnumerable<string> GetDetails();

        OrderBase Get(int id);
    }
}
