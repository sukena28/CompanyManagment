using Practical_Training.Models.Orders;
using Practical_Training.Repositories.Base;

namespace Practical_Training.Repositories
{
    public interface IOrderRepository: IBaseRepository<OrderBase>
    {
        IEnumerable<OrderBase> GetAll();
        OrderBase GetById(int id);

    }
}
