using Newtonsoft.Json;
using Practical_Training.Models.Virstual;

namespace Practical_Training.Models.Orders.Concrete
{
    public class SpecialOrder : OrderBase, IPrintableOrder, IHasGiftOrder
    {
        public RecurringOrder GiftOrder { get; set; }


        public override string GetOrderInformation()
        {
            return $"{base.GetOrderInformation()} Extra Information: {Print()},  Gift is {JsonConvert.SerializeObject(GiftOrder)}";

        }

        public void AddGift(RecurringOrder giftOrder)
        {
            GiftOrder = giftOrder;
        }

        public override double GetDiscount(double amount)
        {
            return base.GetDiscount(amount) - 50;
        }

        public string Print()
        {
            return "Special Order will be print in the file ";
        }

    }
}
