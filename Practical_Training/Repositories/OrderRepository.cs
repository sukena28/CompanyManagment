using Practical_Training.Models.Orders;
using Practical_Training.Models.Orders.Concrete;
using Practical_Training.Repositories.Base;

namespace Practical_Training.Repositories
{
    public class OrderRepository : BaseRepository<OrderBase>, IOrderRepository
    {
        private static List<OrderBase> _orders;
        public OrderRepository() : base(GetEntities())
        {
        }
        private static List<OrderBase> GetEntities()
        {
            if (_orders != null)
                return _orders;

            return Seed();
        }
        private static List<OrderBase> Seed()
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

            return _orders;
        }
    }
}
