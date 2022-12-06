using Practical_Training.Models.Orders;
using Practical_Training.Models.Orders.Concrete;

namespace Practical_Training.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        private static IEnumerable<OrderBase> _orders;
        public OrderRepository()
        {
            Seed();
        }
        public IEnumerable<OrderBase> GetAll()
        {
            return _orders;
        }
        public OrderBase GetById(int id)
        {
            var order = _orders.FirstOrDefault(x => x.Id == id);

            if (order == null)
                throw new Exception($"The Order of id {id} is not exists");

            return order;
        }
        private void Seed()
        {
            if (_orders == null)
            {

                var basicOrder = new BasicOrder() { Id = 1, Name = "Basic Order", Price = 20 };
                var recurringOrder = new RecurringOrder() { Id = 1, Name = "Recurring Order", Price = 20 };
                var specialOrder = new SpecialOrder() { Id = 2, Name = "Special Order", Price = 50, GiftOrder = recurringOrder };

                _orders = new List<OrderBase>()
            {
                basicOrder,
                recurringOrder,
                specialOrder
            };
            }


        }
    }
}
