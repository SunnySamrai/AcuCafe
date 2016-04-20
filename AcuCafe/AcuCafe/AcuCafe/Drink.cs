using System;
using System.Text;

namespace AcuCafe
{
    public abstract class Drink
    {
        public const double MilkCost = 0.5;
        public const double SugarCost = 0.5;

        public virtual bool HasMilk { get; set; }
        public virtual bool HasSugar { get; set; }

        public abstract string Description { get; }

        public abstract double Cost();

        public virtual void Prepare(Drink drink)
        {
            var message = new StringBuilder(string.Format("We are preparing the following drink for you: {0}{1}", Environment.NewLine, Description));
            message.AppendLine(HasMilk ? "with milk" : "without milk");
            message.AppendLine(HasSugar ? "with sugar" : "without sugar");

            Console.WriteLine(message);
        }
    }
}
