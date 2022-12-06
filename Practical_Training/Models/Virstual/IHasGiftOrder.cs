using Practical_Training.Models.Orders.Concrete;

namespace Practical_Training.Models.Virstual
{
    public interface IHasGiftOrder
    {
        public RecurringOrder GiftOrder { get; set; }

        public void AddGift(RecurringOrder order);

    }
}
