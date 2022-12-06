using Practical_Training.Models.Orders;
using Practical_Training.Repositories;

namespace Practical_Training.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(
            IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public IEnumerable<OrderBase> GetAll()
        {
            var records = _orderRepository.GetAll();

            return records;
        }
        public IEnumerable<string> GetDetails()
        {
            var records = _orderRepository.GetAll();

            return records.Select(x => x.GetOrderInformation()).ToList();
        }
        public OrderBase Get(int id)
        {
            var record = _orderRepository.GetById(id);

            return record;
        }

    }
}
