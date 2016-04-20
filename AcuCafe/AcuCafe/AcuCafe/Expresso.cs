namespace AcuCafe
{
    public class Expresso : Drink
    {
        public override string Description
        {
            get { return "Expresso"; }
        }

        public bool ChocolateTopping { get; set; }

        public override double Cost()
        {
            double cost = 1.8;

            if (HasMilk)
            {
                cost += MilkCost;
            }

            if (HasSugar)
            {
                cost += SugarCost;
            }

            return cost;
        }
    }
}
