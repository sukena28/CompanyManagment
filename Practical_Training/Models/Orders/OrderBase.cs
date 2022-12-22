using Practical_Training.Models.Share;

namespace Practical_Training.Models.Orders
{
    public abstract class OrderBase: BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public virtual double GetDiscount(double amount)
        {
            return 0;
        }

        public virtual string GetOrderInformation()
        {
            return $"Base Inforamation :  Id = {Id} , Name = {Name} , Price = {Price} ";
        }
    }

}