using Practical_Training.Models.Orders;

namespace Practical_Training.Repositories
{
    public interface IOrderRepository
    {
        IEnumerable<OrderBase> GetAll();
        OrderBase GetById(int id);

    }
}
