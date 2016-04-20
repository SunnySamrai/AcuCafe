using System;
using System.Text;

namespace AcuCafe
{
    public class IceTea : Drink
    {
        public override string Description
        {
            get { return "Ice tea"; }
        }

        public override bool HasMilk
        {
            set
            {
                if (value)
                {
                    throw new ApplicationException("Milk has been selected with Ice Tea, please check selection, operation aborted...");
                }
            }
        }

        public override double Cost()
        {
            double cost = 1.5;

            if (HasMilk)
            {
                throw new ApplicationException("Milk has been selected with Ice Tea, please check selection, operation aborted...");
            }

            if (HasSugar)
            {
                cost += SugarCost;
            }

            return cost;
        }

        public override void Prepare(Drink drink)
        {
            var message = new StringBuilder(string.Format("We are preparing the following drink for you: {0}{1}", Environment.NewLine, Description));
            message.AppendLine(HasSugar ? "with sugar" : "without sugar");

            Console.WriteLine(message);
        }
    }
}
