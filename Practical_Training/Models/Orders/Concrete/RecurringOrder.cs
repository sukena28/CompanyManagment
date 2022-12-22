using Practical_Training.Models.Virstual;

namespace Practical_Training.Models.Orders.Concrete
{
    public class RecurringOrder : OrderBase, IPrintableOrder
    {

        public override string GetOrderInformation()
        {
            return $"{base.GetOrderInformation()}  Extra Information: {Print()}";

        }
        public override double GetDiscount(double amount)
        {
            return base.GetDiscount(amount) - 20;
        }

        public string Print()
        {
            return "Recurring Order will be print in the file ";
        }
    }
}
